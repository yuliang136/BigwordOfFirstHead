using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    class CashNormal:CashSuper
    {
        /// <summary>
        /// 原价返回.
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
