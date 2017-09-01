using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 具体类
    /// </summary>
    public class MrLi : DressUp
    {
        public const string name = "liu mou";

        /// <summary>
        /// 开始打扮
        /// </summary>
        public override void ToDressUp()
        {
            Console.WriteLine("{0}开始打扮...................", name);
        }
    }
}
