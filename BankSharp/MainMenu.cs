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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            balance.Text = "R$ " + UserDetails.Saldo.ToString();
            creditSaldo.Text = "R$ " + UserDetails.Cardsaldo.ToString();
            welcomeText.Text = "Olá, " + UserDetails.Username + " :D";

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            AddBalance obj = new AddBalance();
            obj.Show();
            this.Hide();
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void to_payment_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
            this.Hide();
        }

        private void to_transfer_Click(object sender, EventArgs e)
        {
            Transfer obj = new Transfer();
            obj.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
