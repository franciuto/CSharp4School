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
    }
}
