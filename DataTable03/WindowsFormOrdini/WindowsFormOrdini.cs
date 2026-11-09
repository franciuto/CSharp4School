using DataForm03_WindowsForm;
using DataTable03_Library;

namespace WindowsFormOrdini
{
    public partial class WindowsFormOrdini : Form
    {
        public WindowsFormOrdini()
        {
            InitializeComponent();
            var dati = new Dati();

            GridViewOrdini.DataSource = dati.GetOrdini();
        }

        private void btnVisualizzaArticoli_Click(object sender, EventArgs e)
        {
            if (GridViewOrdini.CurrentRow != null)
            {
                var ordineSelezionato = Convert.ToInt32(GridViewOrdini.CurrentRow.Cells["ID Ordine"].Value);

                var formArticoli = new WindowsFormArticoli(ordineSelezionato);
                formArticoli.ShowDialog(this);
            } 
            else
            {
                MessageBox.Show("Seleziona un ordine per visualizzare gli articoli.");
            }


        }
    }
}
