using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class Indexers
    {
        // generic class w/ generic parameters that store a key of typ. string & value of typ. string
        private readonly Dictionary<string, string> _dictionary;

        public Indexers()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
