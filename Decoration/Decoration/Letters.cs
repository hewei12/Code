using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 
    /// </summary>
    public class Letters:Decorator
    {
        public override void ToDressUp()
        {
            base.ToDressUp();
            Console.WriteLine("Letter........................."); 
        }
    }
}
