namespace Blazoteca.Data
{
    public class Cart
    {
        public Dictionary<BottigliaViewModel, int> ArticoliSalvati { get; set; }
        public double Subtotale { get => CalcolaSubtotale(); }
        public int NrItems { get => (ArticoliSalvati is null) ? 0 : ArticoliSalvati.Count; }
        public double CalcolaSubtotale() {
            
            double subtotale = 0;
            foreach(var bottiglia in ArticoliSalvati.Keys)
                // bottigliaMemorizzato.Prezzo * bottigliaMemorizzato.Quantita 
                subtotale += bottiglia.Prezzo * ArticoliSalvati[bottiglia];

            return subtotale;
        }
    }
}