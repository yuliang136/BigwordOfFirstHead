using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    // delegate void MyEventHandler();

    /// <summary>
    /// 做一个规范性接口，但是没有拿来做多态用.
    /// </summary>
    public interface ISubject
    {
        Action ActionNotify
        {
            get; 
            set; 
        }

        void Notify();

        string SubjectState
        {
            get; 
            set; 
        }
    }
}
