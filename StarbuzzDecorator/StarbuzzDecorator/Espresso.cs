using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            _strDescription = "Espresso";
        }

        //public override string getDescription()
        //{
        //    return "Espresso";
        //}

        public override double cost()
        {
            return 1.99;
        }
    }
}
