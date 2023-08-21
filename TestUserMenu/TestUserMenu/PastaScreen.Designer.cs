namespace TestUserMenu
{
    partial class PastaScreen
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
            this.smallSpaghettiButton = new System.Windows.Forms.Button();
            this.largeSpaghettiButton = new System.Windows.Forms.Button();
            this.smallChickenAlfredoButton = new System.Windows.Forms.Button();
            this.largeChickenAlfredoButton = new System.Windows.Forms.Button();
            this.addChickenButton = new System.Windows.Forms.Button();
            this.addMeatSauceButton = new System.Windows.Forms.Button();
            this.addMeatballsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smallSpaghettiButton
            // 
            this.smallSpaghettiButton.Location = new System.Drawing.Point(158, 109);
            this.smallSpaghettiButton.Name = "smallSpaghettiButton";
            this.smallSpaghettiButton.Size = new System.Drawing.Size(93, 23);
            this.smallSpaghettiButton.TabIndex = 0;
            this.smallSpaghettiButton.Text = "Small Spaghetti";
            this.smallSpaghettiButton.UseVisualStyleBackColor = true;
            this.smallSpaghettiButton.Click += new System.EventHandler(this.pastaButton_Click);
            // 
            // largeSpaghettiButton
            // 
            this.largeSpaghettiButton.Location = new System.Drawing.Point(159, 161);
            this.largeSpaghettiButton.Name = "largeSpaghettiButton";
            this.largeSpaghettiButton.Size = new System.Drawing.Size(92, 23);
            this.largeSpaghettiButton.TabIndex = 1;
            this.largeSpaghettiButton.Text = "Large Spaghetti";
            this.largeSpaghettiButton.UseVisualStyleBackColor = true;
            this.largeSpaghettiButton.Click += new System.EventHandler(this.pastaButton_Click);
            // 
            // smallChickenAlfredoButton
            // 
            this.smallChickenAlfredoButton.Location = new System.Drawing.Point(357, 109);
            this.smallChickenAlfredoButton.Name = "smallChickenAlfredoButton";
            this.smallChickenAlfredoButton.Size = new System.Drawing.Size(122, 23);
            this.smallChickenAlfredoButton.TabIndex = 2;
            this.smallChickenAlfredoButton.Text = "Small Chicken Alfredo";
            this.smallChickenAlfredoButton.UseVisualStyleBackColor = true;
            this.smallChickenAlfredoButton.Click += new System.EventHandler(this.pastaButton_Click);
            // 
            // largeChickenAlfredoButton
            // 
            this.largeChickenAlfredoButton.Location = new System.Drawing.Point(357, 161);
            this.largeChickenAlfredoButton.Name = "largeChickenAlfredoButton";
            this.largeChickenAlfredoButton.Size = new System.Drawing.Size(122, 23);
            this.largeChickenAlfredoButton.TabIndex = 3;
            this.largeChickenAlfredoButton.Text = "Large Chicken Alfredo";
            this.largeChickenAlfredoButton.UseVisualStyleBackColor = true;
            this.largeChickenAlfredoButton.Click += new System.EventHandler(this.pastaButton_Click);
            // 
            // addChickenButton
            // 
            this.addChickenButton.Location = new System.Drawing.Point(380, 287);
            this.addChickenButton.Name = "addChickenButton";
            this.addChickenButton.Size = new System.Drawing.Size(84, 24);
            this.addChickenButton.TabIndex = 4;
            this.addChickenButton.Text = "Add Chicken";
            this.addChickenButton.UseVisualStyleBackColor = true;
            this.addChickenButton.Click += new System.EventHandler(this.addSide_Click);
            // 
            // addMeatSauceButton
            // 
            this.addMeatSauceButton.Location = new System.Drawing.Point(158, 286);
            this.addMeatSauceButton.Name = "addMeatSauceButton";
            this.addMeatSauceButton.Size = new System.Drawing.Size(110, 25);
            this.addMeatSauceButton.TabIndex = 5;
            this.addMeatSauceButton.Text = "Add Meat Sauce";
            this.addMeatSauceButton.UseVisualStyleBackColor = true;
            this.addMeatSauceButton.Click += new System.EventHandler(this.addSide_Click);
            // 
            // addMeatballsButton
            // 
            this.addMeatballsButton.Location = new System.Drawing.Point(158, 331);
            this.addMeatballsButton.Name = "addMeatballsButton";
            this.addMeatballsButton.Size = new System.Drawing.Size(110, 23);
            this.addMeatballsButton.TabIndex = 6;
            this.addMeatballsButton.Text = "Add Meatballs";
            this.addMeatballsButton.UseVisualStyleBackColor = true;
            this.addMeatballsButton.Click += new System.EventHandler(this.addSide_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(78, 390);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pasta";
            // 
            // PastaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addMeatballsButton);
            this.Controls.Add(this.addMeatSauceButton);
            this.Controls.Add(this.addChickenButton);
            this.Controls.Add(this.largeChickenAlfredoButton);
            this.Controls.Add(this.smallChickenAlfredoButton);
            this.Controls.Add(this.largeSpaghettiButton);
            this.Controls.Add(this.smallSpaghettiButton);
            this.Name = "PastaScreen";
            this.Text = "Pasta";
            this.Click += new System.EventHandler(this.pastaButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smallSpaghettiButton;
        private System.Windows.Forms.Button largeSpaghettiButton;
        private System.Windows.Forms.Button smallChickenAlfredoButton;
        private System.Windows.Forms.Button largeChickenAlfredoButton;
        private System.Windows.Forms.Button addChickenButton;
        private System.Windows.Forms.Button addMeatSauceButton;
        private System.Windows.Forms.Button addMeatballsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}