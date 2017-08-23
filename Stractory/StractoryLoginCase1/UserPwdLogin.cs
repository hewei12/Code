using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase1
{
    public class UserPwdLogin : UserLogin
    {
        /// <summary>
        /// 用户密码验证
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public override bool Login(ICredential ic)
        {
            string sql = "Select userid from users where";
            sql += ic.CredentialStr();
            Console.WriteLine(Name + "登录成功");
            return true;
        }
    }
}
