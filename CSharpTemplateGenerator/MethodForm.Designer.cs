namespace CSharpTemplateGenerator
{
    partial class MethodForm
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
            this.comboBoxAccessModifier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxReturnType = new System.Windows.Forms.TextBox();
            this.textBoxMethodName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxAccessModifier
            // 
            this.comboBoxAccessModifier.AutoCompleteCustomSource.AddRange(new string[] {
            "Public",
            "Private",
            "Protected",
            "Internal",
            "PrivateProtected",
            "ProtectedInternal"});
            this.comboBoxAccessModifier.FormattingEnabled = true;
            this.comboBoxAccessModifier.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Protected",
            "Internal",
            "PrivateProtected",
            "ProtectedInternal"});
            this.comboBoxAccessModifier.Location = new System.Drawing.Point(117, 16);
            this.comboBoxAccessModifier.Name = "comboBoxAccessModifier";
            this.comboBoxAccessModifier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAccessModifier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access Modifier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Method Name";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(163, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxReturnType
            // 
            this.textBoxReturnType.Location = new System.Drawing.Point(117, 65);
            this.textBoxReturnType.Name = "textBoxReturnType";
            this.textBoxReturnType.Size = new System.Drawing.Size(121, 20);
            this.textBoxReturnType.TabIndex = 5;
            // 
            // textBoxMethodName
            // 
            this.textBoxMethodName.Location = new System.Drawing.Point(117, 112);
            this.textBoxMethodName.Name = "textBoxMethodName";
            this.textBoxMethodName.Size = new System.Drawing.Size(121, 20);
            this.textBoxMethodName.TabIndex = 6;
            // 
            // MethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 185);
            this.Controls.Add(this.textBoxMethodName);
            this.Controls.Add(this.textBoxReturnType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAccessModifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MethodForm";
            this.Text = "Add Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAccessModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxReturnType;
        private System.Windows.Forms.TextBox textBoxMethodName;
    }
}