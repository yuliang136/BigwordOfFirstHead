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

        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine("老猫{0}来了, {1}快跑！ ", args.StrName,_strName);
        }
    }
}
