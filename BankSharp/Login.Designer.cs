namespace BankSharp
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.Entrar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_account = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 412);
            this.panel1.TabIndex = 0;
            // 
            // loginInput
            // 
            this.loginInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInput.ForeColor = System.Drawing.Color.Black;
            this.loginInput.Location = new System.Drawing.Point(176, 137);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(283, 35);
            this.loginInput.TabIndex = 4;
            this.loginInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // passInput
            // 
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.ForeColor = System.Drawing.Color.Black;
            this.passInput.Location = new System.Drawing.Point(176, 230);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(283, 35);
            this.passInput.TabIndex = 5;
            this.passInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Entrar
            // 
            this.Entrar.CheckedState.Parent = this.Entrar;
            this.Entrar.CustomImages.Parent = this.Entrar;
            this.Entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Entrar.DisabledState.Parent = this.Entrar;
            this.Entrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.Entrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.ForeColor = System.Drawing.Color.White;
            this.Entrar.HoverState.Parent = this.Entrar;
            this.Entrar.Location = new System.Drawing.Point(176, 326);
            this.Entrar.Name = "Entrar";
            this.Entrar.ShadowDecoration.Parent = this.Entrar;
            this.Entrar.Size = new System.Drawing.Size(283, 45);
            this.Entrar.TabIndex = 6;
            this.Entrar.Text = "Entrar";
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seja bem vindo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // create_account
            // 
            this.create_account.CheckedState.Parent = this.create_account;
            this.create_account.CustomImages.Parent = this.create_account;
            this.create_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.create_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.create_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.create_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.create_account.DisabledState.Parent = this.create_account;
            this.create_account.FillColor = System.Drawing.Color.White;
            this.create_account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.create_account.ForeColor = System.Drawing.Color.RoyalBlue;
            this.create_account.HoverState.FillColor = System.Drawing.Color.White;
            this.create_account.HoverState.Parent = this.create_account;
            this.create_account.Location = new System.Drawing.Point(281, 288);
            this.create_account.Name = "create_account";
            this.create_account.PressedColor = System.Drawing.Color.RoyalBlue;
            this.create_account.ShadowDecoration.Parent = this.create_account;
            this.create_account.Size = new System.Drawing.Size(173, 24);
            this.create_account.TabIndex = 10;
            this.create_account.Text = "Cadastre-se agora mesmo.";
            this.create_account.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.create_account.Click += new System.EventHandler(this.create_account_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Não possui conta? ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.create_account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passInput;
        private Guna.UI2.WinForms.Guna2Button Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button create_account;
        private System.Windows.Forms.Label label4;
    }
}