using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    class Animal
    {
        protected string _strName = "";

        public Animal(string strName)
        {
            this._strName = strName;
        }

        public Animal()
        {
            this._strName = "No Name";
        }

        protected int _nShoutNum = 3;

        public int ShoutNum
        {
            get { return _nShoutNum; }
            set { _nShoutNum = value; }
        }

        public virtual string Shout()
        {
            return "";
        }
    }
}
