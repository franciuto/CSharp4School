using System.Data;
using WinFormsLibraryUtenti;

namespace WinFormsAppUtenti
{
    public partial class FormLogin : Form
    {
        Dati dati;

        public FormLogin(Dati d)
        {
            InitializeComponent();
            dati = d;
        }

        private void buttonAccedi_Click(object sender, EventArgs e)
        {
            DataRow? utente = dati.Login(textBoxUser.Text.Trim(), textBoxPassword.Text);

            if (utente == null)
            {
                labelNome.Text = "Nome: —";
                labelCognome.Text = "Cognome: —";
                labelEmail.Text = "Email: —";
                MessageBox.Show("User o password errati.");
                return;
            }

            labelNome.Text = $"Nome: {utente["Nome"]}";
            labelCognome.Text = $"Cognome: {utente["Cognome"]}";
            labelEmail.Text = $"Email: {utente["Email"]}";
        }
    }
}
