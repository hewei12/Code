using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase
{
    /// <summary>
    /// 策略上下文
    /// </summary>
    public class StractoryContext
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        private IUserAdmin _iuserAdmin;

        /// <summary>
        /// 上下文
        /// </summary>
        /// <param name="iud"></param>
        public StractoryContext(IUserAdmin iud)
        {
            _iuserAdmin = iud;
        }


        /// <summary>
        /// 设置策略
        /// </summary>
        public void SetUp()
        {
            _iuserAdmin.Login(this);
        }
    }
}
