using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 
    /// </summary>
    abstract class DataBaseProduct
    {
        public abstract void WriteLogToDataBase();
    }
    /// <summary>
    /// 
    /// </summary>
    abstract class TextProduct
    {
        public abstract void WriteLogToText();
    }
}
