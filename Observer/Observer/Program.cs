using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubcribe sb = new Subcribe("fs");
            NewsPaper np = new NewsPaper();
            np.Register(sb);
            ISubcribe sb1 = new Subcribe("fd");
            np.Register(sb1);
            np.Sender();
            //np.Notify();
            Console.ReadKey();
        }
    }
}
