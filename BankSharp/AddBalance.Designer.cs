namespace BankSharp
{
    partial class AddBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBalance));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.toMain = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.addValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirm_payment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(36, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Digite o valor que deseja adicionar em sua conta.";
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
            this.guna2Panel1.Size = new System.Drawing.Size(453, 56);
            this.guna2Panel1.TabIndex = 50;
            // 
            // toMain
            // 
            this.toMain.CheckedState.Parent = this.toMain;
            this.toMain.HoverState.ImageSize = new System.Drawing.Size(19, 19);
            this.toMain.HoverState.Parent = this.toMain;
            this.toMain.Image = ((System.Drawing.Image)(resources.GetObject("toMain.Image")));
            this.toMain.ImageOffset = new System.Drawing.Point(0, 0);
            this.toMain.ImageRotate = 0F;
            this.toMain.ImageSize = new System.Drawing.Size(20, 20);
            this.toMain.Location = new System.Drawing.Point(28, 19);
            this.toMain.Name = "toMain";
            this.toMain.PressedState.ImageSize = new System.Drawing.Size(19, 19);
            this.toMain.PressedState.Parent = this.toMain;
            this.toMain.ShadowDecoration.Parent = this.toMain;
            this.toMain.Size = new System.Drawing.Size(20, 20);
            this.toMain.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(73)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Adicionar Dinheiro";
            // 
            // addValue
            // 
            this.addValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addValue.DefaultText = "";
            this.addValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addValue.DisabledState.Parent = this.addValue;
            this.addValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addValue.FocusedState.Parent = this.addValue;
            this.addValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addValue.ForeColor = System.Drawing.Color.Black;
            this.addValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addValue.HoverState.Parent = this.addValue;
            this.addValue.Location = new System.Drawing.Point(40, 137);
            this.addValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addValue.Name = "addValue";
            this.addValue.PasswordChar = '\0';
            this.addValue.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addValue.PlaceholderText = "";
            this.addValue.SelectedText = "";
            this.addValue.ShadowDecoration.Parent = this.addValue;
            this.addValue.Size = new System.Drawing.Size(344, 45);
            this.addValue.TabIndex = 52;
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
            this.confirm_payment.Location = new System.Drawing.Point(40, 209);
            this.confirm_payment.Name = "confirm_payment";
            this.confirm_payment.ShadowDecoration.Parent = this.confirm_payment;
            this.confirm_payment.Size = new System.Drawing.Size(344, 45);
            this.confirm_payment.TabIndex = 54;
            this.confirm_payment.Text = "Adicionar";
            this.confirm_payment.Click += new System.EventHandler(this.confirm_payment_Click);
            // 
            // AddBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.addValue);
            this.Controls.Add(this.confirm_payment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton toMain;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox addValue;
        private Guna.UI2.WinForms.Guna2Button confirm_payment;
    }
}