﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Cat
    {
        private string _strName;

        public Cat(string strName)
        {
            _strName = strName;
        }

        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);
        public event CatShoutEventHandler _eventCatShout;

        // public Action _eventCatShout;

        public void Shout()
        {
            Console.WriteLine("Miao,I am {0}.",_strName);

            if (_eventCatShout != null)
            {
                CatShoutEventArgs e = new CatShoutEventArgs {StrName = this._strName};
                _eventCatShout(this,e);
            }
        }
    }
}
