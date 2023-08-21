namespace TestUserMenu
{
    partial class BeveragesScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.sodaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beverages";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(140, 343);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Location = new System.Drawing.Point(324, 194);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(75, 23);
            this.waterButton.TabIndex = 2;
            this.waterButton.Text = "Water";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.Click += new System.EventHandler(this.beverageButton_Click);
            // 
            // sodaButton
            // 
            this.sodaButton.Location = new System.Drawing.Point(324, 270);
            this.sodaButton.Name = "sodaButton";
            this.sodaButton.Size = new System.Drawing.Size(75, 23);
            this.sodaButton.TabIndex = 3;
            this.sodaButton.Text = "Soda";
            this.sodaButton.UseVisualStyleBackColor = true;
            this.sodaButton.Click += new System.EventHandler(this.beverageButton_Click);
            // 
            // BeveragesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sodaButton);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "BeveragesScreen";
            this.Text = "Beverages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button sodaButton;
    }
}