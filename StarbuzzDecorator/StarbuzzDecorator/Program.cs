using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beverage beverage = new Espresso();
            //Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            // 这里会有问题 Beverage的getDescription是个实体函数.

            string strDescription = beverage2.getDescription();

            Console.WriteLine(strDescription + " $" + beverage2.cost());
        }
    }
}
