using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestProjectDatabaseLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H8375L8\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String username, password;

            username = usernameBox.Text;
            password = passwordBox.Text;

            try
            {
                String query = "SELECT * FROM TestDB WHERE username = '"+usernameBox.Text+"' AND password = '"+passwordBox.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = usernameBox.Text; password = passwordBox.Text;
                    MenuForm form2 = new MenuForm();
                    Form2 form3 = new Form2();
                    if (username == "admin")
                    {
                        form2.Show();
                        this.Hide();
                    }

                    if (username == "cole")
                    {
                        form3.Show();
                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameBox.Clear(); passwordBox.Clear();
                    usernameBox.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally { conn.Close(); }
        }
    }
}
