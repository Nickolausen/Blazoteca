namespace Blazoteca.Data
{
    public class Vino
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Indicazione { get; set; }
        public string DOC { get; set; }
        public string Colore { get; set; }
        public string Denominazione { get; set; }
        public string Vitigno { get; set; }
        public string Categoria { get; set; }
        
        public Vino(Guid id, string nome, string indicazione, string dOC, string colore, string denominazione, string vitigno, string categoria)
        {
            Id = id;
            Nome = nome;
            Indicazione = indicazione;
            DOC = dOC;
            Colore = colore;
            Denominazione = denominazione;
            Vitigno = vitigno;
            Categoria = categoria;
        }
    }
}