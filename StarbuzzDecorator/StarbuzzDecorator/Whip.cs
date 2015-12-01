using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;

            _strDescription = _beverage.getDescription() + ", Whip";
        }

        public override string getDescription()
        {
            return _beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.1 + _beverage.cost();
        }
    }
}
