using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalisticTelnet;

namespace OmronTelnet.Commands
{
    public class MoveDroidCommand : ICommand
    {
        private readonly string _zone;

        public MoveDroidCommand(string zone)
        {
            _zone = zone;
        }

        public void Start(TelnetConnection telnet)
        {
            telnet.WriteLine(OmronDictionary.GoTo.Value + " " + _zone);
        }

        public void Stop()
        {
        }
    }
}
