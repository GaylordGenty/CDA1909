using System;
using System.Collections.Generic;
using System.Text;

namespace CLibrary_ModificationVolume
{
    public class VolumeChangeEvent
    {
        private int newVolume;

        public VolumeChangeEvent(Object source, int newVolume)
        {
            this.newVolume = newVolume;
        }

        public int NewVolume { get => newVolume;}
    }
}
