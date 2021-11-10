namespace BankSharp
{
    partial class NewAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AcName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AcBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.AcCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AcCep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AcAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AcEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AcPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AcPass = new System.Windows.Forms.TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnForm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(96, 600);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nova conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(141, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Abra a sua conta para poder usufruir dos recursos e promoções do BankSharp.";
            // 
            // AcName
            // 
            this.AcName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcName.Location = new System.Drawing.Point(144, 147);
            this.AcName.Name = "AcName";
            this.AcName.Size = new System.Drawing.Size(592, 29);
            this.AcName.TabIndex = 36;
            this.AcName.TextChanged += new System.EventHandler(this.AcName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data de nascimento";
            // 
            // AcBirthday
            // 
            this.AcBirthday.Checked = true;
            this.AcBirthday.CheckedState.Parent = this.AcBirthday;
            this.AcBirthday.FillColor = System.Drawing.Color.White;
            this.AcBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AcBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AcBirthday.HoverState.Parent = this.AcBirthday;
            this.AcBirthday.Location = new System.Drawing.Point(418, 221);
            this.AcBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AcBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AcBirthday.Name = "AcBirthday";
            this.AcBirthday.ShadowDecoration.Parent = this.AcBirthday;
            this.AcBirthday.Size = new System.Drawing.Size(259, 29);
            this.AcBirthday.TabIndex = 40;
            this.AcBirthday.Value = new System.DateTime(2021, 11, 7, 19, 51, 17, 894);
            this.AcBirthday.ValueChanged += new System.EventHandler(this.AcBirthday_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "CPF";
            // 
            // AcCpf
            // 
            this.AcCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcCpf.Location = new System.Drawing.Point(144, 222);
            this.AcCpf.Name = "AcCpf";
            this.AcCpf.Size = new System.Drawing.Size(251, 29);
            this.AcCpf.TabIndex = 41;
            this.AcCpf.TextChanged += new System.EventHandler(this.AcCpf_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "CEP";
            // 
            // AcCep
            // 
            this.AcCep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcCep.Location = new System.Drawing.Point(143, 308);
            this.AcCep.Name = "AcCep";
            this.AcCep.Size = new System.Drawing.Size(251, 29);
            this.AcCep.TabIndex = 43;
            this.AcCep.TextChanged += new System.EventHandler(this.AcCep_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Endereço";
            // 
            // AcAddress
            // 
            this.AcAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcAddress.Location = new System.Drawing.Point(416, 308);
            this.AcAddress.Name = "AcAddress";
            this.AcAddress.Size = new System.Drawing.Size(320, 29);
            this.AcAddress.TabIndex = 45;
            this.AcAddress.TextChanged += new System.EventHandler(this.AcAddress_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Email";
            // 
            // AcEmail
            // 
            this.AcEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcEmail.Location = new System.Drawing.Point(143, 384);
            this.AcEmail.Name = "AcEmail";
            this.AcEmail.Size = new System.Drawing.Size(275, 29);
            this.AcEmail.TabIndex = 47;
            this.AcEmail.TextChanged += new System.EventHandler(this.AcEmail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 50;
            this.label9.Text = "Telefone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AcPhone
            // 
            this.AcPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcPhone.Location = new System.Drawing.Point(444, 384);
            this.AcPhone.Name = "AcPhone";
            this.AcPhone.Size = new System.Drawing.Size(292, 29);
            this.AcPhone.TabIndex = 49;
            this.AcPhone.TextChanged += new System.EventHandler(this.AcPhone_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(140, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "Sua senha";
            // 
            // AcPass
            // 
            this.AcPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcPass.Location = new System.Drawing.Point(143, 462);
            this.AcPass.Name = "AcPass";
            this.AcPass.Size = new System.Drawing.Size(275, 29);
            this.AcPass.TabIndex = 51;
            this.AcPass.TextChanged += new System.EventHandler(this.AcPass_TextChanged);
            // 
            // btnForm
            // 
            this.btnForm.CheckedState.Parent = this.btnForm;
            this.btnForm.CustomImages.Parent = this.btnForm;
            this.btnForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnForm.DisabledState.Parent = this.btnForm;
            this.btnForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.btnForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm.ForeColor = System.Drawing.Color.White;
            this.btnForm.HoverState.Parent = this.btnForm;
            this.btnForm.Location = new System.Drawing.Point(351, 527);
            this.btnForm.Name = "btnForm";
            this.btnForm.ShadowDecoration.Parent = this.btnForm;
            this.btnForm.Size = new System.Drawing.Size(180, 45);
            this.btnForm.TabIndex = 53;
            this.btnForm.Text = "Cadastrar";
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AcPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AcPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AcEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AcAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AcCep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AcCpf);
            this.Controls.Add(this.AcBirthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AcName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker AcBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AcCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AcCep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AcAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AcEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AcPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AcPass;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnForm;
    }
}