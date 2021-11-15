using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;



namespace BankSharp
{
    public partial class SuccessPayment : Form
    {
        public SuccessPayment()
        {
            InitializeComponent();

            var csvPath = "C:\\Users\\okumu\\OneDrive\\Documents\\csv_files\\extratos.csv";

            if (!File.Exists(csvPath))
            {
                var listExtrato = new List<modelExtrato>();
                listExtrato.Add(new modelExtrato() { Tipo = UserDetails.TypePayment, Favorecido = UserDetails.Company, Valor = UserDetails.CompanyPrice });

                var writer = new StreamWriter(csvPath);
                var csvwrite = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csvwrite.NextRecord();
                csvwrite.WriteRecords(listExtrato);
                csvwrite.Dispose();
                writer.Dispose();

                var reader = new StreamReader(csvPath);
                var csvreader = new CsvReader(reader, CultureInfo.InvariantCulture);

                var output = csvreader.GetRecords<modelExtrato>();
            } else
            {

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };

                var listExtrato = new List<modelExtrato>();
                listExtrato.Add(new modelExtrato() { Tipo = UserDetails.TypePayment, Favorecido = UserDetails.Company, Valor = UserDetails.CompanyPrice });

                using (var stream = new FileStream(csvPath, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csvWriter = new CsvWriter(writer, config))
                {
                    csvWriter.WriteRecords(listExtrato);
                }
            }
        }

        private void main_page_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        class modelExtrato
        {
            public string Tipo { get; set;}
            public string Favorecido{ get; set;}
            public string Valor { get; set;}
        }
    }
}
