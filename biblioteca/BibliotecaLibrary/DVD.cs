using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaLibrary
{
    public class DVD : Risorsa
    {
        public int durataInMinuti {  get; }


        public DVD(int durataInMinuti, int codice, string titolo, int giorniPrestito) : base(codice, titolo, giorniPrestito)
        {
            this.durataInMinuti = durataInMinuti;
        }

        public override double calcolaPrestito()
        {
            return (1.20 * this.giorniPrestito + 0.02 * this.durataInMinuti);
        }

    }
}

