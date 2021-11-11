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

namespace BankSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_account_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            if (loginInput.Text == "" || passInput.Text == "")
            {
                MessageBox.Show("Senha ou login estão incorretos");
            }
            else
            {
               
                /*Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where email='" + loginInput.Text + "' and password='" + passInput.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                /*if (dt.Rows[0][0].ToString() == "1") { 
                    UserDetails.Username = dt.Rows[0][2].ToString();
                    MainMenu obj = new MainMenu();
                    obj.Show();
                    this.Hide();
                    Con.Close();
                }*/


                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = new SqlCommand("SELECT name FROM AccountTbl WHERE email=@email and password=@pass", conn);
                //SqlCommand commandEmail = new SqlCommand("SELECT email FROM AccountTbl WHERE email=@email and password=@pass", conn);

                command.Parameters.AddWithValue("@email", loginInput.Text);
                command.Parameters.AddWithValue("@pass", passInput.Text);

                /*commandEmail.Parameters.AddWithValue("@email", loginInput.Text);
                commandEmail.Parameters.AddWithValue("@pass", passInput.Text);*/

                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserDetails.Username = reader.GetValue(0).ToString();
                        MainMenu obj = new MainMenu();
                        obj.Show();
                        this.Hide();
                        conn.Close();
                    }
                }

                /*using (SqlDataReader reader = commandEmail.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserDetails.Useremail = reader.GetValue(1).ToString();
                    }
                }*/



            }

        }
    }
}
