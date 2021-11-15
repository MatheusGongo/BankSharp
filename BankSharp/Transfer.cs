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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void check_transfer_Click(object sender, EventArgs e)
        {
            if (textTransfer.Text != "" && valueTransfer.Text != "")
            {
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");


                Con.Open();


                if (Convert.ToDecimal(UserDetails.Saldo) > Convert.ToDecimal(valueTransfer.Text))
                {
                    var anotherAccount = Convert.ToDecimal(UserDetails.MyTransfer) + Convert.ToDecimal(valueTransfer.Text);

                    SqlCommand cmd3 = new SqlCommand("Update BankAccountTbl SET balance=@newBalance WHERE number_account=@number_account", Con);

                    cmd3.Parameters.AddWithValue("@newBalance", anotherAccount);
                    cmd3.Parameters.AddWithValue("@number_account", textTransfer.Text);
                    cmd3.ExecuteNonQuery();


                    var myBalance = Convert.ToDecimal(UserDetails.Saldo) - Convert.ToDecimal(valueTransfer.Text);
                    SqlCommand cmd2 = new SqlCommand("Update BankAccountTbl SET balance=@newBalance WHERE idUser=@idUser", Con);
                    cmd2.Parameters.AddWithValue("@newBalance", myBalance);
                    cmd2.Parameters.AddWithValue("@idUser", UserDetails.UserId);
                    cmd2.ExecuteNonQuery();

                    UserDetails.Saldo = myBalance.ToString();
                    SuccessTransfer obj = new SuccessTransfer();
                    Con.Close();
                    obj.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Seu saldo está insuficiente para essa transferência.");
                }
                
            }
        }

        private void verifyAccount_Click(object sender, EventArgs e)
        {
            if (textTransfer.Text != "")
            {
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand com = new SqlCommand("SELECT A.name,B.number_account,B.balance,A.IdUser FROM AccountTbl A JOIN BankAccountTbl B ON B.idUser = A.idUser WHERE B.number_account=@number_account", Con);
                com.Parameters.AddWithValue("@number_account", textTransfer.Text);

                Con.Open();

                using (SqlDataReader rdr = com.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        UserDetails.MyTransfer = rdr.GetValue(2).ToString();
                        nameTransfer.Text = rdr.GetValue(0).ToString();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Conta não encontrada.");
                    }
                }




            }
        }

        private void toMain_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
    }
}
