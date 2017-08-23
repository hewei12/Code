using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase1
{
    public class CardCredential:ICredential
    {
        /// <summary>
        /// 卡片
        /// </summary>
        public string Card { get; set; }
        /// <summary>
        /// 打卡验证字符串
        /// </summary>
        /// <returns></returns>
        public string CredentialStr()
        {
            return string.Format(" Card='{0}'",Card);
        }
    }
}
