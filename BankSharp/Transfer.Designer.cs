namespace BankSharp
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.toMain = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTransfer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueTransfer = new Guna.UI2.WinForms.Guna2TextBox();
            this.check_transfer = new Guna.UI2.WinForms.Guna2Button();
            this.verifyAccount = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTransfer = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.guna2Panel1.Controls.Add(this.toMain);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(597, 56);
            this.guna2Panel1.TabIndex = 50;
            // 
            // toMain
            // 
            this.toMain.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.toMain.CheckedState.Parent = this.toMain;
            this.toMain.HoverState.Parent = this.toMain;
            this.toMain.Image = ((System.Drawing.Image)(resources.GetObject("toMain.Image")));
            this.toMain.ImageOffset = new System.Drawing.Point(0, 0);
            this.toMain.ImageRotate = 0F;
            this.toMain.ImageSize = new System.Drawing.Size(20, 20);
            this.toMain.Location = new System.Drawing.Point(14, 3);
            this.toMain.Name = "toMain";
            this.toMain.PressedState.Parent = this.toMain;
            this.toMain.ShadowDecoration.Parent = this.toMain;
            this.toMain.Size = new System.Drawing.Size(37, 54);
            this.toMain.TabIndex = 38;
            this.toMain.Click += new System.EventHandler(this.toMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Transferência";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Quanto deseja transferir?";
            // 
            // textTransfer
            // 
            this.textTransfer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTransfer.DefaultText = "";
            this.textTransfer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTransfer.DisabledState.Parent = this.textTransfer;
            this.textTransfer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTransfer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTransfer.FocusedState.Parent = this.textTransfer;
            this.textTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTransfer.ForeColor = System.Drawing.Color.Black;
            this.textTransfer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTransfer.HoverState.Parent = this.textTransfer;
            this.textTransfer.Location = new System.Drawing.Point(32, 115);
            this.textTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTransfer.Name = "textTransfer";
            this.textTransfer.PasswordChar = '\0';
            this.textTransfer.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textTransfer.PlaceholderText = "";
            this.textTransfer.SelectedText = "";
            this.textTransfer.ShadowDecoration.Parent = this.textTransfer;
            this.textTransfer.Size = new System.Drawing.Size(391, 45);
            this.textTransfer.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Insira o número da conta bancária que você deseja realizar a transferência.";
            // 
            // valueTransfer
            // 
            this.valueTransfer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valueTransfer.DefaultText = "";
            this.valueTransfer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.valueTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.valueTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.valueTransfer.DisabledState.Parent = this.valueTransfer;
            this.valueTransfer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.valueTransfer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.valueTransfer.FocusedState.Parent = this.valueTransfer;
            this.valueTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTransfer.ForeColor = System.Drawing.Color.Black;
            this.valueTransfer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.valueTransfer.HoverState.Parent = this.valueTransfer;
            this.valueTransfer.Location = new System.Drawing.Point(31, 331);
            this.valueTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueTransfer.Name = "valueTransfer";
            this.valueTransfer.PasswordChar = '\0';
            this.valueTransfer.PlaceholderForeColor = System.Drawing.Color.Black;
            this.valueTransfer.PlaceholderText = "";
            this.valueTransfer.SelectedText = "";
            this.valueTransfer.ShadowDecoration.Parent = this.valueTransfer;
            this.valueTransfer.Size = new System.Drawing.Size(226, 45);
            this.valueTransfer.TabIndex = 55;
            // 
            // check_transfer
            // 
            this.check_transfer.CheckedState.Parent = this.check_transfer;
            this.check_transfer.CustomImages.Parent = this.check_transfer;
            this.check_transfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.check_transfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.check_transfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.check_transfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.check_transfer.DisabledState.Parent = this.check_transfer;
            this.check_transfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.check_transfer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_transfer.ForeColor = System.Drawing.Color.White;
            this.check_transfer.HoverState.Parent = this.check_transfer;
            this.check_transfer.Location = new System.Drawing.Point(208, 441);
            this.check_transfer.Name = "check_transfer";
            this.check_transfer.ShadowDecoration.Parent = this.check_transfer;
            this.check_transfer.Size = new System.Drawing.Size(180, 45);
            this.check_transfer.TabIndex = 56;
            this.check_transfer.Text = "Transferir";
            this.check_transfer.Click += new System.EventHandler(this.check_transfer_Click);
            // 
            // verifyAccount
            // 
            this.verifyAccount.CheckedState.Parent = this.verifyAccount;
            this.verifyAccount.CustomImages.Parent = this.verifyAccount;
            this.verifyAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verifyAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verifyAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verifyAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verifyAccount.DisabledState.Parent = this.verifyAccount;
            this.verifyAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.verifyAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyAccount.ForeColor = System.Drawing.Color.White;
            this.verifyAccount.HoverState.Parent = this.verifyAccount;
            this.verifyAccount.Location = new System.Drawing.Point(429, 115);
            this.verifyAccount.Name = "verifyAccount";
            this.verifyAccount.ShadowDecoration.Parent = this.verifyAccount;
            this.verifyAccount.Size = new System.Drawing.Size(124, 45);
            this.verifyAccount.TabIndex = 57;
            this.verifyAccount.Text = "Verificar";
            this.verifyAccount.Click += new System.EventHandler(this.verifyAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Transferindo para:";
            // 
            // nameTransfer
            // 
            this.nameTransfer.AutoSize = true;
            this.nameTransfer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTransfer.ForeColor = System.Drawing.Color.Black;
            this.nameTransfer.Location = new System.Drawing.Point(177, 187);
            this.nameTransfer.Name = "nameTransfer";
            this.nameTransfer.Size = new System.Drawing.Size(0, 21);
            this.nameTransfer.TabIndex = 59;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 535);
            this.Controls.Add(this.nameTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verifyAccount);
            this.Controls.Add(this.check_transfer);
            this.Controls.Add(this.valueTransfer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTransfer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textTransfer;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox valueTransfer;
        private Guna.UI2.WinForms.Guna2Button check_transfer;
        private Guna.UI2.WinForms.Guna2Button verifyAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameTransfer;
        private Guna.UI2.WinForms.Guna2ImageButton toMain;
    }
}