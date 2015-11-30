using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    /// <summary>
    /// 返利收费
    /// 满300返100  那么800 就会返200
    /// </summary>
    class CashReturn : CashSuper
    {
        private double _dMoneyCondition = 0.0d;     // 返利达成的条件.
        private double _dMoneyReturn = 0.0d;        // 每达成条件 就进行一次返利.

        public CashReturn(double dMoneyCondition, double dMoneyReturn)
        {
            _dMoneyCondition = dMoneyCondition;
            _dMoneyReturn = dMoneyReturn;
        }

        public override double acceptCash(double money)
        {
            double dResult = 0.0d;

            if (money >= _dMoneyCondition)
            {
                
                // 总的返利的钱.
                // 总价对返利条件求商 取Floor整数 再乘以每单返利数值.
                double dTotalReturn = Math.Floor(money/_dMoneyCondition)*_dMoneyReturn;

                dResult = money - dTotalReturn;
            }

            return dResult;
        }
    }
}
