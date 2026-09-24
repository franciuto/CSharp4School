public class Flotta
{
    private List<Veicolo> veicoli;

    public Flotta()
    {
        veicoli = new List<Veicolo>();
    }

    public void AggiungiVeicolo(Veicolo veicolo)
    {
        veicoli.Add(veicolo);
    }

    public void VisualizzaFlotta()
    {
        if (veicoli.Count == 0)
        {
            Console.WriteLine("Flotta vuota.");
            return;
        }

        veicoli.ForEach(veicolo =>
            Console.WriteLine($"{veicolo.GetType().Name} - {veicolo.StampaDettagli()}, Costo manutenzione: {veicolo.CalcolaCostoManutenzione():F2} €"));
    }

    public double CalcolaCostoTotaleManutenzione()
    {
        return veicoli.Sum(veicolo => veicolo.CalcolaCostoManutenzione());
    }
}
