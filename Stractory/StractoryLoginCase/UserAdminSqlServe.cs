using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase
{
    public class UserAdminSqlServe:IUserAdmin
    {
        #region 属性 字段
        private string _userName;
        private string _password;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public UserAdminSqlServe(string userName,string password)
        {
            _userName = userName;
            _password = password;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public int Login(StractoryContext context)
        {
            string sql =string.Format("select userid from users where UserName='{0}' and Password='{1}'",UserName,Password);
            Console.WriteLine(string.Format("{0}性别为{1}登录成功...", context.Name, context.Sex));
            return 0;
        }
    }
}
