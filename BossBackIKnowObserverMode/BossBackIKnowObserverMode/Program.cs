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
            Boss hu = new Boss();

            StockObserver tongshi1 = new StockObserver();

            hu._eventUpdate += new Boss.MyEventHandler(tongshi1.CloseStockMarket);

            hu.Notify();

            //// Secretary
            //Secretary tongzizhe = new Secretary();

            //// 在Observer端保留了一个Subject,拿取状态 这里会有问题.
            //StockObserver tongshi1 = new StockObserver(tongzizhe,"Wei");
            //StockObserver tongshi2 = new StockObserver(tongzizhe,"Yi");

            //tongzizhe.Attach(tongshi1);
            //tongzizhe.Attach(tongshi2);

            //tongzizhe.SecretaryAction = "老板回来了! ";

            //tongzizhe.Notify();

            //Boss huhansan = new Boss();

            //StockObserver tongshi1 = new StockObserver(huhansan, "Wei");


            //NBAObserver tongshi2 = new NBAObserver(huhansan, "Yi");

            //huhansan.Attach(tongshi1);
            //huhansan.Attach(tongshi2);

            //huhansan.Detach(tongshi1);

            //huhansan.SubjectState = "Huhansan is coming back!";
            //huhansan.Notify();
        }
    }
}
