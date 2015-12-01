using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzDecorator
{
    public abstract class Beverage
    {
        protected string _strDescription = "Unkown Beverage";

        // public abstract string getDescription();

        // 这里是个实体方法. 继承类根本没得选择会去调用这里.
        // 继承类是否有设置_strDescription.
        public string getDescription()
        {
            return _strDescription;
        }

        public abstract double cost();
    }
}
