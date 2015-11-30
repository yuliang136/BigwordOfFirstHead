using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    class CashFactory
    {
        /// <summary>
        /// 通过string type获取某一种活动的对象.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static CashSuper createCashAccept(string type)
        {
            CashSuper csRtn = null;

            switch (type)
            {
                case "正常收费":
                    csRtn = new CashNormal();
                    break;

                case "满300返100":
                    csRtn = new CashReturn(300, 100);
                    break;

                case "打8折":
                    //csRtn = new CashRebate(0.8);
                    CashRebate cr = new CashRebate(0.8);
                    csRtn = cr;
                    break;
            }


            return csRtn;
        }
    }
}
