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

            Dog dog = new Dog("hehe") {ShoutNum = 10};

            Console.WriteLine(dog.Shout());
        }
    }
}
