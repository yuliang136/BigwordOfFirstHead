using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class CatShoutEventArgs : EventArgs
    {
        private string _strName;

        public string StrName
        {
            get { return _strName; }
            set { _strName = value; }
        }
    }
}
