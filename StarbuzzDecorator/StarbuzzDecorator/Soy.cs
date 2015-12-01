using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    class Soy : CondimentDecorator
    {
        private Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string getDescription()
        {
            return _beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.15 + _beverage.cost();
        }
    }
}
