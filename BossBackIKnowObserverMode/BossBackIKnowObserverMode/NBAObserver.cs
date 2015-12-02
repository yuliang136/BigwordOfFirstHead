using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBackIKnowObserverMode
{
    class NBAObserver
    {
        private string _strName;
        public NBAObserver(string strName)
        {
            _strName = strName;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0}关闭NBA直播，继续工作", _strName);
        }

    }
}
