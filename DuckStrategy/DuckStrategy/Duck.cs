using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStrategy
{
    public abstract class Duck
    {
        protected IQuackBehavior _quackBehavior;
        protected IFlyBehavior _flyBehavior;

        public abstract void display();

        /// <summary>
        /// 抽象类里面可以有实现的代码 让子类统一使用.
        /// </summary>
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void performQuack()
        {
            _quackBehavior.quack();
        }

        public void performFly()
        {
            _flyBehavior.fly();
        }
    }
}
