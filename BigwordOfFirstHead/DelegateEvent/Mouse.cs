using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Mouse
    {
        private string _strName;

        public Mouse(string strName)
        {
            _strName = strName;
        }

        public void Run()
        {
            Console.WriteLine("老猫来了, {0}快跑！ ", _strName);
        }
    }
}
