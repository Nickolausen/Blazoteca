namespace Blazoteca.Data
{
    public class Cantina
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comune { get; set; }

        public Cantina(Guid id, string name, string comune)
        {
            Id = id;
            Name = name;
            Comune = comune;
        }
    }
}
