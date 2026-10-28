using System.Data;
using System.Globalization;
using WinFormsLibraryAlbum;

namespace WinFormsAppAlbum
{
    public partial class FormAlbum : Form
    {
        Dati dati;
        DataTable albumVisualizzati;

        public FormAlbum()
        {
            InitializeComponent();
            dati = new Dati();
            albumVisualizzati = new DataTable();
            comboBoxCategoria.SelectedIndex = 0;
        }

        private void buttonMostraAlbum_Click(object sender, EventArgs e)
        {
            albumVisualizzati = dati.AlbumDiCategoria(comboBoxCategoria.Text);
            dataGridViewAlbum.DataSource = albumVisualizzati;
            dataGridViewAlbum.Columns["ID"]!.FillWeight = 65;
            dataGridViewAlbum.Columns["Titolo"]!.FillWeight = 220;
            dataGridViewAlbum.Columns["Autore"]!.FillWeight = 130;
            dataGridViewAlbum.Columns["Anno"]!.FillWeight = 55;
            dataGridViewAlbum.Columns["Categoria"]!.FillWeight = 75;
            dataGridViewAlbum.Columns["DurataMinuti"]!.FillWeight = 95;
            dataGridViewAlbum.Columns["DurataMinuti"]!.HeaderText = "Durata (minuti)";

            labelAlbumPiuVecchio.Text = "Album più vecchio: —";
            labelMediaDurata.Text = "Durata media: —";
            buttonCalcolaStatistiche.Enabled = albumVisualizzati.Rows.Count > 0;
            AggiornaBrani();
        }

        private void buttonCalcolaStatistiche_Click(object sender, EventArgs e)
        {
            string titolo = dati.TitoloAlbumPiuVecchio(albumVisualizzati);
            double media = dati.MediaDurataAlbum(albumVisualizzati);

            labelAlbumPiuVecchio.Text = $"Album più vecchio: {titolo}";
            labelMediaDurata.Text = $"Durata media: {media.ToString("F2", CultureInfo.GetCultureInfo("it-IT"))} minuti";
        }

        private void dataGridViewAlbum_SelectionChanged(object sender, EventArgs e)
        {
            AggiornaBrani();
        }

        private void AggiornaBrani()
        {
            if (dataGridViewAlbum.SelectedRows.Count == 0)
            {
                dataGridViewBrani.DataSource = null;
                labelBrani.Text = "Brani: seleziona un album nella griglia";
                return;
            }

            DataGridViewRow albumSelezionato = dataGridViewAlbum.SelectedRows[0];
            int idAlbum = Convert.ToInt32(albumSelezionato.Cells["ID"].Value);
            dataGridViewBrani.DataSource = dati.BraniAlbum(idAlbum);
            dataGridViewBrani.Columns["IDAlbum"]!.Visible = false;
            labelBrani.Text = $"Brani di: {albumSelezionato.Cells["Titolo"].Value}";
        }
    }
}
