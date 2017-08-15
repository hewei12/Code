using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCase
{
    public class Adapter:NokiaCharge
    {
        protected MotolaCharge _mc;
        public Adapter(MotolaCharge mc)
        {
            _mc = mc;
        }
        public void Ncharge()
        {
            _mc.Mcharge();
        }
    }
}
