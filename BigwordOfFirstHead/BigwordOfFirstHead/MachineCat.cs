using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class MachineCat:Cat,IChange
    {
        public MachineCat()
        {
        }

        public MachineCat(string strName) : base(strName)
        {
        }

        public string ChangeThing(string thing)
        {
            return base.Shout() + " 我有万能的口袋,我可以变出： " + thing;
        }
    }
}
