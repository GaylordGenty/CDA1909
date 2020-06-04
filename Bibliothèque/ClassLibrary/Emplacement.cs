using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Emplacement
    {
        int travee, etagere, niveau;

        public Emplacement()
        {

        }

        public Emplacement(int travee, int etagere, int niveau)
        {
            this.Travee = travee;
            this.Etagere = etagere;
            this.Niveau = niveau;
        }

        public int Travee { get => travee; set => travee = value; }
        public int Etagere { get => etagere; set => etagere = value; }
        public int Niveau { get => niveau; set => niveau = value; }
    }
}
