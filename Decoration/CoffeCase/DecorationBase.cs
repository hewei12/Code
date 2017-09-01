using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCase
{
    /// <summary>
    /// 装饰基类
    /// </summary>
    public abstract class DecorationBase
    {
        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}
