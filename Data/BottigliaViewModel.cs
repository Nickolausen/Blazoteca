namespace Blazoteca.Data
{
    public class BottigliaViewModel
    {
        public Bottiglia BottigliaModel { get; set; }
        public string Nome { get => BottigliaModel.Nome; }
        public string ProvinciaProduzione { get => BottigliaModel.ProvinciaProduzione; }
        public int AnnoProduzione { get => BottigliaModel.AnnoProduzione; }
        public string Immagine { get => BottigliaModel.PercorsoImmagine; }
        public int PercSconto { get => BottigliaModel.PercentualeSconto; }
        public double Prezzo { get => BottigliaModel.Prezzo; }
    }
}