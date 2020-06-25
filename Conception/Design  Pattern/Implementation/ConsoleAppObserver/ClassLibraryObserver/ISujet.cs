using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObserver
{
    public interface ISujet
    {
        void AjouterObserver(IObserver obs);
        void SuprimerObserver(IObserver obs);
        void NotifierObserver();
    }
}
