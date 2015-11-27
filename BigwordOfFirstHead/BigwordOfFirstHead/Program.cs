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

            //Dog dog = new Dog("hehe") {ShoutNum = 10};

            //Console.WriteLine(dog.Shout());

            Animal[] arrayAnimal = new Animal[5]
            {
                new Cat("小花"),
                new Dog("阿毛"),
                new Dog("小黑"),
                new Cat("娇娇"),
                new Cat("咪咪")
            };

            foreach (var item in arrayAnimal)
            {
                Console.WriteLine(item.Shout());
            }

            
        }
    }
}
