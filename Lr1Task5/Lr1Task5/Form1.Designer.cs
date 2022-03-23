namespace Lr1Task5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultValue = new System.Windows.Forms.TextBox();
            this.widthValue = new System.Windows.Forms.TextBox();
            this.heightValue = new System.Windows.Forms.TextBox();
            this.widthError = new System.Windows.Forms.TextBox();
            this.heightError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Площадь:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(177, 199);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(100, 23);
            this.resultValue.TabIndex = 4;
            // 
            // widthValue
            // 
            this.widthValue.Location = new System.Drawing.Point(177, 78);
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(100, 23);
            this.widthValue.TabIndex = 5;
            // 
            // heightValue
            // 
            this.heightValue.Location = new System.Drawing.Point(177, 21);
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(100, 23);
            this.heightValue.TabIndex = 6;
            // 
            // widthError
            // 
            this.widthError.BackColor = System.Drawing.SystemColors.Control;
            this.widthError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthError.ForeColor = System.Drawing.Color.Red;
            this.widthError.Location = new System.Drawing.Point(12, 107);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(265, 16);
            this.widthError.TabIndex = 7;
            this.widthError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heightError
            // 
            this.heightError.BackColor = System.Drawing.SystemColors.Control;
            this.heightError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.heightError.ForeColor = System.Drawing.Color.Red;
            this.heightError.Location = new System.Drawing.Point(12, 49);
            this.heightError.Name = "heightError";
            this.heightError.Size = new System.Drawing.Size(265, 16);
            this.heightError.TabIndex = 8;
            this.heightError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 242);
            this.Controls.Add(this.heightError);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.widthValue);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Площадь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox resultValue;
        private TextBox widthValue;
        private TextBox heightValue;
        private TextBox widthError;
        private TextBox heightError;
    }
}