using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryPayCase
{
    class Program
    {
        static void Main(string[] args)
        {
            IStractoryPay isp = new DollarPay();
            StractoryContext context = new StractoryContext("zhangsan",3000, isp);
            context.SetUp();

            IStractoryPay ispRmp = new RenMinbiPay();
            StractoryContext contextRmp = new StractoryContext("lishi",2000,ispRmp);
            contextRmp.SetUp();
        }
    }
}
