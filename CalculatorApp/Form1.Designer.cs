namespace CalculatorApp
{
    partial class Calcualtor
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstnumberTextBox = new System.Windows.Forms.TextBox();
            this.secondnumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // firstnumberTextBox
            // 
            this.firstnumberTextBox.Location = new System.Drawing.Point(115, 40);
            this.firstnumberTextBox.Name = "firstnumberTextBox";
            this.firstnumberTextBox.Size = new System.Drawing.Size(247, 20);
            this.firstnumberTextBox.TabIndex = 1;
            // 
            // secondnumberTextBox
            // 
            this.secondnumberTextBox.Location = new System.Drawing.Point(115, 75);
            this.secondnumberTextBox.Name = "secondnumberTextBox";
            this.secondnumberTextBox.Size = new System.Drawing.Size(247, 20);
            this.secondnumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(115, 116);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(247, 20);
            this.resultTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(386, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 25);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Addition";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(386, 126);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(98, 25);
            this.divideButton.TabIndex = 7;
            this.divideButton.Text = "Divition";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(386, 96);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(98, 25);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "Multiplication";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Location = new System.Drawing.Point(386, 64);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(98, 25);
            this.substractButton.TabIndex = 9;
            this.substractButton.Text = "Substraction";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // Calcualtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 184);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondnumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Calcualtor";
            this.Text = "Calculator UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnumberTextBox;
        private System.Windows.Forms.TextBox secondnumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button substractButton;
    }
}

