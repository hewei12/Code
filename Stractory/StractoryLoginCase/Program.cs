using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserAdmin uc = new UserAdminCard("NK001");
            StractoryContext context = new StractoryContext(uc);
            context.SetUp();

            IUserAdmin uass = new UserAdminSqlServe("001","123456");
            StractoryContext context1 = new StractoryContext(uass);
            context1.SetUp();
        }
    }
}
