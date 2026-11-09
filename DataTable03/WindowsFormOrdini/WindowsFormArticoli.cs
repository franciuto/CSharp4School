using DataTable03_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataForm03_WindowsForm
{
    public partial class WindowsFormArticoli : Form
    {

        internal Dati dati = new Dati();
        internal int idOrdine = 0;
        public WindowsFormArticoli(int idOrdine)
        {
            InitializeComponent();
            label1.Text = $"Articoli dell'ordine: {idOrdine}";
            this.idOrdine = idOrdine;
            ArticoliGridView.DataSource = dati.ArticoliPerOrdine(idOrdine);
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La somma dei prezzi degli articoli è: {dati.CalcolaSommaArticoliPerOrdine(this.idOrdine)}");
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La media dei prezzi degli articoli è: {dati.CalcolaMediaArticoliPerOrdine(this.idOrdine)}");
        }
    }
}
