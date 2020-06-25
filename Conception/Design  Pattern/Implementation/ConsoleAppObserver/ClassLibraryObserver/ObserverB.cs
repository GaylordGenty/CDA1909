using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObserver
{
    public class ObserverB : IObserver
    {
        public void Actualiser(ISujet sujet)
        {
            if ((sujet as Sujet).Com == "On m'observe...")
            {
                Console.WriteLine("C'est inquiétant...");
            }
        }

        public override string ToString()
        {
            return "ObserverB";
        }
    }
}
