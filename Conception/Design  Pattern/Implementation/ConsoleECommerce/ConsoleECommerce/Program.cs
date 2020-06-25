using System;
using System.Collections.Generic;
using ClassLibraryECommerce;

namespace ConsoleECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduit> panierClient = new List<IProduit>();
            panierClient.Add(new Livre("Les misérable", 35));
        }
    }
}
