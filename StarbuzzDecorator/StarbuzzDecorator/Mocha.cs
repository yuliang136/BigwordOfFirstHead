using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;

            // 这里就把Description设置了？ 这样会变为静态?
            _strDescription = _beverage.getDescription() + ", Mocha";
        }

        // 这个函数不会被调用.
        public override string getDescription()
        {
            //string oldContent = _beverage.getDescription();

            //return oldContent + ", Mocha";
            return null;
        }

        public override double cost()
        {
            return 0.2 + _beverage.cost();
        }
    }
}
