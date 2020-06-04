using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Ressources
    {
        string titre;
        int caution;
        Emplacement emp;
        Livre livre;
        Revue revue;

        public Ressources()
        {

        }
        public Ressources(string titre, int caution, Emplacement emp)
        {
            this.Titre = titre;
            this.Caution = caution;
            this.Emp = emp;
        }

        public Ressources(string titre, int caution, Emplacement emp, Livre livre)
        {
            this.Titre = titre;
            this.Caution = caution;
            this.Emp = emp;
            this.Livre = livre;
        }

        public Ressources(string titre, int caution, Emplacement emp, Revue revue)
        {
            this.Titre = titre;
            this.Caution = caution;
            this.Emp = emp;
            this.Revue = revue;
        }

        public string Titre { get => titre; set => titre = value; }
        public int Caution { get => caution; set => caution = value; }
        internal Emplacement Emp { get => emp; set => emp = value; }
        internal Livre Livre { get => livre; set => livre = value; }
        internal Revue Revue { get => revue; set => revue = value; }
    }
}
