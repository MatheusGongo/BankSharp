﻿using System;
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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startP = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;

            Myprogressbar.Value = startP;
            if(Myprogressbar.Value == 100)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
        }
    }
}
