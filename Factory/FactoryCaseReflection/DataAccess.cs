using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseReflection
{
    public class DataAccess
    {
        public static IUser CreateUser()
        {
            return (IUser)Assembly.Load("FactoryCaseReflection").CreateInstance("FactoryCaseReflection.SqlServerUser");
        }

        public static IDepartment CreateDepartment()
        {
            return (IDepartment)Assembly.Load("FactoryCaseReflection").CreateInstance("FactoryCaseReflection.AccessDepartment");
        }
    }
}
