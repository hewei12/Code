using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            IDepartment a = DataAccess.CreateDepartment();
            a.GetDept("1");

            IUser b = DataAccess.CreateUser();
            b.GetUser("2");
        }
    }
}
