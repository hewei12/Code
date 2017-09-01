using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCase
{
    /// <summary>
    /// 装饰类
    /// </summary>
    public class Decorator : DecorationBase
    {

        protected DecorationBase _db = null;


        public void SetDecorator(DecorationBase db)
        {
            this._db = db;
        }

        public override decimal Cost()
        {
            return this._db.Cost();
        }

        public override string GetDescription()
        {
            return this._db.GetDescription();
        }
    }
}
