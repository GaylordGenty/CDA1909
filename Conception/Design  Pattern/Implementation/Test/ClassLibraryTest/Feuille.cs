using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
        public class Feuille : Composant
        {
        public Feuille(string nom) : base(nom)
        {

        }

        public override void operation()
        {
            string temp = "";

            for (int i = 0; i < niveau; i++)
            {
                temp += "-";
            }

            Console.WriteLine(temp+"Feuille : "+nom);
        }
    }
}
