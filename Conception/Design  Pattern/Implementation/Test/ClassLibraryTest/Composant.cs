using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
    public abstract class Composant
    {
        protected string nom;
        public int niveau;


        public Composant(string nom)
        {
            this.nom = nom;
        }

        public abstract void operation();

    }
}
