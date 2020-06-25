using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryECommerce
{
    public class Livre
    {
        private string titre;
        private double prix;

        public Livre(string titre, double prix)
        {
            this.titre = titre;
            this.prix = prix;
        }

        public string Titre { get => titre; set => titre = value; }
        public double Prix { get => prix; set => prix = value; }

        public double Accept(IPanier panier)
        {
            return panier.Visit(this);
        }
    }
}
