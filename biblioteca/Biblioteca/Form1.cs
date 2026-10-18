using BibliotecaLibrary;

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
        private Biblioteca biblioteca = new Biblioteca();


        public Form1()
        {
            InitializeComponent();

            cmbTipo.Items.Add("Libro");
            cmbTipo.Items.Add("DVD");
            cmbTipo.SelectedIndex = 0;

            dataGridView1.DataSource = biblioteca.libreria;
            dataGridView1.Columns["codice"]!.HeaderText = "Codice";
            dataGridView1.Columns["titolo"]!.HeaderText = "Titolo";
            dataGridView1.Columns["giorniPrestito"]!.HeaderText = "Giorni";
            dataGridView1.Columns["CostoPrestito"]!.HeaderText = "Costo (€)";

            var colRimuovi = new DataGridViewButtonColumn
            {
                Name = "colRimuovi",
                HeaderText = "",
                Text = "Rimuovi",
                UseColumnTextForButtonValue = true
            };

            dataGridView1.Columns.Add(colRimuovi);

            // ricalcola l'incasso a ogni aggiunta o rimozione nella lista
            biblioteca.libreria.ListChanged += (s, e) => AggiornaIncasso();
            AggiornaIncasso();
        }

        private void AggiornaIncasso()
        {
            lblIncasso.Text = "Incasso totale: " + biblioteca.calcolaIncassoTotale().ToString("C");
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                lblSpecific.Text = "N. Pagine:";
            }
            else
            {
                lblSpecific.Text = "Durata in minuti:";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. LEGGI E CONVERTI: il testo delle caselle è sempre string
            if (!int.TryParse(textBox1.Text, out int codice) ||
                !int.TryParse(textBox2.Text, out int giorni) ||
                !int.TryParse(txtboxSpecific.Text, out int specifico))
            {
                MessageBox.Show("Codice, giorni e pagine/minuti devono essere numeri interi.");
                return;
            }

            string titolo = txtTitolo.Text.Trim();
            if (titolo == "")
            {
                MessageBox.Show("Inserisci un titolo.");
                return;
            }

            // 2. CREA L'OGGETTO GIUSTO
            Risorsa r;
            if (cmbTipo.SelectedIndex == 0)
            {
                r = new Libro(specifico, codice, titolo, giorni);
            }
            else
            {
                r = new DVD(specifico, codice, titolo, giorni);
            }

            // 3. AGGIUNGI ALLA BIBLIOTECA
            biblioteca.addRisorsa(r);

            // 4. PULISCI IL FORM per il prossimo inserimento
            textBox1.Clear();
            txtTitolo.Clear();
            textBox2.Clear();
            txtboxSpecific.Clear();
            textBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignora i click sull'intestazione e sulle altre colonne
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "colRimuovi")
                return;

            // l'oggetto collegato a quella riga
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Risorsa r)
            {
                biblioteca.removeRisorsa(r);
            }
        }
    }
}
