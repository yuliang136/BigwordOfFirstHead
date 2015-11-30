using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    class CashContext
    {
        private CashSuper _cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    _cs = new CashNormal();
                    break;

                case "满300返100":
                    _cs = new CashReturn(300, 100);
                    break;

                case "打8折":
                    //csRtn = new CashRebate(0.8);
                    CashRebate cr = new CashRebate(0.8);
                    _cs = cr;
                    break;
            }
        }

        /// <summary>
        /// 这里预留了两步操作.
        /// 1 创建CashContext这个对象.
        /// 2 调用CashContext里面的GetResult方法来做处理.
        /// 3 能不能用单例 不创建CashContext对象. 直接用单例传入两个参数来做？
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            return _cs.acceptCash(money);
        }
    }
}
