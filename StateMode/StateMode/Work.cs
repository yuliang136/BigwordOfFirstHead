using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode
{
    public class Work
    {
        private State _current;

        public Work()
        {
            _current = new ForenoonState();
        }

        private double _dHour;
        public double Hour
        {
            get { return _dHour; }
            set { _dHour = value; }
        }

        private bool _bFinish = false;
        public bool Finish
        {
            get { return _bFinish; }
            set { _bFinish = value; }
        }

        /// <summary>
        /// 设置状态.
        /// </summary>
        /// <param name="s">设置的新状态.</param>
        public void SetState(State s)
        {
            _current = s;
        }

        public void WriteProgram()
        {
            // 把Work对象传递到具体的状态类里做处理.
            _current.WriteProgram(this);
        }

    }
}
