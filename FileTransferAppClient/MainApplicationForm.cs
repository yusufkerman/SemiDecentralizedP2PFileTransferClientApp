using FileTransferAppClient.Managers;
using MQTTConnectModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void OnActiveUserRefreshButtonClicked(object sender, EventArgs e)
        {
            _activeUsersViewerManager.UpdateDataGridView();
        }
    }
}
