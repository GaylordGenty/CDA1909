using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibraryTest;

namespace ClassLibraryTest
{
    public class Composite : Composant
    {
        
        private List<Composant> composants;

        private List<Composant> Composants { get => composants;  }

        /// <summary>
        /// Le mot clé base sert à accéder aux membres de la classe de base à partir d’une classe dérivée.
        /// </summary>
        /// <param name="nom"></param>
        public Composite(string nom) : base(nom)
        {
            composants = new List<Composant>();
        }

        public override void operation()
        {
            string temp = "";

            for (int i = 0; i < niveau; i++)
            {
                temp += "-";
            }

            Console.WriteLine(temp + "Composite : " + nom);

            foreach (Composant cp in composants)
            {
                cp.operation();
            }
        }

        public void AjouterComposant(Composant _composant)
        {
            _composant.niveau = this.niveau+1;
            composants.Add(_composant);
        }
    }
}
