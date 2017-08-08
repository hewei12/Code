using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    class CreateEquipment
    {
        private AbstractCar _car;
        private AbstractPackage _package;
        public CreateEquipment(AbstractEquipmentFactory factory)
        {
            _car = factory.CreateAbstractCar();
            _package = factory.CreateAbstractPackage();
        }

        public void ReadyEquipment()
        {
            Console.WriteLine("{0}-{1}",_car.Name,_package.Size);
        }
    }
}
