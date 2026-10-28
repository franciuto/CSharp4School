using System.Data;

namespace WinFormsLibraryAlbum
{
    public class Dati
    {
        // la DataTable diventa la DataSource della DataGridView: ogni colonna aggiunta qui è una colonna della griglia
        public DataTable AlbumDiCategoria(string categoria)
        {
            DataTable tabella = new DataTable("Album");
            tabella.Columns.Add("ID", typeof(int));
            tabella.Columns.Add("Titolo", typeof(string));
            tabella.Columns.Add("Autore", typeof(string));
            tabella.Columns.Add("Anno", typeof(int));
            tabella.Columns.Add("Categoria", typeof(string));
            tabella.Columns.Add("DurataMinuti", typeof(int));

            foreach (Album album in Album.GetSampleData())
            {
                if (string.Equals(album.Categoria, categoria, StringComparison.OrdinalIgnoreCase))
                {
                    tabella.Rows.Add(album.ID, album.Titolo, album.Autore, album.Anno, album.Categoria, album.DurataMinuti);
                }
            }

            return tabella;
        }

        public string TitoloAlbumPiuVecchio(DataTable albumVisualizzati)
        {
            if (albumVisualizzati.Rows.Count == 0)
            {
                return "";
            }

            DataRow piuVecchio = albumVisualizzati.AsEnumerable().OrderBy(album => (int)album["Anno"]).First();

            return (string)piuVecchio["Titolo"];
        }

        public double MediaDurataAlbum(DataTable albumVisualizzati)
        {
            if (albumVisualizzati.Rows.Count == 0)
            {
                return 0;
            }

            return albumVisualizzati.AsEnumerable().Average(album => (int)album["DurataMinuti"]);
        }

        public DataTable BraniAlbum(int idAlbum)
        {
            DataTable tabella = new DataTable("Brani");
            tabella.Columns.Add("IDAlbum", typeof(int));
            tabella.Columns.Add("Titolo", typeof(string));

            foreach (Brani brano in Brani.GetSampleData())
            {
                if (brano.IDAlbum == idAlbum)
                {
                    tabella.Rows.Add(brano.IDAlbum, brano.Titolo);
                }
            }

            return tabella;
        }
    }
}
