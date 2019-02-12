using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpTemplateGenerator
{
    public partial class VariablesForm : Form
    {
        public VariablesForm()
        {
            InitializeComponent();
        }

        public VariableModel variable = new VariableModel();

        private void btnNext_Click_1(object sender, EventArgs e)
        {            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxAccessModifier.SelectedValue as string == "Public")
            {
                variable._AccessModifier = AccessModifier.Public;
            }
            else if (comboBoxAccessModifier.SelectedValue as string == "Private")
            {
                variable._AccessModifier = AccessModifier.Private;
            }
            else if (comboBoxAccessModifier.SelectedValue as string == "Protected")
            {
                variable._AccessModifier = AccessModifier.Protected;
            }
            else if (comboBoxAccessModifier.SelectedValue as string == "Internal")
            {
                variable._AccessModifier = AccessModifier.Internal;
            }
            else if (comboBoxAccessModifier.SelectedValue as string == "PrivateProtected")
            {
                variable._AccessModifier = AccessModifier.PrivateProtected;
            }
            else
            {
                variable._AccessModifier = AccessModifier.ProtectedInternal;
            }

            if (textBoxType.Text != "" && !textBoxType.Text.Contains(" "))
            {
                variable.Type = textBoxType.Text;
            }
            else
            {
                MessageBox.Show("Check type...");
            }

            if (textBoxVariableName.Text != "" && !textBoxVariableName.Text.Contains(" "))
            {
                variable.VariableName = textBoxVariableName.Text;
            }
            else
            {
                MessageBox.Show("check variable name...");
            }
            this.Close();
        }
    }
}
