public class Camion : Veicolo
{
    public double CapacitaCarico { get; set; }

    public Camion(string targa, string marca, string modello, double chilometriPercorsi, double capacitaCarico) : base(targa, marca, modello, chilometriPercorsi)
    {
        CapacitaCarico = capacitaCarico;
    }

    public override string StampaDettagli()
    {
        return base.StampaDettagli() + $", Capacità di carico: {CapacitaCarico} t";
    }

    public override double CalcolaCostoManutenzione()
    {
        return 0.15 * ChilometriPercorsi + 50 * CapacitaCarico;
    }
}