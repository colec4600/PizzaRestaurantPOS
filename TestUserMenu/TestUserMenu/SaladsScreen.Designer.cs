namespace TestUserMenu
{
    partial class SaladsScreen
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
            this.oneTripSaladButton = new System.Windows.Forms.Button();
            this.ayceSaladButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.sideSaladButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oneTripSaladButton
            // 
            this.oneTripSaladButton.Location = new System.Drawing.Point(315, 176);
            this.oneTripSaladButton.Name = "oneTripSaladButton";
            this.oneTripSaladButton.Size = new System.Drawing.Size(102, 24);
            this.oneTripSaladButton.TabIndex = 0;
            this.oneTripSaladButton.Text = "One Trip Salad";
            this.oneTripSaladButton.UseVisualStyleBackColor = true;
            this.oneTripSaladButton.Click += new System.EventHandler(this.saladButton_Click);
            // 
            // ayceSaladButton
            // 
            this.ayceSaladButton.Location = new System.Drawing.Point(295, 221);
            this.ayceSaladButton.Name = "ayceSaladButton";
            this.ayceSaladButton.Size = new System.Drawing.Size(134, 20);
            this.ayceSaladButton.TabIndex = 1;
            this.ayceSaladButton.Text = "All You Can Eat Salad";
            this.ayceSaladButton.UseVisualStyleBackColor = true;
            this.ayceSaladButton.Click += new System.EventHandler(this.saladButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(113, 370);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sideSaladButton
            // 
            this.sideSaladButton.Location = new System.Drawing.Point(330, 269);
            this.sideSaladButton.Name = "sideSaladButton";
            this.sideSaladButton.Size = new System.Drawing.Size(75, 23);
            this.sideSaladButton.TabIndex = 3;
            this.sideSaladButton.Text = "Side Salad";
            this.sideSaladButton.UseVisualStyleBackColor = true;
            this.sideSaladButton.Click += new System.EventHandler(this.saladButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salads";
            // 
            // SaladsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sideSaladButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ayceSaladButton);
            this.Controls.Add(this.oneTripSaladButton);
            this.Name = "SaladsScreen";
            this.Text = "Salads";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneTripSaladButton;
        private System.Windows.Forms.Button ayceSaladButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button sideSaladButton;
        private System.Windows.Forms.Label label1;
    }
}