using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaLibrary
{
    public class Libro : Risorsa
    {
        public int numeroPagine {  get; }
        
        public Libro(int numeroPagine, int codice, string titolo, int giorniPrestito) : base(codice, titolo, giorniPrestito)
        {
            this.numeroPagine = numeroPagine;
        }

        public override double calcolaPrestito()
        {
            return (0.50 * this.giorniPrestito + 0.01 * this.numeroPagine);
        }
    }
}
