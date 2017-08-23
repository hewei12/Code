using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase
{
    public class UserAdminCard : IUserAdmin
    {
        #region 属性 变量
        private string _card;

        public string Card
        {
            get { return _card; }
            set { _card = value; }
        }
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="card"></param>
        public UserAdminCard(string card)
        {
            _card = card;
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="context">公用的上下文信息</param>
        /// <returns></returns>
        public int Login(StractoryContext context)
        {
            string sql = string.Format("select userid from Card where cardNo='{0}'", Card);
            Console.WriteLine(string.Format("{0}性别为{1}成功登录了系统"));
            return 0;
        }
    }
}
