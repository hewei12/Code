using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase1
{
    public class PwdCredential:ICredential
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// 验证字符串
        /// </summary>
        /// <returns></returns>
        public string CredentialStr()
        {
            return string.Format(" UserName='{0}' and Password='{1}'",UserName,Password);
        }
    }
}
