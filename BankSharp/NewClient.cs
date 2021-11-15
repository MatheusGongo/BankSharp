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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT IdUser FROM AccountTbl WHERE email=@email and password=@pass", conn);

            command.Parameters.AddWithValue("@email", UserDetails.Email);
            command.Parameters.AddWithValue("@pass", UserDetails.Password);

            conn.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    UserDetails.UserId = reader.GetValue(0).ToString();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Senha ou login estão incorretos");
                }
            }

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bankAccount_Click(object sender, EventArgs e)
        {

                int min = 100000000;
                int max = 900000000;
                Random rnd = new Random();
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into BankAccountTbl(balance,credit_card,number_account,idUser)values(@balance,@credit_card,@number_account,@idUser)", Con);
                cmd.Parameters.AddWithValue("@balance", 8000);
                cmd.Parameters.AddWithValue("@credit_card", 1000);
                cmd.Parameters.AddWithValue("@number_account", rnd.Next(min, max).ToString());
                cmd.Parameters.AddWithValue("@idUser", UserDetails.UserId);
                cmd.ExecuteNonQuery();
                Login obj = new Login();
                obj.Show();
                this.Hide();
                Con.Close();


            

        }
    }
}
