using ChatClient.MVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.MVM.Core
{
    class MainViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }
        private Server _server;
        public string Username { get; set; }

        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer(Username), o=>!string.IsNullOrEmpty(Username));
        }

    }
}
