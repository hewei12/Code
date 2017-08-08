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
    class ConcreteDataBaseProduct:DataBaseProduct
    {
        public override void WriteLogToDataBase()
        {
            Console.WriteLine("通过数据库记录日志..............");    
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class ConcreteTextProduct:TextProduct
    {
        public override void WriteLogToText()
        {
            Console.WriteLine("通过文本记录日志..................");    
        }
    }
}
