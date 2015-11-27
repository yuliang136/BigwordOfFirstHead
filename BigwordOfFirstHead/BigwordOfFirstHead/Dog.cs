using System;
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

        public override string Shout()
        {
            string result = "";

            for (int i = 0; i < _nShoutNum; i++)
            {
                result += "汪， ";
            }

            return "My name is " + _strName + " " + result;
        }
    }
}
