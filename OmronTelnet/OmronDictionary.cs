using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmronTelnet
{
    public sealed class OmronDictionary
    {
        public string Value { get; private set; }
        private OmronDictionary(string value) { Value = value; }

        public static OmronDictionary Welcome => new OmronDictionary("Welcome to the server.");
        public static OmronDictionary Login => new OmronDictionary("Enter password:");
        public static OmronDictionary GoTo => new OmronDictionary("goto");
        public static OmronDictionary Say => new OmronDictionary("say");
    }
}
