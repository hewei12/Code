using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseReflection
{
    public interface IDepartment
    {
        void Insert(Department dept);
        Department GetDept(string id);
    }
}
