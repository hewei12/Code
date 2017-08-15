using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProdectCase
{
    public abstract class AbstractProductA
    {
        /// <summary>
        /// 每个产品共有的方法
        /// </summary>
        public void ShareMethod() { }
        /// <summary>
        /// 每个产品相同方法，不同实现
        /// </summary>
        public abstract void DoSomething();
    }
}
