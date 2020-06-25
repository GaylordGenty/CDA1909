using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryECommerce
{
    public class Panierlmpl : IPanier
    {
        double IPanier.Visit(Fruit fruit)
        {
            double prix = fruit.PrixKg * fruit.Poids;
            Console.WriteLine("Fruit "+fruit.Nom+" Prix : "+prix.ToString());
            return prix;
        }
        double IPanier.Visit(Livre livre) 
        {
            double prix = livre.Prix;
            if (livre.Prix > 30)
            {
                prix = livre.Prix - 5;
            }
            Console.WriteLine("Livre : "+livre.Titre+" prix : "+prix.ToString()+".");
            return prix;
        }

    }
}
