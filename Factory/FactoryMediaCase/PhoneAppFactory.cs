using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMediaCase
{
    class PhoneAppFactory:AbstractMediaFactory
    {
        public override AbstractAudioMedia GetAudioMedia()
        {
            return new ConcreteAudio(); 
        }

        public override AbstracVedioMedia GetVedioMedia()
        {
            return new ConcreteVedio();
        }
    }
}
