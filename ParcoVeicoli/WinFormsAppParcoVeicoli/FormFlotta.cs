using WinFormsLibraryParcoVeicoli;

namespace WinFormsAppParcoVeicoli
{
    public partial class FormFlotta : Form
    {
        Flotta flotta;
        public FormFlotta()
        {
            InitializeComponent();
            flotta = Flotta.GetFlotta();
        }

        private void buttonVisualizzaFlotta_Click(object sender, EventArgs e)
        {
            dataGridViewVeicoli.DataSource = flotta.Veicoli;
        }

        private void dataGridViewVeicoli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dettagli.Index && e.RowIndex >= 0)
            {
                Veicolo veicolo = flotta.Veicoli[e.RowIndex];
                FormDettagliVeicolo formDettagli = new FormDettagliVeicolo(veicolo);
                formDettagli.ShowDialog();
            }
        }

        private void buttonRimuoviVeicolo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeicoli.CurrentRow?.DataBoundItem is Veicolo veicolo)
            {
                flotta.RimuoviVeicolo(veicolo);
            }
            else
            {
                MessageBox.Show("Seleziona un veicolo dalla tabella.");
            }
        }

        private void buttonCostoTotale_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Costo totale manutenzione: {flotta.CalcolaCostoTotaleManutenzione():F2} €");
        }

        private void buttonInserisciAuto_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxChilometri.Text, out double chilometri) || !int.TryParse(textBoxNumeroPorte.Text, out int numeroPorte))
            {
                MessageBox.Show("Chilometri e numero porte devono essere numeri.");
                return;
            }
            flotta.AggiungiVeicolo(new Auto(textBoxTarga.Text, textBoxMarca.Text, textBoxModello.Text, chilometri, numeroPorte));
        }

        private void buttonInserisciCamion_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxChilometri.Text, out double chilometri) || !double.TryParse(textBoxCapacitaCarico.Text, out double capacitaCarico))
            {
                MessageBox.Show("Chilometri e capacità di carico devono essere numeri.");
                return;
            }
            flotta.AggiungiVeicolo(new Camion(textBoxTarga.Text, textBoxMarca.Text, textBoxModello.Text, chilometri, capacitaCarico));
        }

    }
}
