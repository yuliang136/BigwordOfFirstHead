using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMode
{
    class Operation
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double _dResult = 0.0;

            switch (operate)
            {
                case "+":
                    _dResult = numberA + numberB;
                    break;
                case "-":
                    _dResult = numberA - numberB;
                    break;
                case "*":
                    _dResult = numberA * numberB;
                    break;
                case "/":
                    _dResult = numberA / numberB;
                    break;

            }


            return _dResult;
        }
    }
}
