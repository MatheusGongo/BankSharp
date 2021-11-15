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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");

        private void confirm_payment_Click(object sender, EventArgs e)
        {
            if(codeBar.Text != "")
            {
                if (saldoConta.Checked)
                {
                    if (Convert.ToDecimal(UserDetails.Saldo) > Convert.ToDecimal(UserDetails.CompanyPrice))
                    {
                        SuccessPayment obj = new SuccessPayment();
                        var resultSaldo = Convert.ToDecimal(UserDetails.Saldo) - Convert.ToDecimal(UserDetails.CompanyPrice);

                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update BankAccountTbl SET balance=@newBalance WHERE IdUser=@idUser", Con);
                        cmd.Parameters.AddWithValue("@newBalance", Convert.ToDecimal(resultSaldo));
                        cmd.Parameters.AddWithValue("@idUser", UserDetails.UserId);
                        cmd.ExecuteNonQuery();
                        UserDetails.Saldo = resultSaldo.ToString();
                        UserDetails.TypePayment = "Boleto";
                        Con.Close();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente. Escolha outra forma de pagamento ou adicione mais dinheiro em sua conta.");
                    }
                }
                else if (saldoCartao.Checked)
                {
                    if (Convert.ToDecimal(UserDetails.Cardsaldo) > Convert.ToDecimal(UserDetails.CompanyPrice)){
                        SuccessPayment obj = new SuccessPayment();
                        var resultSaldo = Convert.ToDecimal(UserDetails.Cardsaldo) - Convert.ToDecimal(UserDetails.CompanyPrice);

                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update BankAccountTbl SET credit_card=@newCardsaldo WHERE IdUser=@idUser", Con);
                        cmd.Parameters.AddWithValue("@newCardsaldo", Convert.ToDecimal(resultSaldo));
                        cmd.Parameters.AddWithValue("@idUser", UserDetails.UserId);
                        cmd.ExecuteNonQuery();
                        UserDetails.Cardsaldo = resultSaldo.ToString();
                        UserDetails.TypePayment = "Boleto";
                        Con.Close();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Crédito insuficiente.");
                    }
                }
                else
                {
                    MessageBox.Show("Escolha sua forma de pagamento");
                }

                UserDetails.TypePayment = "Boleto";

            }
            
           
        }

        private void verifyCode_Click(object sender, EventArgs e)
        {
            int min = 100;
            int max = 600;
            Random rdm = new Random();

            if (codeBar.Text != "")
            {
                var isPay = rdm.Next(min, max);
                if (isPay < 200 )
                {
                    var company = "Conta de água";
                    var valuePay = Convert.ToDecimal(isPay);
                    toPay.Text = "R$ " + valuePay.ToString("0.00");
                    UserDetails.CompanyPrice = valuePay.ToString("0.00");
                    UserDetails.Company = company;
                }

                if (isPay > 200)
                {
                    var company = "Conta de luz";
                    var valuePay = Convert.ToDecimal(isPay);
                    toPay.Text = "R$ " + valuePay.ToString("0.00");
                    UserDetails.CompanyPrice = valuePay.ToString("0.00");
                    UserDetails.Company = company;
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
