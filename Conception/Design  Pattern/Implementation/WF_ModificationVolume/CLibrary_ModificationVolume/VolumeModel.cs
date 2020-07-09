using System;
using System.Collections.Generic;

namespace CLibrary_ModificationVolume
{
    public class VolumeModel : IVolumeModel
    {
        private int volume;
        private List<IVolumeListener> _listenerList = new List<IVolumeListener>();

        public VolumeModel()
        {
            volume = 0;
        }

        public VolumeModel(int volume)
        {
            this.volume = volume;
            
        }

        public int Volume { get => volume; set => volume = value; }

        public void AjouterListener(IVolumeListener _listener)
        {
            this._listenerList.Add(_listener);
        }

        public void SuprimerListener(IVolumeListener _listener)
        {
            this._listenerList.Remove(_listener);
        }

        public void NotificationListener()
        {
            foreach (var listener in _listenerList)
            {
                listener.VolumeChanged(this);
            }
        }

        public void Affichage()
        {
            
        }
    }
}
