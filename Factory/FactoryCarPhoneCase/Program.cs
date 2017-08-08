using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCarPhoneCase
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMakeFactory aa = new ConcreteMakeFactory();
            AbstractMobile mobile = aa.CreateMobile();
            string mobileName = mobile.Name;
            AbstractCar car = aa.CreateCar();
            string carName = car.Name;

        }
    }
}
