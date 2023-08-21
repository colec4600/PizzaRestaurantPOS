using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H8375L8\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True");

        public void submitButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            String query = "SELECT * FROM TestDB WHERE username = '" + username + "' AND password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                if (username == "admin")
                {
                    AdminPopup adminPopup = new AdminPopup();
                    adminPopup.Show();
                    this.Hide();
                }

                else
                {
                    TestUserMenu.Menu.username = username;
                    NewCustomerScreen customerScreen = new NewCustomerScreen(username);
                    customerScreen.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLabel.Focus();
            }
        }
    }
}

