﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStrategy
{
    class FlyNoWay:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("No fly");
        }
    }
}
