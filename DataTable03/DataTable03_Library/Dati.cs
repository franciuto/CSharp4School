using System;
using System.Collections.Generic;
using System.Data;

namespace DataTable03_Library
{
    public class Dati
    {
        private DataTable ArticoliToTable(List<Articolo> articoli)
        {
            var table = new DataTable("Articoli");
            table.Columns.Add("Nome Articolo", typeof(string));
            table.Columns.Add("ID Ordine", typeof(int));
            table.Columns.Add("Importo", typeof(decimal));

            foreach (var a in articoli)
                table.Rows.Add(a.nomeArticolo, a.idOrdine, a.importo);

            return table;
        }

        private DataTable OrdiniToTable(List<Ordine> ordini)
        {
            var table = new DataTable("Ordini");
            table.Columns.Add("ID Ordine", typeof(int));
            table.Columns.Add("ID Cliente", typeof(int));
            table.Columns.Add("Data", typeof(DateTime));

            foreach (var o in ordini)
                table.Rows.Add(o.idOrdine, o.idCliente, o.data);

            return table;
        }

        public DataTable GetArticoli()
        {
            return ArticoliToTable(new Articolo().GetSampleData());
        }

        public DataTable GetOrdini()
        {
            return OrdiniToTable(new Ordine().GetSampleData());
        }

        public DataTable ArticoliPerOrdine(int idOrdine)
        {
            var articoli = new Articolo().GetSampleData();
            return ArticoliToTable(articoli.FindAll(x => x.idOrdine == idOrdine));
        }
    }
}