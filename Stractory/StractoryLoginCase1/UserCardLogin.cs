using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase1
{
    public class UserCardLogin : UserLogin
    {
        /// <summary>
        /// 用户打卡验证
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public override bool Login(ICredential ic)
        {
            string sql = "Select card from users where";
            sql += ic.CredentialStr();
            Console.WriteLine(Name + "登录成功");
            return true;
        }
    }
}
