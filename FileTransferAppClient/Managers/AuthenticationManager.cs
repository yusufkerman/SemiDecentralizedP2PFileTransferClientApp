using FileTransferAppClient.Contracts;
using FileTransferAppClient.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransferAppClient.Managers
{
    public class AuthenticationManager : Singleton<AuthenticationManager>, IManager
    {
        public string UserToken => _userJwtToken;
        private string _userJwtToken;

        public void SetUserAuthenticationToken(string token)
        {
            _userJwtToken = token;
        }
    }
}
