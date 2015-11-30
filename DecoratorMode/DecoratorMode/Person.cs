using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Person
    {
        private string _strName;
        public Person(string strName)
        {
            _strName = strName;
        }

        //public void WearTShirts()
        //{
        //    Console.Write("BigTShirt ");
        //}

        //public void WearBigTrouser()
        //{
        //    Console.Write("BigTrouser ");
        //}

        //public void WearSneakers()
        //{
        //    Console.Write("Sneakers ");
        //}

        //public void WearSuit()
        //{
        //    Console.Write("Suit ");
        //}

        //public void WearTie()
        //{
        //    Console.Write("Tie ");
        //}

        //public void WearLeatherShoes()
        //{
        //    Console.Write("LeatherShoes ");
        //}

        public void Show()
        {
            Console.WriteLine("Decorated {0}", _strName);
        }
    }

}
