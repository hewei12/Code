using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase
{
    /// <summary>
    /// 用户登录
    /// </summary>
    public interface IUserAdmin
    {
        int Login(StractoryContext context);
    }
}
