using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMediaCase
{
    abstract class AbstractMediaFactory
    {
        public abstract AbstractAudioMedia GetAudioMedia();
        public abstract AbstracVedioMedia GetVedioMedia();
    }
}
