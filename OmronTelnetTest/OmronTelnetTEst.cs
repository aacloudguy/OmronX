using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmronTelnet;

namespace OmronTelnetTest
{
    [TestClass]
    public class OmronTelnetTest
    {
        private OmronTelnetApp _telnet = new OmronTelnetApp();

        [TestMethod]
        public void AppShouldConnectToRobot()
        {
            OmronTelnetApp _telnet = ConnectToRobot();
            string message = _telnet.GetOmronMessage();
            Assert.IsTrue(message.Contains("Enter password"));
        }

        [Ignore]
        public void AppShouldLoginToRobot()
        {
            ConnectToRobot();
        }

        [Ignore]
        public void AppShouldSendCommand()
        {
        }

        private OmronTelnetApp ConnectToRobot()
        {
            OmronTelnetApp _telnet = new OmronTelnetApp();
            _telnet.EstablishConnection();
            return _telnet;
        }


    }
}
