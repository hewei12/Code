using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory aa = new ConcreteDataBaseFactory();
            DataBaseProduct dp= aa.GetDataBaseProduct();
            TextProduct tp = aa.GetTextProduct();
            dp.WriteLogToDataBase();
            tp.WriteLogToText();
        }
    }
}
