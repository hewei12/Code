using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    /// <summary>
    /// 装饰类
    /// </summary>
    public class Decorator : DressUp
    {
        protected DressUp dressUp = null;
        public void SetDressUp(DressUp du)
        {
            this.dressUp = du;
        }

        public override void ToDressUp()
        {
            this.dressUp.ToDressUp();
        }
    }
}
