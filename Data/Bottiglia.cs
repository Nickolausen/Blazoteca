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
    }
}