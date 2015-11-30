using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    class CashRebate : CashSuper
    {
        private double _dMoneyRebate = 1d;

        public CashRebate(double dMoneyRebate)
        {
            this._dMoneyRebate = dMoneyRebate;
        }

        public override double acceptCash(double money)
        {
            // 八折的话 相当于原价*打折率.
            return money*_dMoneyRebate;
        }
    }
}
