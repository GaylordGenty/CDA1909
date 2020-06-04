using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Revue
    {
        int numeroVolume;
        DateTime dateParution;


        public Revue()
        {

        }

        public Revue(int numeroVolume, DateTime dateParution)
        {
            this.NumeroVolume = numeroVolume;
            this.DateParution = dateParution;
        }

        public int NumeroVolume { get => numeroVolume; set => numeroVolume = value; }
        public DateTime DateParution { get => dateParution; set => dateParution = value; }
    }
}
