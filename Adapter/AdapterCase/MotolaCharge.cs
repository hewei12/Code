using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCase
{
    public interface MotolaCharge
    {
        void Mcharge();
    }

    public class Motola:MotolaCharge
    {
        public string name;
        public Motola(string name)
        {
            this.name = name;
        }

        public void Mcharge()
        {
            Console.WriteLine("摩托罗拉正在充电");
        }
    }
}
