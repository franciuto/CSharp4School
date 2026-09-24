public class Veicolo
{
    public string Targa { get; set; }
    public string Marca { get; set; }
    public string Modello { get; set; }
    public double ChilometriPercorsi { get; set; }

    public Veicolo(string targa, string marca, string modello, double chilometriPercorsi)
    {
        Targa = targa;
        Marca = marca;
        Modello = modello;
        ChilometriPercorsi = chilometriPercorsi;

    }

    public virtual string StampaDettagli()
    {
        return $"Targa: {Targa}, Marca: {Marca}, Modello: {Modello}, Chilometri percorsi: {ChilometriPercorsi}";
    }

    public virtual double CalcolaCostoManutenzione()
    {
        return ChilometriPercorsi * 0.05;
    }
}