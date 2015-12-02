using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    class Program
    {
        static void Main(string[] args)
        {

            Boss huhansan = new Boss();

            StockObserver tongshi1 = new StockObserver("Wei");

            huhansan.ActionNotify += tongshi1.CloseStockMarket;

            huhansan.Notify();
        }
    }
}
