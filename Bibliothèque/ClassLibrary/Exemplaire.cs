using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Exemplaire
    {
        string codeBarre;
        DateTime dateRetour;
        Ressources res;
        public Exemplaire()
        {

        }

        public Exemplaire(string codeBarre, DateTime dateRetour, Ressources res)
        {
            this.CodeBarre = codeBarre;
            this.DateRetour = dateRetour;
            this.Res = res;
        }

        public string CodeBarre { get => codeBarre; set => codeBarre = value; }
        public DateTime DateRetour { get => dateRetour; set => dateRetour = value; }
        internal Ressources Res { get => res; set => res = value; }
    }
}
