namespace CSharpTemplateGenerator
{
    partial class ClassConfig
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.listViewVariables = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewMethods = new System.Windows.Forms.ListView();
            this.btnVariablesAdd = new System.Windows.Forms.Button();
            this.btnVariablesMinus = new System.Windows.Forms.Button();
            this.btnMethodsAdd = new System.Windows.Forms.Button();
            this.btnMethodsMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(202, 224);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // listViewVariables
            // 
            this.listViewVariables.Location = new System.Drawing.Point(12, 68);
            this.listViewVariables.Name = "listViewVariables";
            this.listViewVariables.Size = new System.Drawing.Size(121, 97);
            this.listViewVariables.TabIndex = 6;
            this.listViewVariables.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class Name:";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(85, 10);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(192, 20);
            this.textBoxClassName.TabIndex = 8;
            this.textBoxClassName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Variables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Methods";
            // 
            // listViewMethods
            // 
            this.listViewMethods.Location = new System.Drawing.Point(156, 68);
            this.listViewMethods.Name = "listViewMethods";
            this.listViewMethods.Size = new System.Drawing.Size(121, 97);
            this.listViewMethods.TabIndex = 11;
            this.listViewMethods.UseCompatibleStateImageBehavior = false;
            this.listViewMethods.SelectedIndexChanged += new System.EventHandler(this.listViewMethods_SelectedIndexChanged);
            // 
            // btnVariablesAdd
            // 
            this.btnVariablesAdd.Location = new System.Drawing.Point(12, 182);
            this.btnVariablesAdd.Name = "btnVariablesAdd";
            this.btnVariablesAdd.Size = new System.Drawing.Size(26, 23);
            this.btnVariablesAdd.TabIndex = 13;
            this.btnVariablesAdd.Text = "+";
            this.btnVariablesAdd.UseVisualStyleBackColor = true;
            this.btnVariablesAdd.Click += new System.EventHandler(this.btnVariablesAdd_Click);
            // 
            // btnVariablesMinus
            // 
            this.btnVariablesMinus.Location = new System.Drawing.Point(44, 182);
            this.btnVariablesMinus.Name = "btnVariablesMinus";
            this.btnVariablesMinus.Size = new System.Drawing.Size(31, 23);
            this.btnVariablesMinus.TabIndex = 14;
            this.btnVariablesMinus.Text = "-";
            this.btnVariablesMinus.UseVisualStyleBackColor = true;
            this.btnVariablesMinus.Click += new System.EventHandler(this.btnVariablesMinus_Click);
            // 
            // btnMethodsAdd
            // 
            this.btnMethodsAdd.Location = new System.Drawing.Point(156, 182);
            this.btnMethodsAdd.Name = "btnMethodsAdd";
            this.btnMethodsAdd.Size = new System.Drawing.Size(26, 23);
            this.btnMethodsAdd.TabIndex = 15;
            this.btnMethodsAdd.Text = "+";
            this.btnMethodsAdd.UseVisualStyleBackColor = true;
            this.btnMethodsAdd.Click += new System.EventHandler(this.btnMethodsAdd_Click);
            // 
            // btnMethodsMinus
            // 
            this.btnMethodsMinus.Location = new System.Drawing.Point(188, 182);
            this.btnMethodsMinus.Name = "btnMethodsMinus";
            this.btnMethodsMinus.Size = new System.Drawing.Size(26, 23);
            this.btnMethodsMinus.TabIndex = 16;
            this.btnMethodsMinus.Text = "-";
            this.btnMethodsMinus.UseVisualStyleBackColor = true;
            this.btnMethodsMinus.Click += new System.EventHandler(this.btnMethodsMinus_Click);
            // 
            // ClassConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 256);
            this.Controls.Add(this.btnMethodsMinus);
            this.Controls.Add(this.btnMethodsAdd);
            this.Controls.Add(this.btnVariablesMinus);
            this.Controls.Add(this.btnVariablesAdd);
            this.Controls.Add(this.listViewMethods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewVariables);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClassConfig";
            this.Text = "Class Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListView listViewVariables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewMethods;
        private System.Windows.Forms.Button btnVariablesAdd;
        private System.Windows.Forms.Button btnVariablesMinus;
        private System.Windows.Forms.Button btnMethodsAdd;
        private System.Windows.Forms.Button btnMethodsMinus;
    }
}