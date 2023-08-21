namespace TestUserMenu
{
    partial class PizzaScreen
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
            this.singleToppingPizzaButton = new System.Windows.Forms.Button();
            this.cbrPizzaButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.supremePizzaButton = new System.Windows.Forms.Button();
            this.amdButton = new System.Windows.Forms.Button();
            this.tacoPizzaButton = new System.Windows.Forms.Button();
            this.hawaiianPizzaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singleToppingPizzaButton
            // 
            this.singleToppingPizzaButton.Location = new System.Drawing.Point(89, 138);
            this.singleToppingPizzaButton.Name = "singleToppingPizzaButton";
            this.singleToppingPizzaButton.Size = new System.Drawing.Size(139, 21);
            this.singleToppingPizzaButton.TabIndex = 0;
            this.singleToppingPizzaButton.Text = "Single Topping Pizza";
            this.singleToppingPizzaButton.UseVisualStyleBackColor = true;
            this.singleToppingPizzaButton.Click += new System.EventHandler(this.singleToppingButton_Click);
            // 
            // cbrPizzaButton
            // 
            this.cbrPizzaButton.Location = new System.Drawing.Point(472, 138);
            this.cbrPizzaButton.Name = "cbrPizzaButton";
            this.cbrPizzaButton.Size = new System.Drawing.Size(129, 21);
            this.cbrPizzaButton.TabIndex = 1;
            this.cbrPizzaButton.Text = "Chicken Bacon Ranch Pizza";
            this.cbrPizzaButton.UseVisualStyleBackColor = true;
            this.cbrPizzaButton.Click += new System.EventHandler(this.specialtyPizzaButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(89, 381);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // supremePizzaButton
            // 
            this.supremePizzaButton.Location = new System.Drawing.Point(472, 175);
            this.supremePizzaButton.Name = "supremePizzaButton";
            this.supremePizzaButton.Size = new System.Drawing.Size(129, 24);
            this.supremePizzaButton.TabIndex = 3;
            this.supremePizzaButton.Text = "Supreme Pizza";
            this.supremePizzaButton.UseVisualStyleBackColor = true;
            this.supremePizzaButton.Click += new System.EventHandler(this.specialtyPizzaButton_Click);
            // 
            // amdButton
            // 
            this.amdButton.Location = new System.Drawing.Point(472, 223);
            this.amdButton.Name = "amdButton";
            this.amdButton.Size = new System.Drawing.Size(129, 26);
            this.amdButton.TabIndex = 4;
            this.amdButton.Text = "All Meat Deluxe Pizza";
            this.amdButton.UseVisualStyleBackColor = true;
            this.amdButton.Click += new System.EventHandler(this.specialtyPizzaButton_Click);
            // 
            // tacoPizzaButton
            // 
            this.tacoPizzaButton.Location = new System.Drawing.Point(472, 266);
            this.tacoPizzaButton.Name = "tacoPizzaButton";
            this.tacoPizzaButton.Size = new System.Drawing.Size(129, 22);
            this.tacoPizzaButton.TabIndex = 5;
            this.tacoPizzaButton.Text = "Taco Pizza";
            this.tacoPizzaButton.UseVisualStyleBackColor = true;
            this.tacoPizzaButton.Click += new System.EventHandler(this.specialtyPizzaButton_Click);
            // 
            // hawaiianPizzaButton
            // 
            this.hawaiianPizzaButton.Location = new System.Drawing.Point(472, 311);
            this.hawaiianPizzaButton.Name = "hawaiianPizzaButton";
            this.hawaiianPizzaButton.Size = new System.Drawing.Size(129, 27);
            this.hawaiianPizzaButton.TabIndex = 6;
            this.hawaiianPizzaButton.Text = "Hawaiian Pizza";
            this.hawaiianPizzaButton.UseVisualStyleBackColor = true;
            this.hawaiianPizzaButton.Click += new System.EventHandler(this.specialtyPizzaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizza";
            // 
            // PizzaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hawaiianPizzaButton);
            this.Controls.Add(this.tacoPizzaButton);
            this.Controls.Add(this.amdButton);
            this.Controls.Add(this.supremePizzaButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cbrPizzaButton);
            this.Controls.Add(this.singleToppingPizzaButton);
            this.Name = "PizzaScreen";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singleToppingPizzaButton;
        private System.Windows.Forms.Button cbrPizzaButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button supremePizzaButton;
        private System.Windows.Forms.Button amdButton;
        private System.Windows.Forms.Button tacoPizzaButton;
        private System.Windows.Forms.Button hawaiianPizzaButton;
        private System.Windows.Forms.Label label1;
    }
}

