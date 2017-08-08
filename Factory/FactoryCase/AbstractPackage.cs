using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    abstract class AbstractPackage
    {
        public abstract string Color { get; }

        public abstract int Size { get; }
    }
}
