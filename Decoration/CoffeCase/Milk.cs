using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCase
{
    /// <summary>
    /// 牛奶
    /// </summary>
    public class Milk : Decorator
    {
        /// <summary>
        /// 
        /// </summary>
        private LevelType _levelType;
        /// <summary>
        /// 品种
        /// </summary>
        public LevelType LevelType
        {
            get { return _levelType; }
            set { _levelType = value; }
        }
        /// <summary>
        /// 什么东西
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return base.GetDescription() + "Milk";
        }
        /// <summary>
        /// 多少钱
        /// </summary>
        /// <returns></returns>
        public override decimal Cost()
        {
            return GetCost(LevelType);
        }
        /// <summary>
        /// 返回多少钱
        /// </summary>
        /// <param name="lt"></param>
        /// <returns></returns>
        public decimal GetCost(LevelType lt)
        {
            switch(lt)
            {
                case LevelType.Small:
                    return base.Cost() + (decimal)0.2;
                case LevelType.Middle:
                    return base.Cost() + (decimal)0.5;
                case LevelType.Big:
                    return base.Cost() + (decimal)0.9;
                default:
                    return (decimal)0;
            }
        }
    }

    public enum LevelType
    {
        Small,
        Middle,
        Big
    }
}
