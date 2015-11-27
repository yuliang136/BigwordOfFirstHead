using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class StoneMonkey : Monkey,IChange
    {
        public StoneMonkey(string strName) : base(strName)
        {
        }

        public StoneMonkey()
        {
        }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有毫毛，可以变出： " + thing;
        }
    }
}
