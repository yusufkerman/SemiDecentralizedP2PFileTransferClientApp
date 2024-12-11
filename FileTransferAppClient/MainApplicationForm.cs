using FileTransferAppClient.Managers;
using MQTTConnectModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FileTransferAppClient
{
    public partial class MainApplicationForm : Form
    {
        private ActiveUsersViewerManager _activeUsersViewerManager;
        public MainApplicationForm()
        {
            InitializeComponent();

            _activeUsersViewerManager = ActiveUsersViewerManager.Instance;
            _activeUsersViewerManager
                .Initialieze(activeUsersDataGridView,activeUserPageLabel);

            _activeUsersViewerManager
                .OnAnyRowSelectedUpdateUserInfos += UpdateSelectedUserInformationTexts;
        }

        private void OnActiveUserRefreshButtonClicked(object sender, EventArgs e)
        {
            _activeUsersViewerManager.UpdateDataGridView();
        }

        private void OnActiveUserSelected(object sender, DataGridViewCellEventArgs e)
        {
            _activeUsersViewerManager.SelectRow(e.RowIndex);
        }
        private void UpdateSelectedUserInformationTexts(string userName,string ipAddress)
        {
            userInfoUserName.Text = "Kullanıcı Adı : " + userName;
            userInfoIpAddress.Text = "IP Adresi : " + ipAddress;
        }

        private void OnFileSelectionButtonClicked(object sender, EventArgs e)
        {
            // OpenFileDialog nesnesini oluştur
            OpenFileDialog openFileDialog = fileSelectionDialog;

            // Dosya seçme penceresinin özelliklerini ayarla
            openFileDialog.Title = "Dosya Seç";
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";

            // Dosya seçildiğinde yapılacak işlem
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyanın yolunu al
                string selectedFilePath = openFileDialog.FileName;

                // Sadece dosya adını al
                string selectedFileName = System.IO.Path.GetFileName(selectedFilePath);

                // Dosya adını bir Label'a yazdır
                selectedFileNameLabel.Text = selectedFileName;
            }
        }

    }
}
