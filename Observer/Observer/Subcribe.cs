using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 
    /// </summary>
    public class Subcribe : ISubcribe
    {
        private string _name = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Subcribe(string name)
        {
            _name = name;
        }
        /// <summary>
        /// 
        /// </summary>
        public void HasNewsPaper()
        {
            Console.WriteLine(_name + "我收到了一个消息..............");
        }
    }
}
