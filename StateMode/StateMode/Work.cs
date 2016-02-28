using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode
{
    class Work
    {
        public int _nHour;
        public bool _bWorkFinished = false;

        public void RunProgram(int nHour, bool bWorkFinished)
        {
            _nHour = nHour;
            _bWorkFinished = bWorkFinished;

            if (_nHour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍",_nHour);
            }
            else if(_nHour <13)
            {
                Console.WriteLine("当前时间：{0}午休", _nHour);
            }
            else if (_nHour < 17)
            {
                Console.WriteLine("当前时间：{0}点, 下午状态还不错 继续努力", _nHour);
            }
            else // Time >= 17
            {
                if (_bWorkFinished)
                {
                    Console.WriteLine("当前时间：{0}点, 下班回家了", _nHour);
                }
                else
                {
                    // 继续工作
                    if (_nHour < 21)
                    {
                        Console.WriteLine("当前时间：{0}加班哦，疲累之极", _nHour);
                    }
                    else
                    {
                        Console.WriteLine("当前时间：{0}不行了 睡着了", _nHour);
                    }
                }
            }
        }
    }
}
