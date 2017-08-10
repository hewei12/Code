using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 经典模式
    /// </summary>
    public class ClassicSingleton
    {
        /// <summary>
        /// 静态变量
        /// </summary>
        private static ClassicSingleton singleton;
        private ClassicSingleton() { }
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <returns></returns>
        public static ClassicSingleton GetInstance()
        {
            if (singleton == null)
            {
                return singleton = new ClassicSingleton();
            }
            return singleton;
        }
    }

    public class ClassicSingleton<T> where T : class, new()
    {
        private static T t = null;
        private static object _lock = new object();

        /// <summary>
        /// 方法
        /// </summary>
        /// <returns></returns>
        public static T GetInstance()
        {
            if (t == null)
            {
                lock (_lock)
                {
                    t = t ?? new T();//如果t==null 则new T() 否则 返回t
                }
            }
            return t;
        }
        /// <summary>
        /// 属性
        /// </summary>
        public static T Current
        {
            get
            {
                if (t == null)
                {
                    lock(_lock)
                    {
                        t = t ?? new T();
                    }
                } 
                return t;
            }
        }
    }
}
