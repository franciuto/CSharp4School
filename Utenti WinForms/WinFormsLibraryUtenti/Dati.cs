using System.Data;

namespace WinFormsLibraryUtenti
{
    public class Dati
    {
        // le liste partono dai dati di esempio e crescono con gli inserimenti: le DataTable si ricostruiscono sempre da qui
        List<Anagrafica> anagrafiche;
        List<Utente> utenti;

        public Dati()
        {
            anagrafiche = Anagrafica.GetSampleData();
            utenti = Utente.GetSampleData();
        }

        public DataTable GetAnagrafica()
        {
            DataTable tabella = new DataTable("Anagrafica");
            tabella.Columns.Add("ID", typeof(int));
            tabella.Columns.Add("Cognome", typeof(string));
            tabella.Columns.Add("Nome", typeof(string));

            foreach (Anagrafica anagrafica in anagrafiche)
            {
                tabella.Rows.Add(anagrafica.ID, anagrafica.Cognome, anagrafica.Nome);
            }

            return tabella;
        }

        public DataTable GetUtenti()
        {
            DataTable tabella = new DataTable("Utenti");
            tabella.Columns.Add("ID", typeof(int));
            tabella.Columns.Add("User", typeof(string));
            tabella.Columns.Add("Password", typeof(string));
            tabella.Columns.Add("Email", typeof(string));

            foreach (Utente utente in utenti)
            {
                tabella.Rows.Add(utente.ID, utente.User, utente.Password, utente.Email);
            }

            return tabella;
        }

        // unisce le due DataTable sul campo ID, come una JOIN in SQL
        public DataTable GetUtentiCompleti()
        {
            DataTable tabella = new DataTable("UtentiCompleti");
            tabella.Columns.Add("ID", typeof(int));
            tabella.Columns.Add("Cognome", typeof(string));
            tabella.Columns.Add("Nome", typeof(string));
            tabella.Columns.Add("User", typeof(string));
            tabella.Columns.Add("Password", typeof(string));
            tabella.Columns.Add("Email", typeof(string));

            DataTable tabellaUtenti = GetUtenti();

            foreach (DataRow anagrafica in GetAnagrafica().Rows)
            {
                foreach (DataRow utente in tabellaUtenti.Rows)
                {
                    if ((int)anagrafica["ID"] == (int)utente["ID"])
                    {
                        tabella.Rows.Add(anagrafica["ID"], anagrafica["Cognome"], anagrafica["Nome"], utente["User"], utente["Password"], utente["Email"]);
                    }
                }
            }

            return tabella;
        }

        // restituisce la riga dell'utente completo, oppure null se user o password sono sbagliati
        public DataRow? Login(string user, string password)
        {
            foreach (DataRow utente in GetUtentiCompleti().Rows)
            {
                if (string.Equals((string)utente["User"], user, StringComparison.OrdinalIgnoreCase) && (string)utente["Password"] == password)
                {
                    return utente;
                }
            }

            return null;
        }

        public Utente InserisciUtente(string cognome, string nome, string password)
        {
            int id = GeneraID();
            anagrafiche.Add(new Anagrafica(id, cognome, nome));

            // verifica omonimia: un omonimo ha già nome.cognome, quindi aggiungo un numero come marco.verdi1 nei dati di esempio
            string userBase = $"{nome}.{cognome}".Replace(" ", "").Replace("'", "").ToLower();
            string user = userBase;
            int numero = 1;
            while (utenti.Any(utente => utente.User == user))
            {
                user = userBase + numero;
                numero++;
            }

            Utente nuovoUtente = new Utente(id, user, password, $"{user}@itis.pr.it");
            utenti.Add(nuovoUtente);

            return nuovoUtente;
        }

        // id casuale di 6 cifre come nei dati di esempio, rigenerato se è già usato
        private int GeneraID()
        {
            int id;
            do
            {
                id = Random.Shared.Next(100000, 1000000);
            }
            while (anagrafiche.Any(anagrafica => anagrafica.ID == id));

            return id;
        }
    }
}
