public class Recensione
{
    public int ID { get; set; }
    public string Utente { get; set; }
    public string Email { get; set; }
    public string Oggetto { get; set; }
    public string TestoRecensione { get; set; }
    public string Piattaforma { get; set; }

    public Recensione(int id, string u, string t, string p) {
        this.ID = id;
        this.Utente = u;
        this.TestoRecensione = t;
        this.Piattaforma = p;
        this.Email = "";
        this.Oggetto = "";
    }

    public Recensione() {

    }
}