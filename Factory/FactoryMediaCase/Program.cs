using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMediaCase
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMediaFactory aa = new PhoneAppFactory();
            AbstractAudioMedia bb = aa.GetAudioMedia();
            bb.Play();
            AbstracVedioMedia cc = aa.GetVedioMedia();
            cc.Play();
        }
    }
}
