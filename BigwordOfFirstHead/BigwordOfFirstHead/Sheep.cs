using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class Sheep : Animal
    {
        public Sheep()
        {
        }

        public Sheep(string strName) : base(strName)
        {
        }

        protected override string getShoutSound()
        {
            return "MieMie";
        }
    }
}
