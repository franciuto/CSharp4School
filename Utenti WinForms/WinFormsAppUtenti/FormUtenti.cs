using WinFormsLibraryUtenti;

namespace WinFormsAppUtenti
{
    public partial class FormUtenti : Form
    {
        Dati dati;

        public FormUtenti()
        {
            InitializeComponent();
            dati = new Dati();
            AggiornaUtenti();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // passo la stessa istanza di Dati: così anche gli utenti appena inseriti possono fare login
            FormLogin formLogin = new FormLogin(dati);
            formLogin.ShowDialog();
        }

        private void buttonInserisciUtente_Click(object sender, EventArgs e)
        {
            string cognome = textBoxCognome.Text.Trim();
            string nome = textBoxNome.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (cognome == "" || nome == "" || password == "")
            {
                MessageBox.Show("Inserisci cognome, nome e password.");
                return;
            }

            Utente utente = dati.InserisciUtente(cognome, nome, password);
            AggiornaUtenti();
            MessageBox.Show($"Creato l'utente {utente.User} ({utente.Email}).");

            textBoxCognome.Clear();
            textBoxNome.Clear();
            textBoxPassword.Clear();
            textBoxCognome.Focus();
        }

        private void AggiornaUtenti()
        {
            dataGridViewUtenti.DataSource = dati.GetUtentiCompleti();
            dataGridViewUtenti.Columns["ID"]!.FillWeight = 70;
            dataGridViewUtenti.Columns["Cognome"]!.FillWeight = 110;
            dataGridViewUtenti.Columns["Nome"]!.FillWeight = 100;
            dataGridViewUtenti.Columns["User"]!.FillWeight = 120;
            dataGridViewUtenti.Columns["Password"]!.FillWeight = 90;
            dataGridViewUtenti.Columns["Email"]!.FillWeight = 190;
        }
    }
}
