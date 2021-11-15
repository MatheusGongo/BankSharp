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
    public partial class AddBalance : Form
    {
        public AddBalance()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");


        private void toMain_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void confirm_payment_Click(object sender, EventArgs e)
        {
            if (addValue.Text != "")
            {
                SuccessAddBalance obj = new SuccessAddBalance();

                Con.Open();
                SqlCommand cmd = new SqlCommand("Update BankAccountTbl SET balance=@newBalance WHERE IdUser=@idUser", Con);
                var resultSaldo = Convert.ToDecimal(addValue.Text) + Convert.ToDecimal(UserDetails.Saldo);
                cmd.Parameters.AddWithValue("@newBalance", Convert.ToDecimal(resultSaldo));
                cmd.Parameters.AddWithValue("@idUser", UserDetails.UserId);
                cmd.ExecuteNonQuery();
                UserDetails.Saldo = resultSaldo.ToString();
                Con.Close();
                obj.Show();
                this.Hide();
                    
            } else
            {
                MessageBox.Show("Digite o valor no campo.");
            }

        }
    }
}
