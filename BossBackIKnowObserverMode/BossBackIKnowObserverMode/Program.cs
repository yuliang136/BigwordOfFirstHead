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
            // Secretary
            Secretary tongzizhe = new Secretary();

            // 在Observer端保留了一个Subject,拿取状态 这里会有问题.
            StockObserver tongshi1 = new StockObserver("Wei", tongzizhe);
            StockObserver tongshi2 = new StockObserver("Yi", tongzizhe);

            tongzizhe.Attach(tongshi1);
            tongzizhe.Attach(tongshi2);

            tongzizhe.SecretaryAction = "老板回来了! ";

            tongzizhe.Notify();
        }
    }
}
