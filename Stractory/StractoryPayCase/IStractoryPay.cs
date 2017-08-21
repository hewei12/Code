using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryPayCase
{
    /// <summary>
    /// 支付接口
    /// </summary>
    public interface IStractoryPay
    {
        void Pay(StractoryContext context);
    }
}
