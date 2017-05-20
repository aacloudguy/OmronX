using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalisticTelnet;
using OmronModels;

namespace OmronTelnet
{
    public class OmronTelnetApp
    {

        protected TelnetConnection telnet;
        private string _ipAddress;
        private int _port;
        private string _password;
        private bool _isRunning;
        private bool _isLoggedIn;

        public OmronTelnetApp()
        {
            _ipAddress = ConfigurationManager.AppSettings["droidIpAddress"];
            int.TryParse(ConfigurationManager.AppSettings["droidPort"], out _port);
            _password = ConfigurationManager.AppSettings["droidPassword"];
            _isRunning = false;
            _isLoggedIn = false;
        }

        public void MoveDroidToPartsArea(OmronDroidRequests request)
        {

        }

        public void SpeakPartNumber()
        {
        }

        public void MoveDroidToBayArea(OmronDroidRequests request)
        {
        }

        public void ReturnDroidToBase(OmronDroidRequests request)
        {
        }

        public void Start()
        {
            _isRunning = true;

            while (_isRunning)
            {
                EstablishConnection();
                if (!_isLoggedIn)
                {
                    Login();
                }
                else
                {
                    Process();
                }
            }
        }

        public void Stop()
        {
            _isRunning = false;
        }

        public void Process()
        {
        }

        public void EstablishConnection()
        {
            try
            {
                telnet = new TelnetConnection(_ipAddress, _port);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public string GetOmronMessage()
        {
            return telnet.Read();
        }

        public void Login()
        {
            telnet.WriteLine(_password);
            if (GetOmronMessage() == OmronDictionary.Welcome.Value)
            {
                _isLoggedIn = true;
            }
        }

    }
}
