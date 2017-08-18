using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseReflection
{
    public interface IUser
    {
        void Insert(User user);
        User GetUser(string id);
    }
}
