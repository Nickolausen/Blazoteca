namespace Blazoteca.Data
{
    public class Utente
    {
        public string Account { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string indirizzo { get; set; }
        public string Telefono { get; set; }
        //public Cart Carrello { get; set; }

        // public Utente(string email, string pwd)
        // {
        //     Email = email;
        //     Password = pwd;
        // }
        // public void AggiungiArticolo(BottigliaViewModel toBeAdded, int quantita) {
        //     Carrello.ArticoliSalvati.Add(toBeAdded, quantita);
        // }
        // public void RimuoviArticolo(BottigliaViewModel toBeRemoved) {
        //     Carrello.ArticoliSalvati.Remove(toBeRemoved);
        // }
    }
}