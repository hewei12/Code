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
    public class NewsPaper:INewsPaper
    {
        private List<ISubcribe> sublist = new List<ISubcribe>();

        public delegate void NotifyDelegate();
        public event NotifyDelegate NotifyEvent;

        public void Register(ISubcribe sc)
        {
            sublist.Add(sc);
        }

        public void Remove(ISubcribe sc)
        {
            if(sublist.IndexOf(sc)>=0)
            {
                sublist.Remove(sc);
            }
        }

        public void Sender()
        {
            sublist.ForEach(e =>
            {
                e.HasNewsPaper();
                //this.NotifyEvent += e.HasNewsPaper;
            });
        }

        public void Notify()
        {
            if(NotifyEvent!=null)
            {
                NotifyEvent();
            }
        }
    }
}
