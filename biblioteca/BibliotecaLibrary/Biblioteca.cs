using System.ComponentModel;

namespace BibliotecaLibrary
{
    public class Biblioteca
    {
        public BindingList<Risorsa> libreria { get; }

        public Biblioteca()
        {
            this.libreria = new BindingList<Risorsa>();

        }

        public void addRisorsa(Risorsa r)
        {
            libreria.Add(r);
        }

        public bool removeRisorsa(Risorsa r)
        {
            return libreria.Remove(r);
        }

        public double calcolaIncassoTotale()
        {
            return libreria.Sum(r => r.calcolaPrestito());
        }
    }
}
