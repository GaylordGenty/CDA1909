using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Livre
    {
        string auteur;
        int isbn;

        public Livre()
        {

        }

        public Livre(string auteur, int isbn)
        {
            this.Auteur = auteur;
            this.Isbn = isbn;
        }

        public string Auteur { get => auteur; set => auteur = value; }
        public int Isbn { get => isbn; set => isbn = value; }
    }
}
