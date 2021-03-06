﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCarPhoneCase
{
    abstract class AbstractCar
    {
        public abstract string Name { get;  }

        public abstract void Run();
    }

    abstract class AbstractMobile
    {
        public abstract string Name { get; }

        public abstract void Call();
    }
}
