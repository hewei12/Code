using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCase
{
    class Program
    {
        static void Main(string[] args)
        {
            MotolaCharge mc = new Motola("fds");
            mc.Mcharge();
            Adapter at = new Adapter(mc);
            at.Ncharge();
        }
    }
}
