using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DBConnection conn = new DBConnection();
        
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || password.Text=="")
            {
                if (email.Text == "")
                {
                    emailError.Text = "Email is null. Please Fill";
                }
                else
                {
                    emailError.Text = "";
                }
                if (password.Text == "")
                {
                    passwordError.Text = "Password is null. Please Fill";
                }
                else
                {
                    passwordError.Text = "";
                }


            } 
            else
            {
                try
                {
                    MySqlConnection myCon=new MySqlConnection(conn.connectionString);
                    myCon.Open(); 
                    string query = "select * from admin where name='" + email.Text.Trim() + "' and password='" + password.Text.Trim() + "'";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, myCon);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        emailError.Text = "Email or password is incorrect";
                        passwordError.Text = "";
                    }
                    myCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                
                

            }

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            email.Text = "";
            password.Text = "";
            emailError.Text = "";
            passwordError.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked == true)
            { 
                password.UseSystemPasswordChar=true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }

      
    }
}
