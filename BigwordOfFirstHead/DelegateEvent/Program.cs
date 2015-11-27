using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            cat._eventCatShout += mouse1.Run;
            cat._eventCatShout += mouse2.Run;

            cat.Shout();
        }
    }
}
