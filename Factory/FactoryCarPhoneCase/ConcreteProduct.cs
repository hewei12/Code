using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCarPhoneCase
{
    class ConcreteOuDiCar:AbstractCar
    {
        private string _name = "奥迪";
        public override string Name
        {
            get
            {
                return _name;    
            }
        }

        public override void Run()
        {
            Console.WriteLine("时速达到.......................");    
        }
    }

    class ConcreteNokia:AbstractMobile
    {
        private string _name = "诺基亚";

        /// <summary>
        /// 
        /// </summary>
        public override string Name
        {
            get
            {
                return _name;    
            }

        }

        public override void Call()
        {
            Console.WriteLine("通话质量极佳.........................");
        }
    }
}
