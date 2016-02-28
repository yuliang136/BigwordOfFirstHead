using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            int nHour = 16;

            Work work = new Work();
            work.RunProgram(nHour,true);
        }
    }
}
