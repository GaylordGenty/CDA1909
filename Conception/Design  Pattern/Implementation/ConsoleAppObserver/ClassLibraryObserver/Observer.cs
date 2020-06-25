using System;

namespace ClassLibraryObserver
{
    public class Observer : IObserver
    {
        public void Actualiser(ISujet sujet)
        {
            if ((sujet as Sujet).State < 3)
            {
                Console.WriteLine("Observer  A : J'ai une petite valeur...");
            }
        }

        public override string ToString()
        {
            return "Observer";
        }
    }
}
