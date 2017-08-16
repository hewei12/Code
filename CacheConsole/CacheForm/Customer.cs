using CacheManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheForm
{
    /// <summary>
    /// 客户类
    /// </summary>
    public class Customer
    {
        private static Customer m_Customer;
        private static ICacheManager<object> manager = null;

        private static List<string> list = new List<string>() { "122", "234", "908" };

        public static Customer Instance
        {
            get
            {
                if (m_Customer == null)
                {
                    m_Customer = new Customer();
                }
                //初始化实例+初始化缓存
                if (manager == null)
                {
                    manager = CacheFactory.Build("getStartedCache", settings =>
                     {
                         settings.WithSystemRuntimeCacheHandle("handleName");
                     });

                    //manager = CacheFactory.Build("getStartedCache", settings =>
                    // {
                    //     settings.WithSystemRuntimeCacheHandle("handleName")
                    //     .And
                    //     .WithRedisConfiguration("redis", config =>
                    //      {
                    //          config.WithAllowAdmin()
                    //          .WithDatabase(0)
                    //          .WithEndpoint("localhost", 6379);
                    //      })
                    //     .WithMaxRetries(100)
                    //     .WithRetryTimeout(50)
                    //     .WithRedisBackplane("redis")
                    //     .WithRedisCacheHandle("redis", true);
                    // });
                }
                return m_Customer;
            }
        }
        /// <summary>
        /// 获取所有客户信息
        /// </summary>
        /// <returns></returns>
        public List<string> GetAll()
        {
            var value = manager.Get("GetAll") as List<string>;
            if (value == null)
            {
                value = list;
                manager.Add("GetAll", value);
            }
            return value;
        }
        /// <summary>
        /// 插入缓存
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Insert(string name)
        {
            if (!list.Contains(name))
            {
                list.Add(name);
            }
            manager.Update("GetAll", v => list);
            return true;
        }
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Delete(string name)
        {
            if (list.Contains(name))
            {
                list.Remove(name);
            }
            manager.Update("GetAll", v => list);
            return true;
        }

        public void TestCache()
        {
            manager.Put("string", "abcdefg");
            manager.Put("int", 20160);
            manager.Put("decimal", 201.00);
            manager.Put("date", DateTime.Now);
            manager.Put("object", new { ID = 1, Name = "匿名类型" });
        }
    }
}
