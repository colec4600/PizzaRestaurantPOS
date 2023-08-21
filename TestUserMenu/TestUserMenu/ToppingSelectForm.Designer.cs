namespace TestUserMenu
{
    partial class ToppingSelectForm
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
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.toppingTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(187, 107);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 0;
            // 
            // toppingTextBox
            // 
            this.toppingTextBox.Location = new System.Drawing.Point(187, 169);
            this.toppingTextBox.Name = "toppingTextBox";
            this.toppingTextBox.Size = new System.Drawing.Size(100, 20);
            this.toppingTextBox.TabIndex = 1;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(100, 110);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size";
            // 
            // toppingLabel
            // 
            this.toppingLabel.AutoSize = true;
            this.toppingLabel.Location = new System.Drawing.Point(100, 172);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(46, 13);
            this.toppingLabel.TabIndex = 3;
            this.toppingLabel.Text = "Topping";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(331, 243);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ToppingSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 294);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.toppingLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.toppingTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Name = "ToppingSelectForm";
            this.Text = "ToppingSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox toppingTextBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.Button submitButton;
    }
}