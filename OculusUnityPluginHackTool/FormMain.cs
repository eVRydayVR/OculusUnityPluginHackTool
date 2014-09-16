using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OculusUnityPluginHackTool {
    public partial class FormMain : Form {
        PluginDll dll;
        string filename;
        List<PluginDll> dlls = new List<PluginDll>();

        int minCARow = 0;
        TextBox[,] textBoxCA = new TextBox[2,4];
        TextBox[] textBoxDistortion = new TextBox[11];

        public FormMain() {
            InitializeComponent();
            textBoxCA[0, 0] = textBoxCA0_0;
            textBoxCA[0, 1] = textBoxCA0_1;
            textBoxCA[0, 2] = textBoxCA0_2;
            textBoxCA[0, 3] = textBoxCA0_3;
            textBoxCA[1, 0] = textBoxCA1_0;
            textBoxCA[1, 1] = textBoxCA1_1;
            textBoxCA[1, 2] = textBoxCA1_2;
            textBoxCA[1, 3] = textBoxCA1_3;
            textBoxDistortion[0] = textBoxDistortion0;
            textBoxDistortion[1] = textBoxDistortion1;
            textBoxDistortion[2] = textBoxDistortion2;
            textBoxDistortion[3] = textBoxDistortion3;
            textBoxDistortion[4] = textBoxDistortion4;
            textBoxDistortion[5] = textBoxDistortion5;
            textBoxDistortion[6] = textBoxDistortion6;
            textBoxDistortion[7] = textBoxDistortion7;
            textBoxDistortion[8] = textBoxDistortion8;
            textBoxDistortion[9] = textBoxDistortion9;
            textBoxDistortion[10] = textBoxDistortion10;
        }

        private void FormMain_Load(object sender, EventArgs e) {
            LoadDllInfo();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Locate the OculusPlugin.dll file that you wish to modify";
            openFileDialog.Filter = "Application extension (*.dll)|*.dll";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            PluginDll matchingDll = null;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                try {
                    using (var stream = new BinaryReader(openFileDialog.OpenFile())) {
                        var bytes = stream.ReadBytes((int)new FileInfo(openFileDialog.FileName).Length);
                        foreach (var dll in dlls) {
                            if (dll.Matches(bytes)) {
                                matchingDll = dll;
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message, "Could not read file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                try {
                    if (matchingDll != null) {
                        this.dll = matchingDll;
                        this.filename = openFileDialog.FileName;
                        textBoxVersion.Text = this.dll.Version;

                        // Set number of CA rows based on version
                        minCARow = 1;
                        if (this.dll.Version == "0.4.2") {
                            minCARow = 0;
                        }
                        for (int i = 0; i < minCARow; i++) {
                            for (int j = 0; j < textBoxCA.GetLength(1); j++) {
                                textBoxCA[i, j].Enabled = false;
                            }
                        }

                        LoadFromDll(this.filename);
                        UpdateDirty(false);
                    } else {
                        MessageBox.Show(this, "Could not identify version of OculusPlugin.dll file. May be modified from original or may be unsupported version.", "Unidentified Plug-in Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(this, "Error: Encountered unexpected error: " + ex.Message + "\n\nPlease report with screenshot to: eVRydayVR@gmail.com", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            } else {
                this.Close();
            }
        }

        private void LoadDllInfo() {
            XDocument doc = XDocument.Load("dllinfo.xml");
            var dllTags = doc.Descendants("dll");
            foreach (var dll in dllTags) {
                var version = (string)dll.Attribute("version");
                var filename = (string)dll.Attribute("filename");
                var patchPoints = new Dictionary<String, IntRange>();
                foreach (var patch in dll.Descendants("patch")) {
                    int begin = int.Parse((string)patch.Attribute("offset"));
                    int end = begin + int.Parse((string)patch.Attribute("length"));
                    patchPoints.Add((string)patch.Attribute("name"), new IntRange(begin, end));
                }
                using (var stream = new BinaryReader(File.OpenRead(filename))) {
                    var bytes = stream.ReadBytes((int)new FileInfo(filename).Length);
                    dlls.Add(new PluginDll(version, filename, PluginDll.HashWithPatchPoints(bytes, patchPoints), patchPoints));
                }
            }
        }

        private string SingleFromOffset(byte[] bytes, string name) {
            return BitConverter.ToSingle(bytes, dll.GetOffset(name)).ToString("G");
        }

        private void LoadFromDllCA(string filename) {
            using (var stream = new BinaryReader(File.OpenRead(filename))) {
                var bytes = stream.ReadBytes((int)new FileInfo(filename).Length);
                for (int i = minCARow; i < textBoxCA.GetLength(0); i++) {
                    for (int j = 0; j < textBoxCA.GetLength(1); j++) {
                        textBoxCA[i, j].Text = SingleFromOffset(bytes, "CA" + i + "_" + j);
                    }
                }
            }
        }

        private void LoadFromDllDistortion(string filename) {
            using (var stream = new BinaryReader(File.OpenRead(filename))) {
                var bytes = stream.ReadBytes((int)new FileInfo(filename).Length);
                for (int i = 0; i < textBoxDistortion.Length; i++) {
                    textBoxDistortion[i].Text = SingleFromOffset(bytes, "Distortion" + i);
                }
            }
        }

        private void LoadFromDll(string filename) {
            LoadFromDllCA(filename);
            LoadFromDllDistortion(filename);
            using (var stream = new BinaryReader(File.OpenRead(filename))) {
                var bytes = stream.ReadBytes((int)new FileInfo(filename).Length);
                textBoxFadeout.Text = (1.0 / BitConverter.ToDouble(bytes, dll.GetOffset("FadeoutInverse"))).ToString("G");
                byte opcode = bytes[dll.GetOffset("FadeoutJump")];
                if (opcode == opcodeJnz) {
                    checkBoxEnableFuzzyBoundary.Checked = true;
                } else if (opcode == opcodeJmp) {
                    checkBoxEnableFuzzyBoundary.Checked = false;
                } else {
                    throw new Exception("Unexpected opcode for fuzzy boundary jump");
                }
            }
        }

        private void UpdateDirty(bool value) {
            buttonSave.Enabled = value;
        }

        private void setDirtyTrueEvent(object sender, EventArgs e) {
            UpdateDirty(true);
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            SaveToDll(this.filename);
            UpdateDirty(false);
        }
        private void WriteSingle(BinaryWriter writer, string name, float value) {
            writer.Seek(dll.GetOffset(name), SeekOrigin.Begin);
            writer.Write(value);
        }

        private void WriteDouble(BinaryWriter writer, string name, double value) {
            writer.Seek(dll.GetOffset(name), SeekOrigin.Begin);
            writer.Write(value);
        }

        private void WriteByte(BinaryWriter writer, string name, byte value) {
            writer.Seek(dll.GetOffset(name), SeekOrigin.Begin);
            writer.Write(value);
        }

        const byte opcodeJz = 0x74;
        const byte opcodeJnz = 0x75;
        const byte opcodeJp = 0x7A;
        const byte opcodeJnp = 0x7B;
        const byte opcodeJmp = 0xEB;

        private void SaveToDll(string filename) {
            using (var stream = new BinaryWriter(File.OpenWrite(filename))) {
                for (int i = minCARow; i < textBoxCA.GetLength(0); i++) {
                    for (int j = 0; j < textBoxCA.GetLength(1); j++) {
                        WriteSingle(stream, "CA" + i + "_" + j, float.Parse(textBoxCA[i, j].Text));
                    }
                }
                for (int i = 0; i < textBoxDistortion.Length; i++) {
                    WriteSingle(stream, "Distortion" + i, float.Parse(textBoxDistortion[i].Text));
                }
                double fadeout = double.Parse(textBoxFadeout.Text);
                WriteDouble(stream, "FadeoutInverse", 1.0 / fadeout);
                WriteDouble(stream, "FadeoutInverseDouble", 2.0 / fadeout);
                WriteByte(stream, "FadeoutJump", checkBoxEnableFuzzyBoundary.Checked ? opcodeJnz : opcodeJmp);
            }
            UpdateDirty(false);
        }

        private void buttonResetAll_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "Are you sure you want to reset all settings to Oculus's original values?", "Confirm Reset All", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) {
                LoadFromDll(dll.Filename);
                UpdateDirty(true);
            }
        }

        private void buttonDisableCA_Click(object sender, EventArgs e) {
            for (int i = minCARow; i < textBoxCA.GetLength(0); i++) {
                for (int j = 0; j < textBoxCA.GetLength(1); j++) {
                    textBoxCA[i, j].Text = "0";
                }
            }
        }

        private void buttonDisableDistortion_Click(object sender, EventArgs e) {
            for (int i = 0; i < textBoxDistortion.Length; i++) {
                textBoxDistortion[i].Text = "1";
            }
        }

        private void buttonResetCA_Click(object sender, EventArgs e) {
            LoadFromDllCA(dll.Filename);
        }

        private void buttonResetDistortion_Click(object sender, EventArgs e) {
            LoadFromDllDistortion(dll.Filename);
        }
    }
}
