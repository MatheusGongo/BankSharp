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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AcPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AcCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnForm_Click(object sender, EventArgs e)
        {

            if(AcAddress.Text == "" || AcBirthday.Text == "" || AcCep.Text == "" || AcName.Text == "" || AcPass.Text == "" || AcPhone.Text == "" || AcEmail.Text == "" || AcCpf.Text == "")
            {
                MessageBox.Show("Preencha todas os campos");
            } else
            {
                try{
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AccountTbl(name,cpf,birthday,cep,address,email,phone,password)values(@name,@cpf,@birthday,@cep,@address,@email,@phone,@password)", Con);
                    cmd.Parameters.AddWithValue("@name", AcName.Text);
                    cmd.Parameters.AddWithValue("@cpf", AcCpf.Text);
                    cmd.Parameters.AddWithValue("@birthday", AcBirthday.Text);
                    cmd.Parameters.AddWithValue("@cep", AcCep.Text);
                    cmd.Parameters.AddWithValue("@address", AcAddress.Text);
                    cmd.Parameters.AddWithValue("@email", AcEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", AcPhone.Text);
                    cmd.Parameters.AddWithValue("@password", AcPass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conta criada com sucesso :D");
                    Con.Close();
                    NewClient obj = new NewClient();
                    obj.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
