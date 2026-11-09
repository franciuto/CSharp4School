using System;
using System.Collections.Generic;
using System.Text;

namespace DataTable03_Library
{
    internal class Articolo
    {

        internal string nomeArticolo;
        internal int idOrdine;
        internal double importo;

        public Articolo() { }

        public Articolo(string nomeArticolo, int idOrdine, double importo) {
 
            this.nomeArticolo = nomeArticolo;
            this.idOrdine = idOrdine;
            this.importo = importo;
        }

        public List<Articolo> GetSampleData()
        {
            return new List<Articolo>
            {
                new Articolo("Iphone 15", 2012, 1200.20),
                new Articolo("PC Sony intel i7", 2012, 230.45),
                new Articolo("PC Olidata i7", 9020, 320.50),
                new Articolo("Webcam Logitech", 3340, 31.00)
            };
        }
    }
}
