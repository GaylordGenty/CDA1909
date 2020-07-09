using System;
using System.Collections.Generic;
using System.Text;

namespace CLibrary_ModificationVolume
{
    public interface IVolumeModel
    {
        void AjouterListener(IVolumeListener listener);
        void SuprimerListener(IVolumeListener listener);
        void NotificationListener();
    }
}
