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
    public partial class SuccessAddBalance : Form
    {
        public SuccessAddBalance()
        {
            InitializeComponent();

           
        }

        private void main_page_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okumu\OneDrive\Documents\BankSharp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT balance FROM BankAccountTbl WHERE idUser = @userId", conn);
            command.Parameters.AddWithValue("@userId", UserDetails.UserId);
            conn.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    MainMenu obj = new MainMenu();
                    conn.Close();
                    obj.Show();
                    this.Hide();
                }
            }
            
          
        }
    }
}
