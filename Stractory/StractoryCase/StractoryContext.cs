using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryCase
{
    public class StractoryContext
    {
        protected AbstractStractory abs;

        public void SetStractory(AbstractStractory abstory)
        {
            this.abs = abstory;
        }

        public void SetUp()
        {
            this.abs.SetUp();
        }
    }
}
