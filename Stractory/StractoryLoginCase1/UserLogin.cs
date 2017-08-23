using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase1
{
    /// <summary>
    /// 登录接口
    /// </summary>
    public abstract class UserLogin
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }



        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public abstract bool Login(ICredential ic);
    }
}
