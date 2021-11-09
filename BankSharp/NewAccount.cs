using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSharp
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matheus.souza\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AcCep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
