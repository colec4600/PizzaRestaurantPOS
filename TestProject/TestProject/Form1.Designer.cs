namespace TestProject
{
    partial class Form1
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
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.button1Submit = new System.Windows.Forms.Button();
            this.gb_options = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(200, 138);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(100, 20);
            this.tb_firstName.TabIndex = 2;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(504, 138);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(100, 20);
            this.tb_lastName.TabIndex = 4;
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Location = new System.Drawing.Point(93, 32);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(48, 17);
            this.rd_male.TabIndex = 6;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Male";
            this.rd_male.UseVisualStyleBackColor = true;
            this.rd_male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(263, 32);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 7;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            this.rb_female.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Location = new System.Drawing.Point(420, 32);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(51, 17);
            this.rb_other.TabIndex = 8;
            this.rb_other.TabStop = true;
            this.rb_other.Text = "Other";
            this.rb_other.UseVisualStyleBackColor = true;
            this.rb_other.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1Submit
            // 
            this.button1Submit.Location = new System.Drawing.Point(296, 278);
            this.button1Submit.Name = "button1Submit";
            this.button1Submit.Size = new System.Drawing.Size(107, 37);
            this.button1Submit.TabIndex = 9;
            this.button1Submit.Text = "Submit";
            this.button1Submit.UseVisualStyleBackColor = true;
            this.button1Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_options
            // 
            this.gb_options.Controls.Add(this.rd_male);
            this.gb_options.Controls.Add(this.rb_female);
            this.gb_options.Controls.Add(this.rb_other);
            this.gb_options.Location = new System.Drawing.Point(45, 192);
            this.gb_options.Name = "gb_options";
            this.gb_options.Size = new System.Drawing.Size(691, 55);
            this.gb_options.TabIndex = 5;
            this.gb_options.TabStop = false;
            this.gb_options.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(253, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Register Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_options);
            this.Controls.Add(this.button1Submit);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Name = "Form1";
            this.Text = "TestProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_options.ResumeLayout(false);
            this.gb_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_other;
        private System.Windows.Forms.Button button1Submit;
        private System.Windows.Forms.GroupBox gb_options;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

