using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProdectCase
{
    public abstract class AbstractCreator
    {
        /// <summary>
        /// 创建A产品族
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductA CreateProductA();
    }
}
