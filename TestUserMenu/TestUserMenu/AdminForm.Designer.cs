namespace TestUserMenu
{
    partial class AdminForm
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
            this.itemSalesButton = new System.Windows.Forms.Button();
            this.totalSalesButton = new System.Windows.Forms.Button();
            this.salesEmployeeButton = new System.Windows.Forms.Button();
            this.numberOfSalesButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemSalesButton
            // 
            this.itemSalesButton.Location = new System.Drawing.Point(165, 148);
            this.itemSalesButton.Name = "itemSalesButton";
            this.itemSalesButton.Size = new System.Drawing.Size(109, 24);
            this.itemSalesButton.TabIndex = 0;
            this.itemSalesButton.Text = "Sales by Item";
            this.itemSalesButton.UseVisualStyleBackColor = true;
            this.itemSalesButton.Click += new System.EventHandler(this.salesByItemButton_Click);
            // 
            // totalSalesButton
            // 
            this.totalSalesButton.Location = new System.Drawing.Point(165, 216);
            this.totalSalesButton.Name = "totalSalesButton";
            this.totalSalesButton.Size = new System.Drawing.Size(109, 24);
            this.totalSalesButton.TabIndex = 1;
            this.totalSalesButton.Text = "Total Sales by Date";
            this.totalSalesButton.UseVisualStyleBackColor = true;
            this.totalSalesButton.Click += new System.EventHandler(this.salesByDateButton_Click);
            // 
            // salesEmployeeButton
            // 
            this.salesEmployeeButton.Location = new System.Drawing.Point(165, 287);
            this.salesEmployeeButton.Name = "salesEmployeeButton";
            this.salesEmployeeButton.Size = new System.Drawing.Size(109, 26);
            this.salesEmployeeButton.TabIndex = 2;
            this.salesEmployeeButton.Text = "Sales by Employee";
            this.salesEmployeeButton.UseVisualStyleBackColor = true;
            this.salesEmployeeButton.Click += new System.EventHandler(this.employeeSalesButton_Click);
            // 
            // numberOfSalesButton
            // 
            this.numberOfSalesButton.Location = new System.Drawing.Point(424, 148);
            this.numberOfSalesButton.Name = "numberOfSalesButton";
            this.numberOfSalesButton.Size = new System.Drawing.Size(109, 24);
            this.numberOfSalesButton.TabIndex = 3;
            this.numberOfSalesButton.Text = "Number of Sales";
            this.numberOfSalesButton.UseVisualStyleBackColor = true;
            this.numberOfSalesButton.Click += new System.EventHandler(this.numberOfSalesButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numberOfSalesButton);
            this.Controls.Add(this.salesEmployeeButton);
            this.Controls.Add(this.totalSalesButton);
            this.Controls.Add(this.itemSalesButton);
            this.Name = "AdminForm";
            this.Text = "Admin Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itemSalesButton;
        private System.Windows.Forms.Button totalSalesButton;
        private System.Windows.Forms.Button salesEmployeeButton;
        private System.Windows.Forms.Button numberOfSalesButton;
        private System.Windows.Forms.Button button5;
    }
}