namespace BankSharp
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.codeBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.saldoConta = new Guna.UI2.WinForms.Guna2RadioButton();
            this.saldoCartao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm_payment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Pagar contas";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(572, 56);
            this.guna2Panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Digite o número do código de barras para poder pagar a sua conta.";
            // 
            // codeBar
            // 
            this.codeBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBar.DefaultText = "";
            this.codeBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeBar.DisabledState.Parent = this.codeBar;
            this.codeBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeBar.FocusedState.Parent = this.codeBar;
            this.codeBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeBar.HoverState.Parent = this.codeBar;
            this.codeBar.Location = new System.Drawing.Point(40, 118);
            this.codeBar.Name = "codeBar";
            this.codeBar.PasswordChar = '\0';
            this.codeBar.PlaceholderText = "";
            this.codeBar.SelectedText = "";
            this.codeBar.ShadowDecoration.Parent = this.codeBar;
            this.codeBar.Size = new System.Drawing.Size(470, 34);
            this.codeBar.TabIndex = 40;
            // 
            // saldoConta
            // 
            this.saldoConta.AutoSize = true;
            this.saldoConta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saldoConta.CheckedState.BorderThickness = 0;
            this.saldoConta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saldoConta.CheckedState.InnerColor = System.Drawing.Color.White;
            this.saldoConta.CheckedState.InnerOffset = -4;
            this.saldoConta.Location = new System.Drawing.Point(39, 306);
            this.saldoConta.Name = "saldoConta";
            this.saldoConta.Size = new System.Drawing.Size(97, 17);
            this.saldoConta.TabIndex = 41;
            this.saldoConta.Text = "Saldo da conta";
            this.saldoConta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.saldoConta.UncheckedState.BorderThickness = 2;
            this.saldoConta.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.saldoConta.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // saldoCartao
            // 
            this.saldoCartao.AutoSize = true;
            this.saldoCartao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saldoCartao.CheckedState.BorderThickness = 0;
            this.saldoCartao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saldoCartao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.saldoCartao.CheckedState.InnerOffset = -4;
            this.saldoCartao.Location = new System.Drawing.Point(189, 306);
            this.saldoCartao.Name = "saldoCartao";
            this.saldoCartao.Size = new System.Drawing.Size(100, 17);
            this.saldoCartao.TabIndex = 42;
            this.saldoCartao.Text = "Saldo do cartão";
            this.saldoCartao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.saldoCartao.UncheckedState.BorderThickness = 2;
            this.saldoCartao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.saldoCartao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 45;
            this.label4.Text = "R$ 8.000,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Escolha a forma de pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Valor da fatura:";
            // 
            // confirm_payment
            // 
            this.confirm_payment.CheckedState.Parent = this.confirm_payment;
            this.confirm_payment.CustomImages.Parent = this.confirm_payment;
            this.confirm_payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirm_payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirm_payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirm_payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirm_payment.DisabledState.Parent = this.confirm_payment;
            this.confirm_payment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.confirm_payment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_payment.ForeColor = System.Drawing.Color.White;
            this.confirm_payment.HoverState.Parent = this.confirm_payment;
            this.confirm_payment.Location = new System.Drawing.Point(189, 368);
            this.confirm_payment.Name = "confirm_payment";
            this.confirm_payment.ShadowDecoration.Parent = this.confirm_payment;
            this.confirm_payment.Size = new System.Drawing.Size(180, 45);
            this.confirm_payment.TabIndex = 48;
            this.confirm_payment.Text = "Pagar";
            this.confirm_payment.Click += new System.EventHandler(this.confirm_payment_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 451);
            this.Controls.Add(this.confirm_payment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldoCartao);
            this.Controls.Add(this.saldoConta);
            this.Controls.Add(this.codeBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox codeBar;
        private Guna.UI2.WinForms.Guna2RadioButton saldoConta;
        private Guna.UI2.WinForms.Guna2RadioButton saldoCartao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button confirm_payment;
    }
}