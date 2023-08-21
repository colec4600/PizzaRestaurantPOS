using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class AdminPopup : Form
    {
        public AdminPopup()
        {
            InitializeComponent();
        }
        public static string date;

        private void submitButton_Click(object sender, EventArgs e)
        {
            date = dateTextBox.Text;
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}