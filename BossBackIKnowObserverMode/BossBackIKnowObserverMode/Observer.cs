using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    public abstract class Observer
    {
        protected string _strName;
        protected ISubject _iSubject;

        protected Observer(ISubject iSubject, string strName)
        {
            _iSubject = iSubject;
            _strName = strName;
        }

        /// <summary>
        /// 这个Update由具体类去实现.
        /// 由Subject来调用.
        /// </summary>
        public abstract void Update();
    }
}
