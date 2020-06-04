using System;

namespace ClassLibrary
{
    public class Utilisateur
    {
        string nom;
        int caution;

        public Utilisateur()
        {

        }

        public Utilisateur(string nom, int caution)
        {
            this.Nom = nom;
            this.Caution = caution;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Caution { get => caution; set => caution = value; }
    }
}
