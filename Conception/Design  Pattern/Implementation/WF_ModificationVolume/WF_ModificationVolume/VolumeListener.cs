﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CLibrary_ModificationVolume
{
    public class VolumeListener : IVolumeListener
    {
        public void VolumeChanged(IVolumeModel model)
        {
            return (model as VolumeModel).Volume.ToString();
        }
    }
}
