using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryECommerce
{
    public class Fruit
    {
        private string nom;
        private double poids, prixKg;

        public Fruit(string nom, double poids, double prixKg)
        {
            this.nom = nom;
            this.poids = poids;
            this.prixKg = prixKg;
        }

        public string Nom { get => nom; set => nom = value; }
        public double Poids { get => poids; set => poids = value; }
        public double PrixKg { get => prixKg; set => prixKg = value; }

        public double Accept(IPanier panier)
        {
            return panier.Visit(this);
        }
    }
}
