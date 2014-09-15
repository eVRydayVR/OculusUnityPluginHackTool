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

        public FormMain() {
            InitializeComponent();
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
                    } else {
                        MessageBox.Show(this, "Could not identify version of OculusPlugin.dll file. May be modified from original or may be unsupported version.", "Unidentified Plug-in Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(this, "Error: Encountered unexpected error: " + ex.Message + "\n\nPlease report with screenshot to: eVRydayVR@gmail.com", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
            textBoxVersion.Text = this.dll.Version;
            LoadFromDll(this.filename);
            UpdateDirty(false);
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

        private void LoadFromDll(string filename) {
            using (var stream = new BinaryReader(File.OpenRead(filename))) {
                var bytes = stream.ReadBytes((int)new FileInfo(filename).Length);
                textBoxCA0.Text = SingleFromOffset(bytes, "CA0");
                textBoxCA1.Text = SingleFromOffset(bytes, "CA1");
                textBoxCA2.Text = SingleFromOffset(bytes, "CA2");
                textBoxCA3.Text = SingleFromOffset(bytes, "CA3");
            }
        }

        private void UpdateDirty(bool value) {
            buttonSave.Enabled = value;
        }

        private void textBoxCA0_TextChanged(object sender, EventArgs e) {
            UpdateDirty(true);
        }

        private void textBoxCA1_TextChanged(object sender, EventArgs e) {
            UpdateDirty(true);
        }

        private void textBoxCA2_TextChanged(object sender, EventArgs e) {
            UpdateDirty(true);
        }

        private void textBoxCA3_TextChanged(object sender, EventArgs e) {
            UpdateDirty(true);
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            SaveToDll(this.filename);
            UpdateDirty(false);
        }
        private void WriteSingle(BinaryWriter writer, string name, float value) {
            writer.Seek(dll.GetOffset(name), SeekOrigin.Begin);
            writer.Write(BitConverter.GetBytes(value));
        }

        private void SaveToDll(string filename) {
            using (var stream = new BinaryWriter(File.OpenWrite(filename))) {
                WriteSingle(stream, "CA0", float.Parse(textBoxCA0.Text));
                WriteSingle(stream, "CA1", float.Parse(textBoxCA1.Text));
                WriteSingle(stream, "CA2", float.Parse(textBoxCA2.Text));
                WriteSingle(stream, "CA3", float.Parse(textBoxCA3.Text));
            }
            UpdateDirty(false);
        }

        private void buttonResetAll_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "Are you sure you want to reset all settings to Oculus's original values?", "Confirm Reset All", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) {
                LoadFromDll(dll.Filename);
                UpdateDirty(true);
            }
        }
    }
}
