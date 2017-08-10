using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConfigCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式
            var info = ConfigInfo.GetInstance();
            var infoLazy = ConfigEhanInfo.GetInstance();
        }
    }
}
