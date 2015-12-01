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
        protected Secretary _subjectSecretary;

        protected Observer(Secretary subjectSecretary, string strName)
        {
            _subjectSecretary = subjectSecretary;
            _strName = strName;
        }

        /// <summary>
        /// 这个Update由具体类去实现.
        /// 由Subject来调用.
        /// </summary>
        public abstract void Update();
    }
}
