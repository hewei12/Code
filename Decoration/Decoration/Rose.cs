using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 玫瑰花
    /// </summary>
    public class Rose: Decorator
    {
        public override void ToDressUp()
        {
            base.ToDressUp();
            Console.WriteLine("Rose....................");
        }
    }
}
