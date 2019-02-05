namespace CSharpTemplateGenerator
{
    partial class MainFileForm
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
            this.radioButtonClass = new System.Windows.Forms.RadioButton();
            this.radioButtonInterface = new System.Windows.Forms.RadioButton();
            this.radioButtonEnum = new System.Windows.Forms.RadioButton();
            this.radioButtonStruct = new System.Windows.Forms.RadioButton();
            this.radioButtonEmptyFile = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.AutoSize = true;
            this.radioButtonClass.Location = new System.Drawing.Point(12, 42);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(50, 17);
            this.radioButtonClass.TabIndex = 0;
            this.radioButtonClass.TabStop = true;
            this.radioButtonClass.Text = "Class";
            this.radioButtonClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonInterface
            // 
            this.radioButtonInterface.AutoSize = true;
            this.radioButtonInterface.Location = new System.Drawing.Point(12, 66);
            this.radioButtonInterface.Name = "radioButtonInterface";
            this.radioButtonInterface.Size = new System.Drawing.Size(67, 17);
            this.radioButtonInterface.TabIndex = 1;
            this.radioButtonInterface.TabStop = true;
            this.radioButtonInterface.Text = "Interface";
            this.radioButtonInterface.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnum
            // 
            this.radioButtonEnum.AutoSize = true;
            this.radioButtonEnum.Location = new System.Drawing.Point(12, 90);
            this.radioButtonEnum.Name = "radioButtonEnum";
            this.radioButtonEnum.Size = new System.Drawing.Size(52, 17);
            this.radioButtonEnum.TabIndex = 2;
            this.radioButtonEnum.TabStop = true;
            this.radioButtonEnum.Text = "Enum";
            this.radioButtonEnum.UseVisualStyleBackColor = true;
            // 
            // radioButtonStruct
            // 
            this.radioButtonStruct.AutoSize = true;
            this.radioButtonStruct.Location = new System.Drawing.Point(12, 114);
            this.radioButtonStruct.Name = "radioButtonStruct";
            this.radioButtonStruct.Size = new System.Drawing.Size(53, 17);
            this.radioButtonStruct.TabIndex = 3;
            this.radioButtonStruct.TabStop = true;
            this.radioButtonStruct.Text = "Struct";
            this.radioButtonStruct.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmptyFile
            // 
            this.radioButtonEmptyFile.AutoSize = true;
            this.radioButtonEmptyFile.Location = new System.Drawing.Point(12, 138);
            this.radioButtonEmptyFile.Name = "radioButtonEmptyFile";
            this.radioButtonEmptyFile.Size = new System.Drawing.Size(73, 17);
            this.radioButtonEmptyFile.TabIndex = 4;
            this.radioButtonEmptyFile.TabStop = true;
            this.radioButtonEmptyFile.Text = "Empty File";
            this.radioButtonEmptyFile.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(99, 163);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please choose a template:";
            // 
            // MainFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radioButtonEmptyFile);
            this.Controls.Add(this.radioButtonStruct);
            this.Controls.Add(this.radioButtonEnum);
            this.Controls.Add(this.radioButtonInterface);
            this.Controls.Add(this.radioButtonClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainFileForm";
            this.Text = "Empty File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonClass;
        private System.Windows.Forms.RadioButton radioButtonInterface;
        private System.Windows.Forms.RadioButton radioButtonEnum;
        private System.Windows.Forms.RadioButton radioButtonStruct;
        private System.Windows.Forms.RadioButton radioButtonEmptyFile;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
    }
}