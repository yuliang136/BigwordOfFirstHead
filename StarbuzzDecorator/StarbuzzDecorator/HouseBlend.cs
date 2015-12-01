using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            _strDescription = "HouseBlend";
        }

        //public override string getDescription()
        //{
        //    return "HouseBlend";
        //}

        public override double cost()
        {
            return 0.89;
        }
    }
}
