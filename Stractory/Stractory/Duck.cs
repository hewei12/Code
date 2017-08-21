using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stractory
{
    /// <summary>
    /// 基类（鸭）
    /// </summary>
    public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("我会游泳!");
        }

        public abstract string DisPlay();

        protected IFlyBehavior _flyBehavoir;
        protected IQuearyBehavior _queryBehavoir;

        public void SetFlyBehavoir(IFlyBehavior behavior)
        {
            this._flyBehavoir = behavior;
        }

        public void PerformFly()
        {
            this._flyBehavoir.Fly();
        }


        public void SetQuearyBehavior(IQuearyBehavior behavior)
        {
            this._queryBehavoir = behavior;
        }

        public void PerformQueary()
        {
            this._queryBehavoir.Queary();
        }
    }
}
