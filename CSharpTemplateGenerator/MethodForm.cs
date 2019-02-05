using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpTemplateGenerator
{
    public partial class MethodForm : Form
    {
        public MethodForm()
        {
            InitializeComponent();
        }

        public MethodModel method = new MethodModel();

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
                method._AccessModifier = AccessModifier.Public;
            } else if (comboBoxAccessModifier.SelectedValue as string == "Private")
            {
                method._AccessModifier = AccessModifier.Private;
            } else if (comboBoxAccessModifier.SelectedValue as string == "Protected")
            {
                method._AccessModifier = AccessModifier.Protected;
            } else if (comboBoxAccessModifier.SelectedValue as string == "Internal")
            {
                method._AccessModifier = AccessModifier.Internal;
            } else if (comboBoxAccessModifier.SelectedValue as string == "PrivateProtected")
            {
                method._AccessModifier = AccessModifier.PrivateProtected;
            } else
            {
                method._AccessModifier = AccessModifier.ProtectedInternal;
            }

            if (textBoxReturnType.Text != "" && !textBoxReturnType.Text.Contains(" "))
            {
                method.ReturnType = textBoxReturnType.Text;
            } else
            {
                // Show a messagebox...
                MessageBox.Show("Check return type...");
            }

            if (textBoxMethodName.Text != "" && !textBoxMethodName.Text.Contains(" "))
            {
                method.ReturnType = textBoxMethodName.Text;
            }
            else
            {
                // Show a messagebox...
                MessageBox.Show("check method name...");
            }
            this.Close();
        }
    }
}
