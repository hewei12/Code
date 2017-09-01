using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCase
{
    /// <summary>
    /// 卡布奇若
    /// </summary>
    public class Kapqiruo : DecorationBase
    {
        /// <summary>
        /// 什么东西
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return "it is Kapqiruo";
        }
        /// <summary>
        /// 多少钱
        /// </summary>
        /// <returns></returns>
        public override decimal Cost()
        {
            return (decimal)0.8;
        }
    }
}
