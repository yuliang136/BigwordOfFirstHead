using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Shout());

            //

            //Cat cat = new Cat();

            Cat cat; // 声明一个变量 指针.
            cat = new Cat(); // 开辟内存.
            cat.ShoutNum = 10;

            Console.WriteLine(cat.Shout());
        }

    }
}
