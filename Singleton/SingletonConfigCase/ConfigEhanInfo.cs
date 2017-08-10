using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConfigCase
{
    /// <summary>
    /// 配置类型（饿汉）
    /// </summary>
    public class ConfigEhanInfo
    {
        private static ConfigEhanInfo singleton = new ConfigEhanInfo();

        private ConfigEhanInfo() { }
        public static ConfigEhanInfo GetInstance()
        {
            singleton.Email = "807335524@qq.com";
            return singleton;
        }
        public string Email { get; set; }
        public string EmailUser { get; set; }
        public string EmailPass { get; set; }
    }
}
