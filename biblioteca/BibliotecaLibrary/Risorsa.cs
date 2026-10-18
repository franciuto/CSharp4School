using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaLibrary
{
    public abstract class Risorsa
    {
        public int codice { get; }
        public string titolo { get; }
        public int giorniPrestito { get; }
        public double CostoPrestito => calcolaPrestito();

        public Risorsa(int codice, string titolo, int giorniPrestito)
        {
            this.codice = codice;
            this.titolo = titolo;
            this.giorniPrestito = giorniPrestito;
        }

        public abstract double calcolaPrestito();

        // potevo anche fare virtual e non mettere la classe abstract
        // public virtual int calcolaPrestito() => giorniPrestito;
        // in questo caso è meglio abstract tanto non la devo istanziare
    }
}
