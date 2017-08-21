using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryCase
{
    class Program
    {
        static void Main(string[] args)
        {
            StractoryContext context = new StractoryContext();
            context.SetStractory(new RadomStractory());
            context.SetUp();
            context.SetStractory(new StreightStractory());
            context.SetUp(); 
        }
    }
}
