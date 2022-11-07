namespace Blazoteca.Data
{
    public class BottigliaViewModel
    {
        private Bottiglia BottigliaModel { get; set; }
        public string Nome { get => BottigliaModel.Nome; }
        public string Produzione { get => BottigliaModel.Cantina.Comune; }
        public string AnnoProduzione { get => BottigliaModel.Anno; }
        public string Immagine { get => BottigliaModel.Immagine; }
        public int PercSconto { get; set; }
        public bool IsInSconto { get => PercSconto != 0; }
        public int Prezzo { get => Prezzo; set 
            {
                if (IsInSconto)
                    Prezzo = value;
                else
                    Prezzo = value - (value * PercSconto/100);
            } 
        }
        public BottigliaViewModel(Bottiglia bottigliaModel, int percSconto)
        {
            BottigliaModel = bottigliaModel;
            PercSconto = percSconto;
        }
    }
}