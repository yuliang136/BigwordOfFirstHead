using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    abstract class CashSuper
    {
        /// <summary>
        /// 现金收取超类的抽象方法.
        /// 收取现金，参数为原价，返回为当前价.
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public abstract double acceptCash(double money);
    }
}
