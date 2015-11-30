using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class LeatherShoes:Finery
    {
        public override void Show()
        {
            Console.Write("LeatherShoes ");
        }
    }
}
