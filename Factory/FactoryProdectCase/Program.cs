using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProdectCase
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCreator ac = new Creator1();
            AbstractProductA apa = ac.CreateProductA();
            apa.DoSomething();
        }
    }
}
