using WinFormsLibraryParcoVeicoli;

namespace WinFormsAppParcoVeicoli
{
    public partial class FormDettagliVeicolo : Form
    {
        Veicolo veicolo;
        public FormDettagliVeicolo(Veicolo v)
        {
            InitializeComponent();
            veicolo = v;
            Text = $"{veicolo.Tipo} {veicolo.Targa}";
            labelDettagli.Text = veicolo.StampaDettagli();
            labelCosto.Text = $"Costo manutenzione: {veicolo.CalcolaCostoManutenzione():F2} €";
        }
    }
}
