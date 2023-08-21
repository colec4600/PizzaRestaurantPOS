namespace TestUserMenu
{
    partial class Menu
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
            this.pizzaScreenButton = new System.Windows.Forms.Button();
            this.submitReceiptButton = new System.Windows.Forms.Button();
            this.cancelReceiptButton = new System.Windows.Forms.Button();
            this.cancelItemButton = new System.Windows.Forms.Button();
            this.specialsScreenButton = new System.Windows.Forms.Button();
            this.refundButton = new System.Windows.Forms.Button();
            this.saladScreenButton = new System.Windows.Forms.Button();
            this.pastaScreenButton = new System.Windows.Forms.Button();
            this.sidesScreenButton = new System.Windows.Forms.Button();
            this.beveragesScreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pizzaScreenButton
            // 
            this.pizzaScreenButton.Location = new System.Drawing.Point(206, 62);
            this.pizzaScreenButton.Name = "pizzaScreenButton";
            this.pizzaScreenButton.Size = new System.Drawing.Size(75, 23);
            this.pizzaScreenButton.TabIndex = 0;
            this.pizzaScreenButton.Text = "Pizza";
            this.pizzaScreenButton.UseVisualStyleBackColor = true;
            this.pizzaScreenButton.Click += new System.EventHandler(this.pizzaScreenButton_Click);
            // 
            // submitReceiptButton
            // 
            this.submitReceiptButton.Location = new System.Drawing.Point(558, 321);
            this.submitReceiptButton.Name = "submitReceiptButton";
            this.submitReceiptButton.Size = new System.Drawing.Size(118, 20);
            this.submitReceiptButton.TabIndex = 1;
            this.submitReceiptButton.Text = "Submit Receipt";
            this.submitReceiptButton.UseVisualStyleBackColor = true;
            this.submitReceiptButton.Click += new System.EventHandler(this.submitReceiptButton_Click);
            // 
            // cancelReceiptButton
            // 
            this.cancelReceiptButton.Location = new System.Drawing.Point(64, 345);
            this.cancelReceiptButton.Name = "cancelReceiptButton";
            this.cancelReceiptButton.Size = new System.Drawing.Size(117, 22);
            this.cancelReceiptButton.TabIndex = 2;
            this.cancelReceiptButton.Text = "Cancel Receipt";
            this.cancelReceiptButton.UseVisualStyleBackColor = true;
            this.cancelReceiptButton.Click += new System.EventHandler(this.cancelReceiptButton_Click);
            // 
            // cancelItemButton
            // 
            this.cancelItemButton.Location = new System.Drawing.Point(64, 303);
            this.cancelItemButton.Name = "cancelItemButton";
            this.cancelItemButton.Size = new System.Drawing.Size(117, 24);
            this.cancelItemButton.TabIndex = 3;
            this.cancelItemButton.Text = "Cancel Last Item";
            this.cancelItemButton.UseVisualStyleBackColor = true;
            this.cancelItemButton.Click += new System.EventHandler(this.cancelLastItemButton_Click);
            // 
            // specialsScreenButton
            // 
            this.specialsScreenButton.Location = new System.Drawing.Point(403, 107);
            this.specialsScreenButton.Name = "specialsScreenButton";
            this.specialsScreenButton.Size = new System.Drawing.Size(75, 23);
            this.specialsScreenButton.TabIndex = 4;
            this.specialsScreenButton.Text = "Specials";
            this.specialsScreenButton.UseVisualStyleBackColor = true;
            this.specialsScreenButton.Click += new System.EventHandler(this.specialsScreenButton_Click);
            // 
            // refundButton
            // 
            this.refundButton.Location = new System.Drawing.Point(403, 193);
            this.refundButton.Name = "refundButton";
            this.refundButton.Size = new System.Drawing.Size(75, 23);
            this.refundButton.TabIndex = 5;
            this.refundButton.Text = "Refund";
            this.refundButton.UseVisualStyleBackColor = true;
            this.refundButton.Click += new System.EventHandler(this.refundButton_Click);
            // 
            // saladScreenButton
            // 
            this.saladScreenButton.Location = new System.Drawing.Point(206, 107);
            this.saladScreenButton.Name = "saladScreenButton";
            this.saladScreenButton.Size = new System.Drawing.Size(75, 23);
            this.saladScreenButton.TabIndex = 6;
            this.saladScreenButton.Text = "Salads";
            this.saladScreenButton.UseVisualStyleBackColor = true;
            this.saladScreenButton.Click += new System.EventHandler(this.saladsScreenButton_Click);
            // 
            // pastaScreenButton
            // 
            this.pastaScreenButton.Location = new System.Drawing.Point(206, 149);
            this.pastaScreenButton.Name = "pastaScreenButton";
            this.pastaScreenButton.Size = new System.Drawing.Size(75, 23);
            this.pastaScreenButton.TabIndex = 7;
            this.pastaScreenButton.Text = "Pasta";
            this.pastaScreenButton.UseVisualStyleBackColor = true;
            this.pastaScreenButton.Click += new System.EventHandler(this.pastaScreenButton_Click);
            // 
            // sidesScreenButton
            // 
            this.sidesScreenButton.Location = new System.Drawing.Point(206, 193);
            this.sidesScreenButton.Name = "sidesScreenButton";
            this.sidesScreenButton.Size = new System.Drawing.Size(75, 23);
            this.sidesScreenButton.TabIndex = 8;
            this.sidesScreenButton.Text = "Sides";
            this.sidesScreenButton.UseVisualStyleBackColor = true;
            this.sidesScreenButton.Click += new System.EventHandler(this.sidesScreenButton_Click);
            // 
            // beveragesScreenButton
            // 
            this.beveragesScreenButton.Location = new System.Drawing.Point(206, 238);
            this.beveragesScreenButton.Name = "beveragesScreenButton";
            this.beveragesScreenButton.Size = new System.Drawing.Size(75, 23);
            this.beveragesScreenButton.TabIndex = 9;
            this.beveragesScreenButton.Text = "Beverages";
            this.beveragesScreenButton.UseVisualStyleBackColor = true;
            this.beveragesScreenButton.Click += new System.EventHandler(this.beveragesScreenButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beveragesScreenButton);
            this.Controls.Add(this.sidesScreenButton);
            this.Controls.Add(this.pastaScreenButton);
            this.Controls.Add(this.saladScreenButton);
            this.Controls.Add(this.refundButton);
            this.Controls.Add(this.specialsScreenButton);
            this.Controls.Add(this.cancelItemButton);
            this.Controls.Add(this.cancelReceiptButton);
            this.Controls.Add(this.submitReceiptButton);
            this.Controls.Add(this.pizzaScreenButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pizzaScreenButton;
        private System.Windows.Forms.Button submitReceiptButton;
        private System.Windows.Forms.Button cancelReceiptButton;
        private System.Windows.Forms.Button cancelItemButton;
        private System.Windows.Forms.Button specialsScreenButton;
        private System.Windows.Forms.Button refundButton;
        private System.Windows.Forms.Button saladScreenButton;
        private System.Windows.Forms.Button pastaScreenButton;
        private System.Windows.Forms.Button sidesScreenButton;
        private System.Windows.Forms.Button beveragesScreenButton;
    }
}