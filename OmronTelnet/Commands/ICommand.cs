using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalisticTelnet;

namespace OmronTelnet.Commands
{
    interface ICommand
    {
        void Start(TelnetConnection telnet);
        void Stop();
    }
}
