using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = tb_firstName.Text;
            string lastName = tb_lastName.Text;
            string selected = "";
            foreach(RadioButton rb in gb_options.Controls)
            {
                if (rb.Checked) { selected = rb.Text; }
            }

            if (validateFields())
            {
                //Console.WriteLine("First name is: " + firstName);
                //Console.WriteLine("Last name is: " + lastName);
                //Console.WriteLine("Radio button value is: " + selected);
                MessageBox.Show("First name is: " + firstName + " Last name is: " + lastName + " Radio button value is: " + selected);
                tb_firstName.Clear();
                tb_lastName.Clear();
                foreach (RadioButton rb in gb_options.Controls)
                {
                    if (rb.Checked) { rb.Checked = false; }
                }
            }
            else
            {
                MessageBox.Show("Please fill out form", "Alert");
            }
        }

        private bool validateFields()
        {
            string firstName = tb_firstName.Text;
            string lastName = tb_lastName.Text;
            if (firstName != null && lastName != null) 
            {
                foreach (RadioButton rb in gb_options.Controls)
                {
                    if (rb.Checked) { return true; } else { return false; }
                }
            }
            return false;
        }
    }
}
