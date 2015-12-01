using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    public class StockObserver
    {
        //public StockObserver(ISubject iSubject, string strName) : base(iSubject, strName)
        //{
        //}

        //public override void Update()
        //{
        //    Console.WriteLine("{0} {1} 关闭股票航行，继续工作！ ",
        //                        _iSubject.SubjectState,_strName);
        //}

        //private string _strName;
        //private I

        public void CloseStockMarket()
        {
            Console.WriteLine("CloseStockMarket");
        }
    }
}
