using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("Small bird");

            Console.WriteLine("\nThe first decorated type: ");

            Finery dtx = new TShirts();
            Finery kk = new BigTrouser();
            Finery pqx = new Sneakers();

            dtx.Show();
            kk.Show();
            pqx.Show();
            xc.Show();


            Console.WriteLine("\nThe second decorated type: ");
            Finery xz = new Suit();
            Finery ld = new Tie();
            Finery px = new LeatherShoes();

            xz.Show();
            ld.Show();
            px.Show();

            xc.Show();

        }
    }
}
