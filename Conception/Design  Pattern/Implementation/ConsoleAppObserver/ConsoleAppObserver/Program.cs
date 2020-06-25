using System;
using ClassLibraryObserver;

namespace ConsoleAppObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var sujet = new Sujet();            
            var observer = new Observer();
            var observerB = new ObserverB();
            Console.ForegroundColor = ConsoleColor.White;

            sujet.AjouterObserver(observer);
            sujet.AjouterObserver(observerB);

            for (int i = 0; i < 10; i++)
            {                
                sujet.Affichage();                
                Console.WriteLine(Environment.NewLine);
            }

            sujet.SuprimerObserver(observer);
            sujet.SuprimerObserver(observerB);


            Console.ReadLine();
        }
    }
}
