using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stractory
{
    /// <summary>
    /// 自己来决定执行某个行为策略
    /// </summary>
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            base.SetFlyBehavoir(new Fly1());
            base.SetQuearyBehavior(new Queary1());
        }
        public override string DisPlay()
        {
            return "我是一只红头鸭子!";
        }
    }
}
