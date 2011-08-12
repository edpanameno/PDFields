using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text.pdf;

namespace PDFields
{
    public partial class Form1 : Form
    {
        protected OpenFileDialog openFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "PDF Files|*.pdf";
            openFile.Title = "Select PDF File to Scan";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = openFile.FileName;
            }
        }

        private void btnScanFile_Click(object sender, EventArgs e)
        {
            var reader = new PdfReader(this.txtFilePath.Text);
            var acroFields = reader.AcroFields;

            if (acroFields.Fields.Count == 0)
            {
                MessageBox.Show(openFile.FileName + " has no Editable Fields");
                return;
            }

            foreach (var field in acroFields.Fields)
            {
                this.txtFields.Text += field.Key + Environment.NewLine;
            }

            reader.Close();
        }
    }
}
