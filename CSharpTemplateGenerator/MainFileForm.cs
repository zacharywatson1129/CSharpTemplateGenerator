using System;
using System.Windows.Forms;

namespace CSharpTemplateGenerator
{
    public partial class MainFileForm : Form
    {
        public MainFileForm()
        {
            InitializeComponent();
            radioButtonClass.Checked = true;
        }

        public CSharpFileType TemplateToGenerate { get; set; } = CSharpFileType.Class;


        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (radioButtonClass.Checked == true)
            {
                TemplateToGenerate = CSharpFileType.Class;
            }
            else if (radioButtonInterface.Checked == true)
            {
                TemplateToGenerate = CSharpFileType.Interface;
            }
            else if (radioButtonEnum.Checked == true)
            {
                TemplateToGenerate = CSharpFileType.Enum;
            }
            else if (radioButtonStruct.Checked == true)
            {
                TemplateToGenerate = CSharpFileType.Struct;
            }
            else
            {
                TemplateToGenerate = CSharpFileType.EmptyFile;
            }
            this.Close();
            
        }
    }
}
