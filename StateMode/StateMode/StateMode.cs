using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode
{
    class StateMode
    {
        public int _nHour;
        public bool _bWorkFinished = false;

        public void RunProgram(int nHour)
        {
            _nHour = nHour;

            if (_nHour < 12)
            {
            }
            else
            {
                // 这里的分支变为>=12
                // nHour >= 12
            }
        }
    }
}
