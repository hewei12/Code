using CacheManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache22 = CacheFactory.Build("getStartedCache", settings =>
             {
                 settings.WithSystemRuntimeCacheHandle("handleName");
             });

            cache.Add("keyA", "valueA");
            cache.Add("keyB", 23);
            cache.Update("keyB", v => 42);
            Console.WriteLine("KeyA is" + cache.Get("keyA"));
            Console.WriteLine("KeyB is" + cache.Get("KeyB"));
            cache.Remove("keyA");
            Console.WriteLine("keyA removed?" + (cache.Get("keyA") == null).ToString());
            Console.WriteLine("We are done.......");
            Console.ReadKey();

            var cache = CacheFactory.Build<int>("myCache", settings =>
             {
                 settings.WithSystemRuntimeCacheHandle("inProcessCache")
                 .And
                 .WithRedisConfiguration("redis", config =>
                  {
                      config.WithAllowAdmin()
                            .WithDatabase(0)
                            .WithEndpoint("localhost", 6379);
                  })
                 .WithMaxRetries(1000)
                 .WithRetryTimeout(100)
                 .WithRedisBackplane("redis")
                 .WithRedisCacheHandle("redis", true);

             });

            var cache1 = CacheFactory.Build<int>("myCache",settings=>
            {
                settings.WithUpdateMode(CacheUpdateMode.Up)
                .WithSystemRuntimeCacheHandle("inProcessCache")
                .WithExpiration(ExpirationMode.Sliding, TimeSpan.FromSeconds(60))
                .And
                .WithRedisConfiguration("redis", config =>
                 {
                     config.WithAllowAdmin()
                     .WithDatabase(0)
                     .WithEndpoint("localhost", 6379);
                 })
               
                .WithMaxRetries(1000)
                .WithRetryTimeout(100)
                .WithRedisBackplane("redis")
                .WithRedisCacheHandle("redis", true);
            });

            var cache3 = CacheFactory.Build("cacheName", settings => settings
               .WithSystemRuntimeCacheHandle("handleName")
               .EnableStatistics()
               .EnablePerformanceCounters());
            foreach (var item in cache3.CacheHandles)
            {
                var stat = item.Stats;
                Console.WriteLine(string.Format("Items:{0},Hits:{1},Miss:{2}",stat.GetStatistic(CacheManager.Core.Internal.CacheStatsCounterType.Items)
                    ,stat.GetStatistic(CacheManager.Core.Internal.CacheStatsCounterType.Hits)
                    ,stat.GetStatistic(CacheManager.Core.Internal.CacheStatsCounterType.Misses)
                    ));
            }

        }

        //public enum ExpirationMode
        //{
        //    None = 0,
        //    Sliding = 1,
        //    Absolute = 2

        //}

        //public enum CacheUpdateMode
        //{
        //    None=0,
        //    Full=1,
        //    Up=2
        //}


    }
}
