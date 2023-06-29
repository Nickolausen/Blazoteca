namespace Blazoteca.Data
{
    public class Sessione
    {
        private List<int> _articoli = new List<int>();
        private bool _utenteLoggato;
        public event Action OnChange;
        public int IDCliente { get; set; }

        public List<int> Articoli
        {
            get { 
                return _articoli; }
            set { 
                _articoli = value; 
                Aggiorna();
                }
        }
        public bool UtenteLoggato
        {
            get { 
                return _utenteLoggato; }
            set { 
                _utenteLoggato = value; 
                Aggiorna();
                }
        }
        private void Aggiorna() => OnChange?.Invoke();
              
    }
}