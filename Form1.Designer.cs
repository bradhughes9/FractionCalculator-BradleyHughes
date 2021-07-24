namespace FractionCalculator_BradleyHughes
{
    partial class Form1
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
            this.EqualButton = new System.Windows.Forms.Button();
            this.TextDenominatorAnswer = new System.Windows.Forms.TextBox();
            this.TextNumeratorAnswer = new System.Windows.Forms.TextBox();
            this.TextNumerator2 = new System.Windows.Forms.TextBox();
            this.TextDenominator2 = new System.Windows.Forms.TextBox();
            this.TextDenominator1 = new System.Windows.Forms.TextBox();
            this.TextNumerator1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MathButton = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.lblMixed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(219, 67);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(39, 33);
            this.EqualButton.TabIndex = 14;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // TextDenominatorAnswer
            // 
            this.TextDenominatorAnswer.Location = new System.Drawing.Point(286, 106);
            this.TextDenominatorAnswer.Multiline = true;
            this.TextDenominatorAnswer.Name = "TextDenominatorAnswer";
            this.TextDenominatorAnswer.ReadOnly = true;
            this.TextDenominatorAnswer.Size = new System.Drawing.Size(42, 31);
            this.TextDenominatorAnswer.TabIndex = 13;
            // 
            // TextNumeratorAnswer
            // 
            this.TextNumeratorAnswer.Location = new System.Drawing.Point(286, 48);
            this.TextNumeratorAnswer.Multiline = true;
            this.TextNumeratorAnswer.Name = "TextNumeratorAnswer";
            this.TextNumeratorAnswer.ReadOnly = true;
            this.TextNumeratorAnswer.Size = new System.Drawing.Size(42, 31);
            this.TextNumeratorAnswer.TabIndex = 12;
            // 
            // TextNumerator2
            // 
            this.TextNumerator2.Location = new System.Drawing.Point(160, 48);
            this.TextNumerator2.Multiline = true;
            this.TextNumerator2.Name = "TextNumerator2";
            this.TextNumerator2.Size = new System.Drawing.Size(42, 31);
            this.TextNumerator2.TabIndex = 11;
            // 
            // TextDenominator2
            // 
            this.TextDenominator2.Location = new System.Drawing.Point(160, 106);
            this.TextDenominator2.Multiline = true;
            this.TextDenominator2.Name = "TextDenominator2";
            this.TextDenominator2.Size = new System.Drawing.Size(42, 31);
            this.TextDenominator2.TabIndex = 10;
            // 
            // TextDenominator1
            // 
            this.TextDenominator1.Location = new System.Drawing.Point(30, 106);
            this.TextDenominator1.Multiline = true;
            this.TextDenominator1.Name = "TextDenominator1";
            this.TextDenominator1.Size = new System.Drawing.Size(42, 31);
            this.TextDenominator1.TabIndex = 9;
            // 
            // TextNumerator1
            // 
            this.TextNumerator1.Location = new System.Drawing.Point(30, 48);
            this.TextNumerator1.Multiline = true;
            this.TextNumerator1.Name = "TextNumerator1";
            this.TextNumerator1.Size = new System.Drawing.Size(42, 31);
            this.TextNumerator1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 3);
            this.label1.TabIndex = 15;
            this.label1.Text = "_";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(144, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 3);
            this.label2.TabIndex = 16;
            this.label2.Text = "_";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(273, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 3);
            this.label3.TabIndex = 17;
            this.label3.Text = "_";
            // 
            // MathButton
            // 
            this.MathButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MathButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathButton.FormattingEnabled = true;
            this.MathButton.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.MathButton.Location = new System.Drawing.Point(88, 66);
            this.MathButton.Name = "MathButton";
            this.MathButton.Size = new System.Drawing.Size(51, 37);
            this.MathButton.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "=";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(390, 73);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 31);
            this.lblAnswer.TabIndex = 21;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(396, 133);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Clear Form";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // lblMixed
            // 
            this.lblMixed.AutoSize = true;
            this.lblMixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMixed.Location = new System.Drawing.Point(39, 189);
            this.lblMixed.Name = "lblMixed";
            this.lblMixed.Size = new System.Drawing.Size(0, 18);
            this.lblMixed.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 214);
            this.Controls.Add(this.lblMixed);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MathButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.TextDenominatorAnswer);
            this.Controls.Add(this.TextNumeratorAnswer);
            this.Controls.Add(this.TextNumerator2);
            this.Controls.Add(this.TextDenominator2);
            this.Controls.Add(this.TextDenominator1);
            this.Controls.Add(this.TextNumerator1);
            this.Name = "Form1";
            this.Text = "Fraction Calculator - Bradley Hughes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.TextBox TextDenominatorAnswer;
        private System.Windows.Forms.TextBox TextNumeratorAnswer;
        private System.Windows.Forms.TextBox TextNumerator2;
        private System.Windows.Forms.TextBox TextDenominator2;
        private System.Windows.Forms.TextBox TextDenominator1;
        private System.Windows.Forms.TextBox TextNumerator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MathButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label lblMixed;
    }
}

