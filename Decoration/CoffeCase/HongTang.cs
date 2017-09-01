using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCase
{
    public class HongTang : Decorator
    {
        public override string GetDescription()
        {
            return base.GetDescription() + "HongTang";
        }

        public override decimal Cost()
        {
            return base.Cost() + (decimal)0.12;
        }
    }
}
