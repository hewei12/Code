using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            MrLi ml = new MrLi();
            Rose rs = new Rose();
            rs.SetDressUp(ml);
            Letters lt = new Letters();
            lt.SetDressUp(rs);
            lt.ToDressUp();
        }
    }
}
