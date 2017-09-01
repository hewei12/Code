using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            RedTea rt = new RedTea();
            HongTang ht = new HongTang();
            ht.SetDecorator(rt);
            Milk ml = new Milk();
            ml.LevelType = LevelType.Big;
            ml.SetDecorator(ht);
            decimal aa = ml.Cost();
            string bb = ml.GetDescription();
            Console.WriteLine("{0}-{1}", aa, bb);
            Console.ReadKey();
        }
    }
}
