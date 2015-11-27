using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstNum = Console.ReadLine();
            string Operation = Console.ReadLine();
            string SecondNum = Console.ReadLine();
            string Result = "";

            if (Operation == "+")
            {
                Result = Convert.ToString(Convert.ToDouble(FirstNum) + Convert.ToDouble(SecondNum));
            }
            else if(Operation == "-")
            {
                Result = Convert.ToString(Convert.ToDouble(FirstNum) - Convert.ToDouble(SecondNum));
            }
            else if (Operation == "*")
            {
                Result = Convert.ToString(Convert.ToDouble(FirstNum) * Convert.ToDouble(SecondNum));
            }
            else if (Operation == "/")
            {
                Result = Convert.ToString(Convert.ToDouble(FirstNum) / Convert.ToDouble(SecondNum));
            }

            Console.WriteLine("Reuslt is {0}", Result);
        }
    }
}
