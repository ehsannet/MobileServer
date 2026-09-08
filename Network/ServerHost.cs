using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace MobileServer.Network
{
    public class ServerHost
    {
        private TcpListener _server;
        private TcpClient _client;
        private NetworkStream _stream;
        private byte[] _buffer = new byte[1024];
        private int _readbyte;
        private string _httprequest;
        public ServerHost()
        {
            _server = new TcpListener(IPAddress.Any,5000);
        }
        public void StartServerMS()
        {
            _server.Start();
        }
        public void ClientConnectToMS()
        {
            int t;
            while(app == "off")
            {
                 _client = _server.AcceptTcpClient();
                 _stream = _client.GetStream();char
                _readbyte = _stream.Read(_buffer,0,_buffer.Length);
            }
        }
        public void ReadStremMS()
        {
            _httprequest = Encoding.UTF8.GetString(_buffer,0,_readbyte.Length);
        }
    }
}