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
            string _strFirstNum = Console.ReadLine();
            string _strOperation = Console.ReadLine();
            string _strSecondNum = Console.ReadLine();
            string _strResult = "";

            switch (_strOperation)
            {
                case "+":
                    _strResult = Convert.ToString(Convert.ToDouble(_strFirstNum) + Convert.ToDouble(_strSecondNum));
                    break;
                case "-":
                    _strResult = Convert.ToString(Convert.ToDouble(_strFirstNum) - Convert.ToDouble(_strSecondNum));
                    break;
                case "*":
                    _strResult = Convert.ToString(Convert.ToDouble(_strFirstNum) * Convert.ToDouble(_strSecondNum));
                    break;
                case "/":
                    _strResult = Convert.ToString(Convert.ToDouble(_strFirstNum) / Convert.ToDouble(_strSecondNum));
                    break;

            }

            Console.WriteLine("Reuslt is {0}", _strResult);
        }
    }
}
