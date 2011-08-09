namespace PDFields
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnScanFile = new System.Windows.Forms.Button();
            this.grpAcrobatFields = new System.Windows.Forms.GroupBox();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.grpAcrobatFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(4, 13);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(64, 10);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(399, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(7, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnScanFile
            // 
            this.btnScanFile.Location = new System.Drawing.Point(88, 36);
            this.btnScanFile.Name = "btnScanFile";
            this.btnScanFile.Size = new System.Drawing.Size(75, 23);
            this.btnScanFile.TabIndex = 2;
            this.btnScanFile.Text = "Scan File";
            this.btnScanFile.UseVisualStyleBackColor = true;
            this.btnScanFile.Click += new System.EventHandler(this.btnScanFile_Click);
            // 
            // grpAcrobatFields
            // 
            this.grpAcrobatFields.Controls.Add(this.txtFields);
            this.grpAcrobatFields.Location = new System.Drawing.Point(7, 65);
            this.grpAcrobatFields.Name = "grpAcrobatFields";
            this.grpAcrobatFields.Size = new System.Drawing.Size(466, 309);
            this.grpAcrobatFields.TabIndex = 3;
            this.grpAcrobatFields.TabStop = false;
            this.grpAcrobatFields.Text = "Editable Fields";
            // 
            // txtFields
            // 
            this.txtFields.Location = new System.Drawing.Point(7, 20);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.Size = new System.Drawing.Size(453, 283);
            this.txtFields.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 377);
            this.Controls.Add(this.grpAcrobatFields);
            this.Controls.Add(this.btnScanFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFileName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDFields - Editable PDF Fields";
            this.grpAcrobatFields.ResumeLayout(false);
            this.grpAcrobatFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnScanFile;
        private System.Windows.Forms.GroupBox grpAcrobatFields;
        private System.Windows.Forms.TextBox txtFields;
    }
}

