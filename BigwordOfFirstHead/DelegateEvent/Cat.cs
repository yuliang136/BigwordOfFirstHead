using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Cat
    {
        private string _strName;

        public Cat(string strName)
        {
            _strName = strName;
        }

        public delegate void CatShoutEventHandler();

        public event CatShoutEventHandler _eventCatShout;

        public void Shout()
        {
            Console.WriteLine("Miao,I am {0}.",_strName);

            if (_eventCatShout != null)
            {
                _eventCatShout();
            }
        }
    }
}
