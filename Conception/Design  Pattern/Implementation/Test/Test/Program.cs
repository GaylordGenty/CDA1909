using ClassLibraryTest;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite comp1 = new Composite("comp1");
            Composite comp2 = new Composite("comp2");
            Feuille feu1 = new Feuille("Feuille 1");
            Feuille feu2 = new Feuille("Feuille 2");
            comp1.AjouterComposant(comp2);
            comp1.AjouterComposant(feu1);
            comp2.AjouterComposant(feu2);

            comp1.operation();
            Console.ReadLine();

        }
    }
}
