using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStrategy
{
    class MallardDuck:Duck
    {
        public MallardDuck()
        {
            // 这里有问题？ 对实现进行了编程.
            // program to an implementation.
            // 可以在运行时切换方法.
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("MallardDuck");
        }
    }
}
