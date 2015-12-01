using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    class NBAObserver:Observer
    {
        public NBAObserver(Secretary subjectSecretary, string strName) : base(subjectSecretary, strName)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！ ",
                    _subjectSecretary.SecretaryAction,
                    _strName);
        }
    }
}
