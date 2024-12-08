using FileTransferAppClient.Models;
using FileTransferAppClient.Utilities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileTransferAppClient.Managers
{
    public class ActiveUsersViewerManager : Singleton<ActiveUsersViewerManager>
    {
        private DataGridView _activeUsersView;
        private Label _pageLabel;

        private int _pageSize = 10;
        private int _pageNumber = 1;

        public void Initialieze(DataGridView activeUsersView,Label pageLabel)
        {
            _activeUsersView = activeUsersView;
            _pageLabel = pageLabel;
        }
        public async void UpdateDataGridView()
        {
            //İlgili sayfadaki kullanıcılar alınır
            List<User> users = await UserActivityManager.Instance
                .GetActiveUsersWithPaginationAsync(_pageNumber,_pageSize);

            // DataGridView'ı temizliyoruz
            _activeUsersView.Rows.Clear();

            // Gelen kullanıcıları DataGridView'e ekliyoruz
            foreach (var user in users)
            {
                // Yeni bir satır oluşturuyoruz
                var row = new DataGridViewRow();
                row.Height = 40;
                // Her bir hücreyi oluşturup satıra ekliyoruz
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.IpAddress });

                // Satırı DataGridView'a ekliyoruz
                _activeUsersView.Rows.Add(row);
            }
        }
        public void NextPage()
        {
            if (_pageNumber < _pageSize)
            {
                _pageNumber++;
                _pageLabel.Text = _pageNumber.ToString();
                UpdateDataGridView();
            }
        }
        public void PrevPage()
        {
            if (_pageNumber > 1)
            {
                _pageNumber--;
                _pageLabel.Text = _pageNumber.ToString();
                UpdateDataGridView();
            }
        }
    }
}
