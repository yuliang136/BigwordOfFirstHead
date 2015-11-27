using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigwordOfFirstHead
{
    /// <summary>
    /// 封装带来的好处.
    /// 让Cat和Form进行了耦合分离
    /// 类内部自由修改 不影响调用者.
    /// 类具有清晰的对外接口.
    /// </summary>
    class Cat : Animal
    {
        public Cat() : base()
        {
        }

        public Cat(string strName) : base(strName)
        {
            // 这个name由外部传入. 传入Cat构造函数和base Animal构造函数里.

            // 这里由base Animal构造函数处理.
        }

        public override string Shout()
        {
            string result = "";

            for (int i = 0; i < _nShoutNum; i++)
            {
                result += "喵， ";
            }

            return "My name is " + _strName + " " + result;
        }

    }
}
