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
            this.groupBoxChromaticAbberationCorrection = new System.Windows.Forms.GroupBox();
            this.textBoxCA3 = new System.Windows.Forms.TextBox();
            this.textBoxCA2 = new System.Windows.Forms.TextBox();
            this.textBoxCA1 = new System.Windows.Forms.TextBox();
            this.textBoxCA0 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRendering.SuspendLayout();
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
            this.tabPageRendering.Controls.Add(this.groupBoxChromaticAbberationCorrection);
            this.tabPageRendering.Location = new System.Drawing.Point(4, 40);
            this.tabPageRendering.Name = "tabPageRendering";
            this.tabPageRendering.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRendering.Size = new System.Drawing.Size(1298, 615);
            this.tabPageRendering.TabIndex = 0;
            this.tabPageRendering.Text = "Rendering";
            this.tabPageRendering.UseVisualStyleBackColor = true;
            // 
            // groupBoxChromaticAbberationCorrection
            // 
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA3);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA2);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA1);
            this.groupBoxChromaticAbberationCorrection.Controls.Add(this.textBoxCA0);
            this.groupBoxChromaticAbberationCorrection.Location = new System.Drawing.Point(7, 7);
            this.groupBoxChromaticAbberationCorrection.Name = "groupBoxChromaticAbberationCorrection";
            this.groupBoxChromaticAbberationCorrection.Size = new System.Drawing.Size(508, 211);
            this.groupBoxChromaticAbberationCorrection.TabIndex = 0;
            this.groupBoxChromaticAbberationCorrection.TabStop = false;
            this.groupBoxChromaticAbberationCorrection.Text = "Chromatic abberation correction";
            // 
            // textBoxCA3
            // 
            this.textBoxCA3.Location = new System.Drawing.Point(382, 38);
            this.textBoxCA3.Name = "textBoxCA3";
            this.textBoxCA3.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA3.TabIndex = 3;
            this.textBoxCA3.TextChanged += new System.EventHandler(this.textBoxCA3_TextChanged);
            // 
            // textBoxCA2
            // 
            this.textBoxCA2.Location = new System.Drawing.Point(257, 38);
            this.textBoxCA2.Name = "textBoxCA2";
            this.textBoxCA2.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA2.TabIndex = 2;
            this.textBoxCA2.TextChanged += new System.EventHandler(this.textBoxCA2_TextChanged);
            // 
            // textBoxCA1
            // 
            this.textBoxCA1.Location = new System.Drawing.Point(133, 38);
            this.textBoxCA1.Name = "textBoxCA1";
            this.textBoxCA1.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA1.TabIndex = 1;
            this.textBoxCA1.TextChanged += new System.EventHandler(this.textBoxCA1_TextChanged);
            // 
            // textBoxCA0
            // 
            this.textBoxCA0.Location = new System.Drawing.Point(7, 38);
            this.textBoxCA0.Name = "textBoxCA0";
            this.textBoxCA0.Size = new System.Drawing.Size(100, 38);
            this.textBoxCA0.TabIndex = 0;
            this.textBoxCA0.TextChanged += new System.EventHandler(this.textBoxCA0_TextChanged);
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
        private System.Windows.Forms.TextBox textBoxCA3;
        private System.Windows.Forms.TextBox textBoxCA2;
        private System.Windows.Forms.TextBox textBoxCA1;
        private System.Windows.Forms.TextBox textBoxCA0;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonResetAll;
    }
}

