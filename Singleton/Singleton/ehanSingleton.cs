using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class EhanSingleton
    {
        private static readonly EhanSingleton singleton = new EhanSingleton();

        private EhanSingleton() { }

        public static EhanSingleton GetInstance()
        {
            return singleton;
        }
    }
}
