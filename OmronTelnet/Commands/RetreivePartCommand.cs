using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalisticTelnet;

namespace OmronTelnet.Commands
{
    public class RetreivePartCommand: ICommand
    {
        private readonly string _partNumber;

        public RetreivePartCommand(string partNumber) {
            _partNumber = partNumber;
        }

        public void Start(TelnetConnection telnet) {
            telnet.WriteLine(OmronDictionary.Say.Value + " " + _partNumber);
        }

        public void Stop() {
        }
    }
}
