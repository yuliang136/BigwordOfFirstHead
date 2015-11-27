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
            // Ui 获取输入.
            string _strFirstNum = Console.ReadLine();
            string _strOperation = Console.ReadLine();
            string _strSecondNum = Console.ReadLine();
            string _strResult = "";
            
            //// 调用业务层处理.
            //_strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(_strFirstNum),
            //                                Convert.ToDouble(_strSecondNum),
            //                                _strOperation));

            Operation oper;
            oper = OperationFactory.createOperate(_strOperation);

            oper.NumberA = Convert.ToDouble(_strFirstNum);
            oper.NumberB = Convert.ToDouble(_strSecondNum);

            double result = oper.GetResult();

            Console.WriteLine("Reuslt is {0}", result);
        }
    }
}
