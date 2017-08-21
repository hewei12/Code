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
    public interface INewsPaper
    {
        void Register(ISubcribe np);
        void Remove(ISubcribe np);
        void Sender();
    }
}
