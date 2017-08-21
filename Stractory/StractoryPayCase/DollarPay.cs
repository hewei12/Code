using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryPayCase
{
    /// <summary>
    /// 美元方式支付
    /// </summary>
    public class DollarPay : IStractoryPay
    {
        /// <summary>
        /// 美元支付方式
        /// </summary>
        /// <param name="context"></param>
        public void Pay(StractoryContext context)
        {
            Console.WriteLine(context.GetUserName() + context.GetUserMoney() + "美元支付方式...............");
        }
    }
}
