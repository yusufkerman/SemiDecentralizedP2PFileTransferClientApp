namespace FileTransferAppClient
{
    partial class AuthenticationForm
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
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginUserNameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.authFormTittle = new System.Windows.Forms.Label();
            this.authErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameBox
            // 
            this.userNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameBox.BackColor = System.Drawing.Color.DimGray;
            this.userNameBox.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameBox.ForeColor = System.Drawing.Color.White;
            this.userNameBox.Location = new System.Drawing.Point(355, 217);
            this.userNameBox.MaxLength = 20;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(222, 32);
            this.userNameBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.authErrorLabel);
            this.panel1.Controls.Add(this.authFormTittle);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.loginPasswordLabel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.loginUserNameLabel);
            this.panel1.Controls.Add(this.userNameBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 553);
            this.panel1.TabIndex = 1;
            // 
            // loginUserNameLabel
            // 
            this.loginUserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginUserNameLabel.AutoSize = true;
            this.loginUserNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.loginUserNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginUserNameLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.loginUserNameLabel.Location = new System.Drawing.Point(208, 217);
            this.loginUserNameLabel.Name = "loginUserNameLabel";
            this.loginUserNameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.loginUserNameLabel.Size = new System.Drawing.Size(129, 30);
            this.loginUserNameLabel.TabIndex = 1;
            this.loginUserNameLabel.Text = "Kullanıcı Adı : ";
            this.loginUserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.BackColor = System.Drawing.Color.DimGray;
            this.loginPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.loginPasswordLabel.Location = new System.Drawing.Point(208, 271);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Padding = new System.Windows.Forms.Padding(0, 0, 66, 5);
            this.loginPasswordLabel.Size = new System.Drawing.Size(129, 31);
            this.loginPasswordLabel.TabIndex = 3;
            this.loginPasswordLabel.Text = "Şifre : ";
            this.loginPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.Color.DimGray;
            this.passwordBox.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(355, 271);
            this.passwordBox.MaxLength = 20;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(222, 32);
            this.passwordBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.Color.DimGray;
            this.loginButton.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(208, 348);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(369, 34);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButtonClicked);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.BackColor = System.Drawing.Color.DimGray;
            this.registerButton.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(208, 400);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(369, 34);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Kayıt Ol";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButtonClicked);
            // 
            // authFormTittle
            // 
            this.authFormTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authFormTittle.AutoSize = true;
            this.authFormTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authFormTittle.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authFormTittle.ForeColor = System.Drawing.Color.White;
            this.authFormTittle.Location = new System.Drawing.Point(248, 104);
            this.authFormTittle.Name = "authFormTittle";
            this.authFormTittle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.authFormTittle.Size = new System.Drawing.Size(275, 41);
            this.authFormTittle.TabIndex = 6;
            this.authFormTittle.Text = "GİRİŞ YAP / KAYIT OL";
            this.authFormTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authErrorLabel
            // 
            this.authErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authErrorLabel.AutoSize = true;
            this.authErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authErrorLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.authErrorLabel.Location = new System.Drawing.Point(208, 446);
            this.authErrorLabel.Name = "authErrorLabel";
            this.authErrorLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.authErrorLabel.Size = new System.Drawing.Size(229, 28);
            this.authErrorLabel.TabIndex = 7;
            this.authErrorLabel.Text = "HATA : Hesap bulunamadı !";
            this.authErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AuthenticationForm";
            this.Text = "Giriş Yap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginUserNameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label authFormTittle;
        private System.Windows.Forms.Label authErrorLabel;
    }
}