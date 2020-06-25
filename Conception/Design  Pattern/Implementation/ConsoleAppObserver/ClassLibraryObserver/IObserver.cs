using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObserver
{
    public interface IObserver
    {
        void Actualiser(ISujet sujet);
    }
}
