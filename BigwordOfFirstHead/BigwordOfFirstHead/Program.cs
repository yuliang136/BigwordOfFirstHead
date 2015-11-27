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

            //Animal[] arrayAnimal = new Animal[5]
            //{
            //    new Monkey("小花"),
            //    new Dog("阿毛"),
            //    new Cattle("小黑"),
            //    new Cat("娇娇"),
            //    new Sheep("咪咪")
            //};

            //foreach (var item in arrayAnimal)
            //{
            //    Console.WriteLine(item.Shout());
            //}

            // 利用接口来调用对象.

            MachineCat mcat = new MachineCat("叮当");
            StoneMonkey wukong = new StoneMonkey("孙");

            IChange[] array = new IChange[2];

            array[0] = mcat;  // 接口指针指向对象时 只能使用对象里实现的接口方法.
            array[1] = wukong;

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.ChangeThing());
            //}

            Console.WriteLine(array[0].ChangeThing("各种各样的东西! "));
            Console.WriteLine(array[1].ChangeThing("各种各样的东西! "));

        }
    }
}
