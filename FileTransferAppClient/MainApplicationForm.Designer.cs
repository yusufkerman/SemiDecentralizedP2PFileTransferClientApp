namespace FileTransferAppClient
{
    partial class MainApplicationForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplicationForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.activeUsersPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedFileNameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userInfoIpAddress = new System.Windows.Forms.Label();
            this.userInfoUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.activeUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeUserPageLabel = new System.Windows.Forms.Label();
            this.refreshActiveUsersButton = new System.Windows.Forms.Button();
            this.activeUsersPageRigth = new System.Windows.Forms.Button();
            this.activeUsersPageLeft = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.activeUsersPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.activeUsersPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(105, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // activeUsersPage
            // 
            this.activeUsersPage.BackColor = System.Drawing.Color.White;
            this.activeUsersPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activeUsersPage.Controls.Add(this.panel1);
            this.activeUsersPage.Controls.Add(this.activeUsersDataGridView);
            this.activeUsersPage.Controls.Add(this.activeUserPageLabel);
            this.activeUsersPage.Controls.Add(this.refreshActiveUsersButton);
            this.activeUsersPage.Controls.Add(this.activeUsersPageRigth);
            this.activeUsersPage.Controls.Add(this.activeUsersPageLeft);
            this.activeUsersPage.Location = new System.Drawing.Point(4, 34);
            this.activeUsersPage.Name = "activeUsersPage";
            this.activeUsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.activeUsersPage.Size = new System.Drawing.Size(910, 515);
            this.activeUsersPage.TabIndex = 0;
            this.activeUsersPage.Text = "Aktif Kullanıcıları Keşfet";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.selectedFileNameLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.userInfoIpAddress);
            this.panel1.Controls.Add(this.userInfoUserName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(486, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 435);
            this.panel1.TabIndex = 9;
            // 
            // selectedFileNameLabel
            // 
            this.selectedFileNameLabel.AutoSize = true;
            this.selectedFileNameLabel.Font = new System.Drawing.Font("Roboto Condensed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedFileNameLabel.ForeColor = System.Drawing.Color.White;
            this.selectedFileNameLabel.Location = new System.Drawing.Point(231, 344);
            this.selectedFileNameLabel.Name = "selectedFileNameLabel";
            this.selectedFileNameLabel.Size = new System.Drawing.Size(132, 23);
            this.selectedFileNameLabel.TabIndex = 16;
            this.selectedFileNameLabel.Text = "dosya seçilmedi";
            this.selectedFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(16, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnFileSelectionButtonClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(16, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "İsteği Gönder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userInfoIpAddress
            // 
            this.userInfoIpAddress.AutoSize = true;
            this.userInfoIpAddress.Font = new System.Drawing.Font("Roboto Condensed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userInfoIpAddress.ForeColor = System.Drawing.Color.White;
            this.userInfoIpAddress.Location = new System.Drawing.Point(15, 105);
            this.userInfoIpAddress.Name = "userInfoIpAddress";
            this.userInfoIpAddress.Size = new System.Drawing.Size(167, 23);
            this.userInfoIpAddress.TabIndex = 13;
            this.userInfoIpAddress.Text = "IP Adresi : Seçilmedi";
            this.userInfoIpAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userInfoUserName
            // 
            this.userInfoUserName.AutoSize = true;
            this.userInfoUserName.Font = new System.Drawing.Font("Roboto Condensed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userInfoUserName.ForeColor = System.Drawing.Color.White;
            this.userInfoUserName.Location = new System.Drawing.Point(15, 72);
            this.userInfoUserName.Name = "userInfoUserName";
            this.userInfoUserName.Size = new System.Drawing.Size(194, 23);
            this.userInfoUserName.TabIndex = 12;
            this.userInfoUserName.Text = "Kullanıcı Adı : Seçilmedi";
            this.userInfoUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(19, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 5);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seçilen Kullanıcının Bilgileri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activeUsersDataGridView
            // 
            this.activeUsersDataGridView.AllowUserToAddRows = false;
            this.activeUsersDataGridView.AllowUserToDeleteRows = false;
            this.activeUsersDataGridView.AllowUserToResizeColumns = false;
            this.activeUsersDataGridView.AllowUserToResizeRows = false;
            this.activeUsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeUsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activeUsersDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeUsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.activeUsersDataGridView.ColumnHeadersHeight = 40;
            this.activeUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.activeUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activeUsersDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.activeUsersDataGridView.Location = new System.Drawing.Point(8, 68);
            this.activeUsersDataGridView.MultiSelect = false;
            this.activeUsersDataGridView.Name = "activeUsersDataGridView";
            this.activeUsersDataGridView.ReadOnly = true;
            this.activeUsersDataGridView.RowHeadersWidth = 51;
            this.activeUsersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.activeUsersDataGridView.RowTemplate.Height = 70;
            this.activeUsersDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activeUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeUsersDataGridView.Size = new System.Drawing.Size(472, 435);
            this.activeUsersDataGridView.TabIndex = 4;
            this.activeUsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnActiveUserSelected);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kullanıcı Adı";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ip Adresi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // activeUserPageLabel
            // 
            this.activeUserPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeUserPageLabel.AutoSize = true;
            this.activeUserPageLabel.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.activeUserPageLabel.ForeColor = System.Drawing.Color.Black;
            this.activeUserPageLabel.Location = new System.Drawing.Point(393, 21);
            this.activeUserPageLabel.Name = "activeUserPageLabel";
            this.activeUserPageLabel.Size = new System.Drawing.Size(25, 29);
            this.activeUserPageLabel.TabIndex = 8;
            this.activeUserPageLabel.Text = "1";
            this.activeUserPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshActiveUsersButton
            // 
            this.refreshActiveUsersButton.BackColor = System.Drawing.Color.White;
            this.refreshActiveUsersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshActiveUsersButton.BackgroundImage")));
            this.refreshActiveUsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshActiveUsersButton.FlatAppearance.BorderSize = 0;
            this.refreshActiveUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshActiveUsersButton.Location = new System.Drawing.Point(8, 7);
            this.refreshActiveUsersButton.Name = "refreshActiveUsersButton";
            this.refreshActiveUsersButton.Size = new System.Drawing.Size(60, 60);
            this.refreshActiveUsersButton.TabIndex = 5;
            this.refreshActiveUsersButton.UseVisualStyleBackColor = false;
            this.refreshActiveUsersButton.Click += new System.EventHandler(this.OnActiveUserRefreshButtonClicked);
            // 
            // activeUsersPageRigth
            // 
            this.activeUsersPageRigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeUsersPageRigth.BackColor = System.Drawing.Color.White;
            this.activeUsersPageRigth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("activeUsersPageRigth.BackgroundImage")));
            this.activeUsersPageRigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.activeUsersPageRigth.FlatAppearance.BorderSize = 0;
            this.activeUsersPageRigth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeUsersPageRigth.Location = new System.Drawing.Point(420, 6);
            this.activeUsersPageRigth.Name = "activeUsersPageRigth";
            this.activeUsersPageRigth.Size = new System.Drawing.Size(60, 60);
            this.activeUsersPageRigth.TabIndex = 6;
            this.activeUsersPageRigth.UseVisualStyleBackColor = false;
            // 
            // activeUsersPageLeft
            // 
            this.activeUsersPageLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeUsersPageLeft.BackColor = System.Drawing.Color.White;
            this.activeUsersPageLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("activeUsersPageLeft.BackgroundImage")));
            this.activeUsersPageLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.activeUsersPageLeft.FlatAppearance.BorderSize = 0;
            this.activeUsersPageLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeUsersPageLeft.Location = new System.Drawing.Point(330, 6);
            this.activeUsersPageLeft.Name = "activeUsersPageLeft";
            this.activeUsersPageLeft.Size = new System.Drawing.Size(60, 60);
            this.activeUsersPageLeft.TabIndex = 7;
            this.activeUsersPageLeft.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dosya Gönderme İstekleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(910, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dosya Transfer Geçmişi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IpAddress
            // 
            this.IpAddress.FillWeight = 77.00535F;
            this.IpAddress.HeaderText = "Ip Address";
            this.IpAddress.MinimumWidth = 15;
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.ReadOnly = true;
            this.IpAddress.Width = 125;
            // 
            // UserName
            // 
            this.UserName.FillWeight = 122.9946F;
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 115;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSelectionDialog
            // 
            this.fileSelectionDialog.FileName = "openFileDialog1";
            this.fileSelectionDialog.Multiselect = true;
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 553);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainApplicationForm";
            this.Text = "P2P File Transfer";
            this.tabControl1.ResumeLayout(false);
            this.activeUsersPage.ResumeLayout(false);
            this.activeUsersPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage activeUsersPage;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView activeUsersDataGridView;
        private System.Windows.Forms.Label activeUserPageLabel;
        private System.Windows.Forms.Button refreshActiveUsersButton;
        private System.Windows.Forms.Button activeUsersPageRigth;
        private System.Windows.Forms.Button activeUsersPageLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userInfoIpAddress;
        private System.Windows.Forms.Label userInfoUserName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog fileSelectionDialog;
        private System.Windows.Forms.Label selectedFileNameLabel;
    }
}

