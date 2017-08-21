using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryPayCase
{
    /// <summary>
    /// 策略上下文(定义共有的方法、参数以及策略选择)
    /// </summary>
    public class StractoryContext
    {
        private IStractoryPay _stractoryPay = null;
        private string _userName = null;
        private double _money = 0.0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName">某人</param>
        /// <param name="money">多少钱</param>
        /// <param name="stractoryPay">什么策略</param>
        public StractoryContext(string userName, double money, IStractoryPay stractoryPay)
        {
            _userName = userName;
            _money = money;
            _stractoryPay = stractoryPay;
        }
        /// <summary>
        /// 获取名称
        /// </summary>
        /// <returns></returns>
        public string GetUserName()
        {
            return _userName;
        }
        /// <summary>
        /// 转多少钱
        /// </summary>
        /// <returns></returns>
        public double GetUserMoney()
        {
            return _money;
        }
        /// <summary>
        /// 选择什么策略
        /// </summary>
        public void SetUp()
        {
            _stractoryPay.Pay(this);
        }
    }
}
