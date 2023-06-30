namespace Blazoteca.Data
{
    public class Bottiglia
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int AnnoProduzione { get; set; }
        public string ProvinciaProduzione { get; set; }
        public string RegioneProduzione { get; set; }
        public double Prezzo { get; set; }
        public int PercentualeSconto { get; set; }
        public double Gradazione { get; set; }
        public string Descrizione { get; set; }
        public string PercorsoImmagine { get; set; }
        public Bottiglia() {}
        public Bottiglia(int id, string n, int a, string pr, string r, double pz, int ps, double gr, string des, string pi) {
            this.ID = id;
            this.Nome = n;
            this.AnnoProduzione = a;
            this.ProvinciaProduzione =pr;
            this.RegioneProduzione = r;
            this.Prezzo = pz;
            this.PercentualeSconto = ps;
            this.Gradazione = gr;
            this.Descrizione = des;
            this.PercorsoImmagine = pi;

        }

        
    }
}