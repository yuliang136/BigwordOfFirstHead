using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    class Boss
    {
        // 定义一个委托类型. 无返回值 无参数
        public delegate void MyEventHandler();

        // 声明一个委托.
        public MyEventHandler _eventUpdate;

        public void Notify()
        {
            if (_eventUpdate != null)
            {
                _eventUpdate();
            }
            
        }

        //private List<Observer> _ltObservers = new List<Observer>();
        //private string _strAction;

        //public string SubjectState
        //{
        //    get { return _strAction; }
        //    set { _strAction = value; }
        //}

        //public void Notify()
        //{
        //    foreach (Observer o in _ltObservers)
        //    {
        //        o.Update();
        //    }
        //}

        //public void Detach(Observer observer)
        //{
        //    _ltObservers.Remove(observer);
        //}

        //public void Attach(Observer observer)
        //{
        //    _ltObservers.Add(observer);
        //}
    }
}
