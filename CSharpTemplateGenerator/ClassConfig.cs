using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpTemplateGenerator
{
    public partial class ClassConfig : Form
    {
        public ClassConfig()
        {
            InitializeComponent();
            Variables = new List<VariableModel>();
            Methods = new List<MethodModel>();
        }

        public ClassModel ClassModel;
        public List<VariableModel> Variables;
        public List<MethodModel> Methods;



        private void btnNext_Click_1(object sender, EventArgs e)
        {
            ClassModel = new ClassModel(textBoxClassName.Text, Variables, Methods);
            this.Close();
        }

        private void btnVariablesAdd_Click(object sender, EventArgs e)
        {
            VariablesForm form = new VariablesForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Variables.Add(form.variable);
                listViewVariables.Items.Add(form.variable.ToString());
            }
        }

        private void btnVariablesMinus_Click(object sender, EventArgs e)
        {
            int count = listViewVariables.SelectedItems.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    listViewVariables.SelectedItems[i].Remove();
                    Variables.RemoveAt(i);
                }
            }
        }

        private void btnMethodsAdd_Click(object sender, EventArgs e)
        {
            MethodForm form = new MethodForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Methods.Add(form.method);
                listViewMethods.Items.Add(form.method.ToString());
            }
        }

        private void btnMethodsMinus_Click(object sender, EventArgs e)
        {
            int count = listViewMethods.SelectedItems.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    listViewMethods.SelectedItems[i].Remove();
                }               
            }            
        }



        private void listViewMethods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
