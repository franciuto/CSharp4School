namespace DataTable03_Library
{
    public class Ordine
    {

        internal int idOrdine;
        internal int idCliente;
        internal string data;

        public Ordine() { }

        public Ordine(int idOrdine, int idCliente, string data)
        {
            this.idOrdine = idOrdine;
            this.idCliente = idCliente;
            this.data = data;
        }

        public List<Ordine> GetSampleData()
        {
            return new List<Ordine>
            {
                new Ordine(2012, 1210, "12/12/2020"),
                new Ordine(9020, 801, "01/04/2021"),
                new Ordine(3340, 651, "12/06/2021")
            };
        }
    }
}
