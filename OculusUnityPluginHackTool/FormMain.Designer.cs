namespace OculusUnityPluginHackTool {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRendering = new System.Windows.Forms.TabPage();
            this.groupBoxFuzzyBoundary = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableFuzzyBoundary = new System.Windows.Forms.CheckBox();
            this.textBoxFadeout = new System.Windows.Forms.TextBox();
            this.labelFadeout = new System.Windows.Forms.Label();
            this.groupBoxDistortion = new System.Windows.Forms.GroupBox();
            this.textBoxDistortion9 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion7 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion5 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion3 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion1 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion10 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion8 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion6 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion4 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion2 = new System.Windows.Forms.TextBox();
            this.textBoxDistortion0 = new System.Windows.Forms.TextBox();
            this.groupBoxChromaticAbberationCorrection = new System.Windows.Forms.GroupBox();
            this.buttonDisableCA = new System.Windows.Forms.Button();
            this.textBoxCA0_3 = new System.Windows.Forms.TextBox();
            this.textBoxCA0_2 = new System.Windows.Forms.TextBox();
            this.textBoxCA0_1 = new System.Windows.Forms.TextBox();
            this.textBoxCA0_0 = new System.Windows.Forms.TextBox();
            this.textBoxCA1_3 = new System.Windows.Forms.TextBox();
            this.textBoxCA1_2 = new System.Windows.Forms.TextBox();
            this.textBoxCA1_1 = new System.Windows.Forms.TextBox();
            this.textBoxCA1_0 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.buttonDisableDistortion = new System.Windows.Forms.Button();
            this.buttonResetCA = new System.Windows.Forms.Button();
            this.buttonResetDistortion = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRendering.SuspendLayout();
            this.groupBoxFuzzyBoundary.SuspendLayout();
            this.groupBoxDistortion.SuspendLayout();
            this.groupBoxChromaticAbberationCorrection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version:";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(140, 13);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(378, 38);
            this.textBoxVersion.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRendering);
            this.tabControl1.Location = new System.Drawing.Point(19, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1306, 659);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageRendering
            // 
            this.tabPageRendering.Controls.Add(this.groupBoxFuzzyBoundary);
            this.tabPageRendering.Controls.Add(this.groupBoxDistortion);
            this.tabPageRendering.Controls.Add(this.groupBoxChromaticAbberationCorrection);
            this.tabPageRendering.Location = new System.Drawing.Point(4, 40);
            this.tabPageRendering.Name = "tabPageRendering";
            this.tabPageRendering.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRendering.Size = new System.Drawing.Size(1298, 615);
            this.tabPageRendering.TabIndex = 0;
            this.tabPageRendering.Text = "Rendering";
            this.tabPageRendering.UseVisualStyleBackColor = true;
            // 
            // groupBoxFuzzyBoundary
            // 
            this.groupBoxFuzzyBoundary.Controls.Add(this.checkBoxEnableFuzzyBoundary);
            this.groupBoxFuzzyBoundary.Controls.Add(this.textBoxFadeout);
            this.groupBoxFuzzyBoundary.Controls.Add(this.labelFadeout);
            this.groupBoxFuzzyBoundary.Location = new System.Drawing.Point(530, 7);
            this.groupBoxFuzzyBoundary.Name = "groupBoxFuzzyBoundary";
            this.groupBoxFuzzyBoundary.Size = new System.Drawing.Size(362, 152);
            this.groupBoxFuzzyBoundary.TabIndex = 4;
            this.groupBoxFuzzyBoundary.TabStop = false;
            this.groupBoxFuzzyBoundary.Text = "Fuzzy boundary";
            // 
            // checkBoxEnableFuzzyBoundary
            // 
            this.checkBoxEnableFuzzyBoundary.AutoSize = true;
            this.checkBoxEnableFuzzyBoundary.Location = new System.Drawing.Point(19, 38);
            this.checkBoxEnableFuzzyBoundary.Name = "checkBoxEnableFuzzyBoundary";
            this.checkBoxEnableFuzzyBoundary.Size = new System.Drawing.Size(159, 36);
            this.checkBoxEnableFuzzyBoundary.TabIndex = 7;
            this.checkBoxEnableFuzzyBoundary.Text = "Enabled";
            this.checkBoxEnableFuzzyBoundary.UseVisualStyleBackColor = true;
            this.checkBoxEnableFuzzyBoundary.CheckedChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxFadeout
            // 
            this.textBoxFadeout.Location = new System.Drawing.Point(210, 95);
            this.textBoxFadeout.Name = "textBoxFadeout";
            this.textBoxFadeout.Size = new System.Drawing.Size(125, 38);
            this.textBoxFadeout.TabIndex = 5;
            this.textBoxFadeout.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // labelFadeout
            // 
            this.labelFadeout.AutoSize = true;
            this.labelFadeout.Location = new System.Drawing.Point(13, 96);
            this.labelFadeout.Name = "labelFadeout";
            this.labelFadeout.Size = new System.Drawing.Size(151, 32);
            this.labelFadeout.TabIndex = 6;
            this.labelFadeout.Text = "Fuzziness:";
            // 
            // groupBoxDistortion
            // 
            this.groupBoxDistortion.Controls.Add(this.buttonResetDistortion);
            this.groupBoxDistortion.Controls.Add(this.buttonDisableDistortion);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion9);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion7);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion5);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion3);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion1);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion10);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion8);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion6);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion4);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion2);
            this.groupBoxDistortion.Controls.Add(this.textBoxDistortion0);
            this.groupBoxDistortion.Location = new System.Drawing.Point(7, 288);
            this.groupBoxDistortion.Name = "groupBoxDistortion";
            this.groupBoxDistortion.Size = new System.Drawing.Size(508, 267);
            this.groupBoxDistortion.TabIndex = 4;
            this.groupBoxDistortion.TabStop = false;
            this.groupBoxDistortion.Text = "Distortion";
            // 
            // textBoxDistortion9
            // 
            this.textBoxDistortion9.Location = new System.Drawing.Point(132, 144);
            this.textBoxDistortion9.Name = "textBoxDistortion9";
            this.textBoxDistortion9.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion9.TabIndex = 10;
            this.textBoxDistortion9.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion7
            // 
            this.textBoxDistortion7.Location = new System.Drawing.Point(381, 91);
            this.textBoxDistortion7.Name = "textBoxDistortion7";
            this.textBoxDistortion7.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion7.TabIndex = 9;
            this.textBoxDistortion7.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion5
            // 
            this.textBoxDistortion5.Location = new System.Drawing.Point(132, 91);
            this.textBoxDistortion5.Name = "textBoxDistortion5";
            this.textBoxDistortion5.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion5.TabIndex = 8;
            this.textBoxDistortion5.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion3
            // 
            this.textBoxDistortion3.Location = new System.Drawing.Point(381, 38);
            this.textBoxDistortion3.Name = "textBoxDistortion3";
            this.textBoxDistortion3.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion3.TabIndex = 7;
            this.textBoxDistortion3.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion1
            // 
            this.textBoxDistortion1.Location = new System.Drawing.Point(132, 38);
            this.textBoxDistortion1.Name = "textBoxDistortion1";
            this.textBoxDistortion1.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion1.TabIndex = 6;
            this.textBoxDistortion1.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion10
            // 
            this.textBoxDistortion10.Location = new System.Drawing.Point(256, 144);
            this.textBoxDistortion10.Name = "textBoxDistortion10";
            this.textBoxDistortion10.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion10.TabIndex = 5;
            this.textBoxDistortion10.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion8
            // 
            this.textBoxDistortion8.Location = new System.Drawing.Point(7, 144);
            this.textBoxDistortion8.Name = "textBoxDistortion8";
            this.textBoxDistortion8.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion8.TabIndex = 4;
            this.textBoxDistortion8.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion6
            // 
            this.textBoxDistortion6.Location = new System.Drawing.Point(256, 91);
            this.textBoxDistortion6.Name = "textBoxDistortion6";
            this.textBoxDistortion6.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion6.TabIndex = 3;
            this.textBoxDistortion6.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion4
            // 
            this.textBoxDistortion4.Location = new System.Drawing.Point(7, 91);
            this.textBoxDistortion4.Name = "textBoxDistortion4";
            this.textBoxDistortion4.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion4.TabIndex = 2;
            this.textBoxDistortion4.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion2
            // 
            this.textBoxDistortion2.Location = new System.Drawing.Point(256, 37);
            this.textBoxDistortion2.Name = "textBoxDistortion2";
            this.textBoxDistortion2.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion2.TabIndex = 1;
            this.textBoxDistortion2.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxDistortion0
            // 
            this.textBoxDistortion0.Location = new System.Drawing.Point(7, 38);
            this.textBoxDistortion0.Name = "textBoxDistortion0";
            this.textBoxDistortion0.Size = new System.Drawing.Size(100, 38);
            this.textBoxDistortion0.TabIndex = 0;
            this.textBoxDistortion0.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // groupBoxChromaticAbberationCorrection
            // 
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.buttonResetCA);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.buttonDisableCA);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA0_3);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA0_2);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA0_1);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA0_0);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA1_3);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA1_2);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA1_1);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA1_0);
            this.groupBoxChromaticAbberationCorrection.Location = new System.Drawing.Point(7, 7);
            this.groupBoxChromaticAbberationCorrection.Name = "groupBoxChromaticAbberationCorrection";
            this.groupBoxChromaticAbberationCorrection.Size = new System.Drawing.Size(508, 266);
            this.groupBoxChromaticAbberationCorrection.TabIndex = 0;
            this.groupBoxChromaticAbberationCorrection.TabStop = false;
            this.groupBoxChromaticAbberationCorrection.Text = "Chromatic abberation correction";
            // 
            // buttonDisableCA
            // 
            this.buttonDisableCA.Location = new System.Drawing.Point(7, 204);
            this.buttonDisableCA.Name = "buttonDisableCA";
            this.buttonDisableCA.Size = new System.Drawing.Size(162, 49);
            this.buttonDisableCA.TabIndex = 8;
            this.buttonDisableCA.Text = "Disable";
            this.buttonDisableCA.UseVisualStyleBackColor = true;
            this.buttonDisableCA.Click += new System.EventHandler(this.buttonDisableCA_Click);
            // 
            // textBoxCA0_3
            // 
            this.textBoxCA0_3.Location = new System.Drawing.Point(381, 36);
            this.textBoxCA0_3.Name = "textBoxCA0_3";
            this.textBoxCA0_3.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA0_3.TabIndex = 7;
            // 
            // textBoxCA0_2
            // 
            this.textBoxCA0_2.Location = new System.Drawing.Point(256, 36);
            this.textBoxCA0_2.Name = "textBoxCA0_2";
            this.textBoxCA0_2.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA0_2.TabIndex = 6;
            // 
            // textBoxCA0_1
            // 
            this.textBoxCA0_1.Location = new System.Drawing.Point(132, 36);
            this.textBoxCA0_1.Name = "textBoxCA0_1";
            this.textBoxCA0_1.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA0_1.TabIndex = 5;
            // 
            // textBoxCA0_0
            // 
            this.textBoxCA0_0.Location = new System.Drawing.Point(6, 36);
            this.textBoxCA0_0.Name = "textBoxCA0_0";
            this.textBoxCA0_0.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA0_0.TabIndex = 4;
            // 
            // textBoxCA1_3
            // 
            this.textBoxCA1_3.Location = new System.Drawing.Point(381, 90);
            this.textBoxCA1_3.Name = "textBoxCA1_3";
            this.textBoxCA1_3.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA1_3.TabIndex = 3;
            this.textBoxCA1_3.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxCA1_2
            // 
            this.textBoxCA1_2.Location = new System.Drawing.Point(256, 90);
            this.textBoxCA1_2.Name = "textBoxCA1_2";
            this.textBoxCA1_2.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA1_2.TabIndex = 2;
            this.textBoxCA1_2.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxCA1_1
            // 
            this.textBoxCA1_1.Location = new System.Drawing.Point(132, 90);
            this.textBoxCA1_1.Name = "textBoxCA1_1";
            this.textBoxCA1_1.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA1_1.TabIndex = 1;
            this.textBoxCA1_1.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // textBoxCA1_0
            // 
            this.textBoxCA1_0.Location = new System.Drawing.Point(6, 90);
            this.textBoxCA1_0.Name = "textBoxCA1_0";
            this.textBoxCA1_0.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA1_0.TabIndex = 0;
            this.textBoxCA1_0.TextChanged += new System.EventHandler(this.setDirtyTrueEvent);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 751);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(162, 49);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Location = new System.Drawing.Point(204, 751);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(183, 49);
            this.buttonResetAll.TabIndex = 4;
            this.buttonResetAll.Text = "Reset &all";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // buttonDisableDistortion
            // 
            this.buttonDisableDistortion.Location = new System.Drawing.Point(7, 200);
            this.buttonDisableDistortion.Name = "buttonDisableDistortion";
            this.buttonDisableDistortion.Size = new System.Drawing.Size(162, 49);
            this.buttonDisableDistortion.TabIndex = 9;
            this.buttonDisableDistortion.Text = "Disable";
            this.buttonDisableDistortion.UseVisualStyleBackColor = true;
            this.buttonDisableDistortion.Click += new System.EventHandler(this.buttonDisableDistortion_Click);
            // 
            // buttonResetCA
            // 
            this.buttonResetCA.Location = new System.Drawing.Point(185, 204);
            this.buttonResetCA.Name = "buttonResetCA";
            this.buttonResetCA.Size = new System.Drawing.Size(162, 49);
            this.buttonResetCA.TabIndex = 9;
            this.buttonResetCA.Text = "Reset";
            this.buttonResetCA.UseVisualStyleBackColor = true;
            this.buttonResetCA.Click += new System.EventHandler(this.buttonResetCA_Click);
            // 
            // buttonResetDistortion
            // 
            this.buttonResetDistortion.Location = new System.Drawing.Point(185, 200);
            this.buttonResetDistortion.Name = "buttonResetDistortion";
            this.buttonResetDistortion.Size = new System.Drawing.Size(162, 49);
            this.buttonResetDistortion.TabIndex = 10;
            this.buttonResetDistortion.Text = "Reset";
            this.buttonResetDistortion.UseVisualStyleBackColor = true;
            this.buttonResetDistortion.Click += new System.EventHandler(this.buttonResetDistortion_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 809);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Oculus Unity Plugin Hack Tool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRendering.ResumeLayout(false);
            this.groupBoxFuzzyBoundary.ResumeLayout(false);
            this.groupBoxFuzzyBoundary.PerformLayout();
            this.groupBoxDistortion.ResumeLayout(false);
            this.groupBoxDistortion.PerformLayout();
            this.groupBoxChromaticAbberationCorrection.ResumeLayout(false);
            this.groupBoxChromaticAbberationCorrection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRendering;
        private System.Windows.Forms.GroupBox groupBoxChromaticAbberationCorrection;
        private System.Windows.Forms.TextBox textBoxCA1_3;
        private System.Windows.Forms.TextBox textBoxCA1_2;
        private System.Windows.Forms.TextBox textBoxCA1_1;
        private System.Windows.Forms.TextBox textBoxCA1_0;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.GroupBox groupBoxDistortion;
        private System.Windows.Forms.TextBox textBoxDistortion9;
        private System.Windows.Forms.TextBox textBoxDistortion7;
        private System.Windows.Forms.TextBox textBoxDistortion5;
        private System.Windows.Forms.TextBox textBoxDistortion3;
        private System.Windows.Forms.TextBox textBoxDistortion1;
        private System.Windows.Forms.TextBox textBoxDistortion10;
        private System.Windows.Forms.TextBox textBoxDistortion8;
        private System.Windows.Forms.TextBox textBoxDistortion6;
        private System.Windows.Forms.TextBox textBoxDistortion4;
        private System.Windows.Forms.TextBox textBoxDistortion2;
        private System.Windows.Forms.TextBox textBoxDistortion0;
        private System.Windows.Forms.Label labelFadeout;
        private System.Windows.Forms.TextBox textBoxFadeout;
        private System.Windows.Forms.GroupBox groupBoxFuzzyBoundary;
        private System.Windows.Forms.CheckBox checkBoxEnableFuzzyBoundary;
        private System.Windows.Forms.TextBox textBoxCA0_3;
        private System.Windows.Forms.TextBox textBoxCA0_2;
        private System.Windows.Forms.TextBox textBoxCA0_1;
        private System.Windows.Forms.TextBox textBoxCA0_0;
        private System.Windows.Forms.Button buttonDisableCA;
        private System.Windows.Forms.Button buttonDisableDistortion;
        private System.Windows.Forms.Button buttonResetDistortion;
        private System.Windows.Forms.Button buttonResetCA;
    }
}

