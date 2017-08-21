using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryPayCase
{
    public class RenMinbiPay : IStractoryPay
    {
        /// <summary>
        /// 人民币方式支付
        /// </summary>
        /// <param name="context"></param>
        public void Pay(StractoryContext context)
        {
            Console.WriteLine(context.GetUserName() + context.GetUserMoney() + "人民币支付方式..........");
        }
    }
}
