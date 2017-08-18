using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseReflection
{
    public class SqlServerUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine();
        }

        public User GetUser(string id)
        {
            return new User();
        }
    }
}
