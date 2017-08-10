using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConfigCase
{
    /// <summary>
    /// 配置文件类
    /// </summary>
    public class ConfigInfo
    {
        private static ConfigInfo singleton;
        private static object _lock = new object();

        private ConfigInfo() { }
        public static ConfigInfo GetInstance()
        {
            if(singleton==null)
            {
                lock(_lock)
                {
                    if(singleton==null)
                    {
                        singleton = new ConfigInfo();
                        singleton.Email = "807335524@qq.com";
                    }
                }
            }
            return singleton;
        }

        public string Email { get; set; }
        public string EmailUser { get; set; }
        public string EmailPass { get; set; }

    }
}
