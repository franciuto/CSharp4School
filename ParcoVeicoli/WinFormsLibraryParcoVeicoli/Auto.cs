namespace WinFormsLibraryParcoVeicoli
{
    public class Auto : Veicolo
    {

        public int NumeroPorte { get; set; }

        public Auto(string targa, string marca, string modello, double chilometriPercorsi, int numeroPorte) : base(targa, marca, modello, chilometriPercorsi)
        {
            NumeroPorte = numeroPorte;
        }

        public override string StampaDettagli()
        {
            return base.StampaDettagli() + $", Numero di porte: {NumeroPorte}";
        }

        public override double CalcolaCostoManutenzione()
        {
            double costoBase = base.CalcolaCostoManutenzione();
            return costoBase + 100;
        }
    }
}
