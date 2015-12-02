﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    public class Secretary : ISubject
    {
        private Action _actionNotify;

        public string SubjectState
        {
            get { return null; }
            set { }
        }

        public Action ActionNotify { get; set; }

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

        ///// <summary>
        ///// 添加 这里针对具体类做了设计，如果有其他类型的监听者时会有问题.
        ///// </summary>
        ///// <param name="observer"></param>
        //public void Attach(Observer observer)
        //{
        //    _ltObservers.Add(observer);
        //}

        //public void Detach(Observer observer)
        //{
        //    _ltObservers.Remove(observer);
        //}

        ///// <summary>
        ///// 通知.
        ///// </summary>
        //public void Notify()
        //{
        //    foreach (Observer o in _ltObservers)
        //    {
        //        o.Update();
        //    }
        //}

        ///// <summary>
        ///// 设置状态，值没有传递，而是让Client来拿取
        ///// 这里会有问题.
        ///// </summary>
        //public string SecretaryAction
        //{
        //    get { return _strAction; }
        //    set { _strAction = value; }
        //}
    }
}
