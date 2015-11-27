using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class Cattle : Animal
    {
        public Cattle()
        {
        }

        public Cattle(string strName) : base(strName)
        {
        }

        protected override string getShoutSound()
        {
            return "MouMou";
        }
    }
}
