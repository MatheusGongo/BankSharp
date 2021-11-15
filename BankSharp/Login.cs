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
            passInput.PasswordChar = '*';

        }



        private void create_account_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
            this.Hide();
        }


        private void Entrar_Click(object sender, EventArgs e)
        {

            if (loginInput.Text == "" || passInput.Text == "")
            {
                MessageBox.Show("Senha ou login estão incorretos");
            }
            else
            {
              
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = new SqlCommand("SELECT A.name,A.email,B.number_account,B.balance,B.credit_card,A.IdUser FROM AccountTbl A JOIN BankAccountTbl B ON B.idUser = A.idUser WHERE A.email=@email and A.password=@pass", conn);

                command.Parameters.AddWithValue("@email", loginInput.Text);
                command.Parameters.AddWithValue("@pass", passInput.Text);

                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserDetails.Username = reader.GetValue(0).ToString();
                        UserDetails.Email = reader.GetValue(1).ToString();
                        UserDetails.NumberAccount = reader.GetValue(2).ToString();
                        UserDetails.Saldo = reader.GetValue(3).ToString();
                        UserDetails.Cardsaldo = reader.GetValue(4).ToString();
                        UserDetails.UserId = reader.GetValue(5).ToString();
                        MainMenu obj = new MainMenu();
                        obj.Show();
                        this.Hide();
                        conn.Close();
                    } else
                    {
                        MessageBox.Show("Senha ou login estão incorretos");
                    }
                }

            }

        }
    }
}
