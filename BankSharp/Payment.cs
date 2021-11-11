using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSharp
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void confirm_payment_Click(object sender, EventArgs e)
        {
            if (saldoConta.Checked || saldoCartao.Checked || codeBar.Text != "")
            {
                SuccessPayment obj = new SuccessPayment();
                obj.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Escolha sua forma de pagamento");
            }
           
        }
    }
}
