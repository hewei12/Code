using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCase
{
    public interface NokiaCharge
    {
        void Ncharge();
    }

    public class Nokia:NokiaCharge
    {
        public string name;
        public Nokia(string name)
        {
            this.name = name;
        }

        public void Ncharge()
        {
            Console.WriteLine("诺基亚正在充电");
        }
    }
}
