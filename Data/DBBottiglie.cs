using System.Data.SQLite;
namespace Blazoteca.Data
{
    public class DBBottiglie
    {
        static string conn_string = "Data Source=Data/db_bottiglie.sqlite;Cache=Shared";
        static SQLiteConnection conn;
        public DBBottiglie() {
            conn = new SQLiteConnection(conn_string);
            conn.Open();
        }

        public string getSqlite() {
            SQLiteCommand cmd = new SQLiteCommand("SELECT SQLITE_VERSION",conn);
            string versioneSQlite = cmd.ExecuteScalar().ToString();
            return versioneSQlite;
        }

        public Task<Recensione[]> GetElencoRecensioni() {
    
            List<Recensione> elencoRecensioni = new List<Recensione>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Recensioni",conn);
            SQLiteDataReader risultato = cmd.ExecuteReader();
            while (risultato.Read()) {
                elencoRecensioni.Add(
                    new Recensione(risultato.GetInt32(0), risultato.GetString(1), risultato.GetString(2), risultato.GetString(3)));
            }

            Recensione[] arrayRecensioni = elencoRecensioni.ToArray();

            return Task.FromResult(arrayRecensioni); 
        }

        public Task<Bottiglia[]> GetElencoBottiglie() {
    
            List<Bottiglia> elencoBottiglie = new List<Bottiglia>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Bottiglia",conn);
            SQLiteDataReader risultato = cmd.ExecuteReader();
            while (risultato.Read()) {
                elencoBottiglie.Add(
                    new Bottiglia(risultato.GetInt32(0), risultato.GetString(1), risultato.GetInt32(2),
                            risultato.GetString(3), risultato.GetString(4), risultato.GetFloat(5),
                            risultato.GetInt32(6), risultato.GetFloat(7), risultato.GetString(8),
                            risultato.GetString(9)));
            }

            Bottiglia[] arrayBottiglie = elencoBottiglie.ToArray();

            return Task.FromResult(arrayBottiglie); 
        }

        public Task<Bottiglia[]> GetElencoCarrello(List<int> elenco) {
    
            Bottiglia[] arrayBottiglie = null;
            List<Bottiglia> elencoBottiglie = new List<Bottiglia>();
            string elencoID = "(";
            elenco = elenco.Distinct().ToList();

            foreach (int id in elenco) {
                elencoID = elencoID + id.ToString() + ",";        
            }         
            elencoID = elencoID.Remove(elencoID.Length-1) + ")";

            if (elencoID != "()") { 

                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Bottiglia WHERE ID IN " + elencoID,conn);
                SQLiteDataReader risultato = cmd.ExecuteReader();
                while (risultato.Read()) {
                    elencoBottiglie.Add(
                        new Bottiglia(risultato.GetInt32(0), risultato.GetString(1), risultato.GetInt32(2),
                                risultato.GetString(3), risultato.GetString(4), risultato.GetFloat(5),
                                risultato.GetInt32(6), risultato.GetFloat(7), risultato.GetString(8),
                                risultato.GetString(9)));
                }
            }
            arrayBottiglie = elencoBottiglie.ToArray();

            return Task.FromResult(arrayBottiglie); 
        }

        public Task<Bottiglia> GetBottiglia(int id) {
    
            Bottiglia bottiglia;

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Bottiglia WHERE ID=@id",conn);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataReader risultato = cmd.ExecuteReader();
            if (risultato.Read()) {
                bottiglia = new Bottiglia(risultato.GetInt32(0), risultato.GetString(1), risultato.GetInt32(2),
                            risultato.GetString(3), risultato.GetString(4), risultato.GetFloat(5),
                            risultato.GetInt32(6), risultato.GetFloat(7), risultato.GetString(8),
                            risultato.GetString(9));
            }
            else bottiglia = null;
            
            return Task.FromResult(bottiglia); 
        }

