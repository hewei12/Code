using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    abstract class AbstractFactory
    {
        public abstract DataBaseProduct GetDataBaseProduct();

        public abstract TextProduct GetTextProduct();
    }
}
