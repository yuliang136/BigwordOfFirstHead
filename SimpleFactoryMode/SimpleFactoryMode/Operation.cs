using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMode
{
    abstract class Operation
    {
        private double _dNumberA = 0.0;
        private double _dNumberB = 0.0;

        public double NumberA
        {
            get { return _dNumberA; }
            set { _dNumberA = value; }
        }

        public double NumberB
        {
            get { return _dNumberB; }
            set { _dNumberB = value; }
        }

        // 使得Operation没有实例 必须由继承类去实现.
        public abstract double GetResult();
    }
}