        public Task<int> AggiungiRecensione(Recensione r) {

            int nuovoID = -1;

            SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(ID) FROM Recensioni", conn);
            SQLiteDataReader risultato = cmd.ExecuteReader();
            if (risultato.Read()) {
                nuovoID = risultato.GetInt32(0);
                nuovoID += 1;  

                cmd = new SQLiteCommand("INSERT INTO Recensioni (ID,Utente,TestoRecensione,Piattaforma) VALUES (@ID, @utente, @testo, @piattaforma)",conn);
                cmd.Parameters.Add(new SQLiteParameter("@ID", nuovoID));
                cmd.Parameters.Add(new SQLiteParameter("@utente", r.Utente));
                cmd.Parameters.Add(new SQLiteParameter("@testo", r.TestoRecensione));
                cmd.Parameters.Add(new SQLiteParameter("@piattaforma", "Plurk"));
                risultato = cmd.ExecuteReader(); 
            }          
            return Task.FromResult(0); 
        }

        public Task<bool> VerificaLogin(Utente u)
        {
            bool utenteVerificato = false;

            SQLiteCommand cmd = new SQLiteCommand("SELECT Password FROM Utenti WHERE Email=@email", conn);
            cmd.Parameters.Add(new SQLiteParameter("@email", u.Email));
            SQLiteDataReader risultato = cmd.ExecuteReader();

            if (risultato.Read()) {
                string pass = risultato.GetString(0);
                
                if (u.Password == pass)
                    utenteVerificato = true;
                    
            }
            return Task.FromResult(utenteVerificato);
        }

        public Task<string> RecuperaAccount(Utente u)
        {
            string account = "";

            SQLiteCommand cmd = new SQLiteCommand("SELECT Account FROM Utenti WHERE Email=@email", conn);
            cmd.Parameters.Add(new SQLiteParameter("@email", u.Email));
            SQLiteDataReader risultato = cmd.ExecuteReader();

            if (risultato.Read()) {
                account = risultato.GetString(0);
            }

            return Task.FromResult(account);
        }

        public Task<bool> AggiungiBottiglia(Bottiglia bott) {
            int nuovoID = -1;

            SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(ID) FROM Bottiglia", conn);
            SQLiteDataReader risultato = cmd.ExecuteReader();
            if (risultato.Read()) {
                nuovoID = risultato.GetInt32(0);
                nuovoID += 1;  

                cmd = new SQLiteCommand("INSERT INTO Bottiglia (ID,Nome,AnnoProduzione,ProvinciaProduzione,RegioneProduzione,Prezzo,PercentualeSconto,Gradazione,Descrizione,PercorsoImmagine) VALUES (@ID,@nome,@annoProduzione,@provinciaProduzione,@regioneProduzione,@prezzo,@percentualeSconto,@gradazione,@descrizione,@percorsoImmagine)", conn);
                cmd.Parameters.Add(new SQLiteParameter("@ID", nuovoID));
                cmd.Parameters.Add(new SQLiteParameter("@nome", bott.Nome));
                cmd.Parameters.Add(new SQLiteParameter("@annoProduzione", bott.AnnoProduzione));
                cmd.Parameters.Add(new SQLiteParameter("@provinciaProduzione", bott.ProvinciaProduzione));
                cmd.Parameters.Add(new SQLiteParameter("@regioneProduzione", bott.ProvinciaProduzione));
                cmd.Parameters.Add(new SQLiteParameter("@prezzo", bott.Prezzo));
                cmd.Parameters.Add(new SQLiteParameter("@percentualeSconto", bott.PercentualeSconto));
                cmd.Parameters.Add(new SQLiteParameter("@gradazione", bott.Gradazione));
                cmd.Parameters.Add(new SQLiteParameter("@descrizione", bott.Descrizione));
                cmd.Parameters.Add(new SQLiteParameter("@percorsoImmagine", 
                    "https://static.vecteezy.com/system/resources/previews/016/475/594/non_2x/transparent-white-wine-bottle-with-blank-label-and-gold-foil-capsule-seal-png.png"));

                cmd.ExecuteNonQuery();
                risultato = cmd.ExecuteReader(); 
            }
            
            return new Task<bool>(() => true); 
        }
    }
}