using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    class Boss : ISubject
    {
        public delegate void YLEventHandler();

        public YLEventHandler _Update;

        public string SubjectState
        {
            get { return null; }
            set { }
        }

        public Action ActionNotify { get; set; }

        // 声明一个委托.


        public void Notify()
        {
            if (ActionNotify != null)
            {
                ActionNotify();
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
