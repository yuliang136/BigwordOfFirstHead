using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    public class StockObserver : Observer
    {
        //private string _strName;
        
        //// 这里保留一个具体的Subject类. 通过这个实例可以知道Subject的状态.
        //// 这里没有面向抽象设计. 有问题. 可能有其他类型的Subject.
        //private Secretary _subSecretary; 

        //public StockObserver(string strName, Secretary subSecretary)
        //{
        //    _strName = strName;
        //    _subSecretary = subSecretary;
        //}

        //public void Update()
        //{
        //    Console.WriteLine("{0} {1} 关闭股票行情，继续工作！ ", _subSecretary.SecretaryAction, _strName);
        //}

        public StockObserver(Secretary subjectSecretary, string strName) 
                                : base(subjectSecretary, strName)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作！ ", 
                                _subjectSecretary.SecretaryAction, 
                                _strName);
        }
    }
}
