using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Tie:Finery
    {
        public override void Show()
        {
            Console.Write("Tie ");
        }
    }
}
