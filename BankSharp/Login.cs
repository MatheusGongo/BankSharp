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
               
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where email='" + loginInput.Text + "' and password='" + passInput.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserDetails.Username = "asdgasdgasdg";
                    MainMenu obj = new MainMenu();
                    obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Senha ou login errados");
                    loginInput.Text = "";
                    passInput.Text = "";
                }
                Con.Close();

            }

        }
    }
}
