namespace TestUserMenu
{
    partial class SpecialsScreen
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
            this.wingsSpecialButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.medSpecialPizzaButton = new System.Windows.Forms.Button();
            this.singleToppingSpecialButton = new System.Windows.Forms.Button();
            this.pastaSpecialButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wingsSpecialButton
            // 
            this.wingsSpecialButton.Location = new System.Drawing.Point(150, 183);
            this.wingsSpecialButton.Name = "wingsSpecialButton";
            this.wingsSpecialButton.Size = new System.Drawing.Size(159, 24);
            this.wingsSpecialButton.TabIndex = 0;
            this.wingsSpecialButton.Text = "$4 off 12 Wings";
            this.wingsSpecialButton.UseVisualStyleBackColor = true;
            this.wingsSpecialButton.Click += new System.EventHandler(this.wingsSpecialButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(125, 341);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // medSpecialPizzaButton
            // 
            this.medSpecialPizzaButton.Location = new System.Drawing.Point(444, 183);
            this.medSpecialPizzaButton.Name = "medSpecialPizzaButton";
            this.medSpecialPizzaButton.Size = new System.Drawing.Size(159, 24);
            this.medSpecialPizzaButton.TabIndex = 2;
            this.medSpecialPizzaButton.Text = "$3 off Medium Speciality Pizza";
            this.medSpecialPizzaButton.UseVisualStyleBackColor = true;
            this.medSpecialPizzaButton.Click += new System.EventHandler(this.specialtyPizzaSpecialButton_Click);
            // 
            // singleToppingSpecialButton
            // 
            this.singleToppingSpecialButton.Location = new System.Drawing.Point(150, 247);
            this.singleToppingSpecialButton.Name = "singleToppingSpecialButton";
            this.singleToppingSpecialButton.Size = new System.Drawing.Size(159, 24);
            this.singleToppingSpecialButton.TabIndex = 3;
            this.singleToppingSpecialButton.Text = "$3 off Large Single Topping Pizza";
            this.singleToppingSpecialButton.UseVisualStyleBackColor = true;
            this.singleToppingSpecialButton.Click += new System.EventHandler(this.singleToppingSpecialButton_Click);
            // 
            // pastaSpecialButton
            // 
            this.pastaSpecialButton.Location = new System.Drawing.Point(444, 247);
            this.pastaSpecialButton.Name = "pastaSpecialButton";
            this.pastaSpecialButton.Size = new System.Drawing.Size(159, 24);
            this.pastaSpecialButton.TabIndex = 4;
            this.pastaSpecialButton.Text = "$2 off Pasta";
            this.pastaSpecialButton.UseVisualStyleBackColor = true;
            this.pastaSpecialButton.Click += new System.EventHandler(this.pastaSpecialButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Specials";
            // 
            // SpecialsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pastaSpecialButton);
            this.Controls.Add(this.singleToppingSpecialButton);
            this.Controls.Add(this.medSpecialPizzaButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.wingsSpecialButton);
            this.Name = "SpecialsScreen";
            this.Text = "Specials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wingsSpecialButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button medSpecialPizzaButton;
        private System.Windows.Forms.Button singleToppingSpecialButton;
        private System.Windows.Forms.Button pastaSpecialButton;
        private System.Windows.Forms.Label label1;
    }
}