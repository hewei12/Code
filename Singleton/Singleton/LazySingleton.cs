using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Lazy模式
    /// </summary>
    public class LazySingleton
    {
        private static LazySingleton singleton;
        //定义锁
        private static object _lock = new object();

        private LazySingleton() { }

        public LazySingleton GetInstance()
        {
            if(singleton==null)
            {
                //唯一线程访问
                lock(_lock)
                {
                    if(singleton==null)
                    {
                        return singleton = new LazySingleton();
                    }
                }
            }
            return singleton;
        }

    }
}
