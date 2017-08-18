using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseReflection
{
    public class AccessDepartment:IDepartment
    {
        public void Insert(Department dept)
        {
            Console.WriteLine();
        }

        public Department GetDept(string id)
        {
            return new Department();
        }
    }
}
