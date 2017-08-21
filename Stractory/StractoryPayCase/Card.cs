using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryPayCase
{
    /// <summary>
    /// 账号支付
    /// </summary>
    public class Card:IStractoryPay
    {
        
        private string _account = null;
        /// <summary>
        /// 什么账号
        /// </summary>
        /// <param name="account"></param>
        public Card(string account)
        {
            _account = account;
        }
        /// <summary>
        /// 我的支付方式
        /// </summary>
        /// <param name="context"></param>
        public void Pay(StractoryContext context)
        {
            Console.WriteLine(context.GetUserName()+context.GetUserMoney()+"通过账户转了.....");
        }
    }
}
