﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class Dog : Animal
    {
        public Dog() : base()
        {
        }

        public Dog(string strName) : base(strName)
        {
        }

        protected override string getShoutSound()
        {
            return "Wang";
        }
    }
}
