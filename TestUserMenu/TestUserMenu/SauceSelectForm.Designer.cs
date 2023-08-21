namespace TestUserMenu
{
    partial class SauceSelectForm
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
            this.sauceTextBox = new System.Windows.Forms.TextBox();
            this.sauceLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sauceTextBox
            // 
            this.sauceTextBox.Location = new System.Drawing.Point(183, 98);
            this.sauceTextBox.Name = "sauceTextBox";
            this.sauceTextBox.Size = new System.Drawing.Size(100, 20);
            this.sauceTextBox.TabIndex = 0;
            // 
            // sauceLabel
            // 
            this.sauceLabel.AutoSize = true;
            this.sauceLabel.Location = new System.Drawing.Point(77, 101);
            this.sauceLabel.Name = "sauceLabel";
            this.sauceLabel.Size = new System.Drawing.Size(77, 13);
            this.sauceLabel.TabIndex = 1;
            this.sauceLabel.Text = "Type of Sauce";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(254, 167);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitSauceButton_Click);
            // 
            // SauceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 215);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.sauceLabel);
            this.Controls.Add(this.sauceTextBox);
            this.Name = "SauceSelectForm";
            this.Text = "Sauce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sauceTextBox;
        private System.Windows.Forms.Label sauceLabel;
        private System.Windows.Forms.Button submitButton;
    }
}