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

namespace CSharpTemplateGenerator
{
    public partial class EmptyFileForm : Form
    {
        public EmptyFileForm()
        {
            InitializeComponent();
        }

        public string FileName { get; set; }


        private void btnNext_Click(object sender, EventArgs e)
        {          
            if (textBoxFileName.Text == "")
            {
                btnCreate.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Please provide a file name.", "Blank Field");
            } else if (textBoxFileName.Text.Contains(" "))
            {
                DialogResult result = MessageBox.Show("This file name contains a space. Are you sure you want to create the file?", "File Name", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.FileName = textBoxFileName.Text;
                    Close();
                } else
                {
                    btnCreate.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                this.FileName = textBoxFileName.Text;
                Close();
            }
        }
    }
}
