using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace CLibrary_ModificationVolume
{
    public interface IVolumeListener
    {
        void VolumeChanged(IVolumeModel model);
    }
}
