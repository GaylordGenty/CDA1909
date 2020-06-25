using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObserver
{
    public class Sujet : ISujet
    {
        List<string> listMots = new List<string>() {
            "Je suis un Sujet.", 
            "Je ne suis pas un Sujet.",
            "Être ou ne pas être un Sujet.",
            "On m'observe...",
            "Rien à dire."};
        

        public int State { get; set; } = -0;
        public string Com { get; set; } = null;

        private List<IObserver> _observers = new List<IObserver>();

        public void AjouterObserver(IObserver observer)
        {
            //Console.WriteLine("Subject: Ajout de l'observer "+ observer.ToString());
            this._observers.Add(observer);
        }

        public void SuprimerObserver(IObserver observer)
        {
            this._observers.Remove(observer);
            //Console.WriteLine("Subject: Supression d'un observer " + observer.ToString());
        }

        public void NotifierObserver()
        {
            Console.WriteLine("Notification observers...");

            foreach (var observer in _observers)
            {
                observer.Actualiser(this);
            }
        }

        public void Affichage()
        {
            
            this.State = new Random().Next(0, 10);
            this.Com = listMots[new Random().Next(0, 4)];

            Console.WriteLine("Ma valeur est de : "+this.State);
            Console.WriteLine(this.Com);
            this.NotifierObserver();

        }
    }
}
