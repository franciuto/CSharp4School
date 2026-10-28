using System.Data;
using System.Globalization;

public partial class WindowsFormAlbum : Form
{
    private Dati dati;
    private DataTable albumVisualizzati;

    public WindowsFormAlbum()
    {
        dati = new Dati();
        albumVisualizzati = new DataTable();
        InitializeComponent();
        cmbCategoria.SelectedIndex = 0;
    }

    private void btnMostraAlbum_Click(object sender, EventArgs e)
    {
        string categoria = cmbCategoria.SelectedItem.ToString();
        albumVisualizzati = dati.AlbumDiCategoria(categoria);
        dgvAlbum.DataSource = albumVisualizzati;
        dgvAlbum.Columns["ID"].FillWeight = 65;
        dgvAlbum.Columns["Titolo"].FillWeight = 220;
        dgvAlbum.Columns["Autore"].FillWeight = 130;
        dgvAlbum.Columns["Anno"].FillWeight = 55;
        dgvAlbum.Columns["Categoria"].FillWeight = 75;
        dgvAlbum.Columns["DurataMinuti"].FillWeight = 95;
        dgvAlbum.Columns["DurataMinuti"].HeaderText = "Durata (minuti)";

        lblAlbumPiuVecchio.Text = "Album più vecchio: —";
        lblMediaDurata.Text = "Durata media: —";
        btnStatistiche.Enabled = albumVisualizzati.Rows.Count > 0;
        AggiornaBrani();
    }

    private void btnStatistiche_Click(object sender, EventArgs e)
    {
        string titolo = dati.TitoloAlbumPiuVecchio(albumVisualizzati);
        double media = dati.MediaDurataAlbum(albumVisualizzati);

        lblAlbumPiuVecchio.Text = $"Album più vecchio: {titolo}";
        lblMediaDurata.Text = $"Durata media: {media.ToString("F2", CultureInfo.GetCultureInfo("it-IT"))} minuti";
    }

    private void dgvAlbum_SelectionChanged(object sender, EventArgs e)
    {
        AggiornaBrani();
    }

    private void AggiornaBrani()
    {
        if (dgvAlbum.SelectedRows.Count == 0)
        {
            dgvBrani.DataSource = null;
            lblBrani.Text = "Brani: seleziona un album nella griglia";
            return;
        }

        DataGridViewRow albumSelezionato = dgvAlbum.SelectedRows[0];
        int idAlbum = Convert.ToInt32(albumSelezionato.Cells["ID"].Value);
        dgvBrani.DataSource = dati.BraniAlbum(idAlbum);
        dgvBrani.Columns["IDAlbum"].Visible = false;
        lblBrani.Text = $"Brani di: {albumSelezionato.Cells["Titolo"].Value}";
    }
}
