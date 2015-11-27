using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class Monkey : Animal
    {
        public Monkey(string strName) : base(strName)
        {
        }

        public Monkey()
        {
        }

        protected override string getShoutSound()
        {
            return "houhou";
        }
    }
}
