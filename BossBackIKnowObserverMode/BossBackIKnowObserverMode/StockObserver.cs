using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    public class StockObserver
    {
        private string _strName;
        public StockObserver(string strName)
        {
            _strName = strName;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} 关闭股票行情, 继续工作", _strName);
        }
    }
}
