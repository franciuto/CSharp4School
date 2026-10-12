using System.ComponentModel;

namespace WinFormsLibraryParcoVeicoli
{
    public class Flotta
    {
        // BindingList (come in WinFormsLibraryScuola): la DataGridView si aggiorna da sola su Add/Remove
        private BindingList<Veicolo> veicoli;

        public Flotta()
        {
            veicoli = new BindingList<Veicolo>();
        }

        public BindingList<Veicolo> Veicoli { get => veicoli; }

        public void AggiungiVeicolo(Veicolo veicolo)
        {
            veicoli.Add(veicolo);
        }

        public void RimuoviVeicolo(Veicolo veicolo)
        {
            veicoli.Remove(veicolo);
        }

        // nella library niente Console: restituisce il testo e chi la usa decide come mostrarlo
        public string VisualizzaFlotta()
        {
            if (veicoli.Count == 0)
            {
                return "Flotta vuota.";
            }

            return string.Join(Environment.NewLine, veicoli.Select(veicolo =>
                $"{veicolo.GetType().Name} - {veicolo.StampaDettagli()}, Costo manutenzione: {veicolo.CalcolaCostoManutenzione():F2} €"));
        }

        public double CalcolaCostoTotaleManutenzione()
        {
            return veicoli.Sum(veicolo => veicolo.CalcolaCostoManutenzione());
        }

        public static Flotta GetFlotta()
        {
            Flotta flotta = new Flotta();
            flotta.AggiungiVeicolo(new Auto("AB123CD", "Fiat", "Panda", 45000, 5));
            flotta.AggiungiVeicolo(new Auto("EF456GH", "Volkswagen", "Golf", 82000, 3));
            flotta.AggiungiVeicolo(new Camion("IL789MN", "Iveco", "Daily", 120000, 3.5));
            return flotta;
        }
    }
}
