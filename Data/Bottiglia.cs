using System.Xml.Serialization;
namespace Blazoteca.Data
{
    [Serializable]
    public class Bottiglia
    {
        [XmlIgnore]
        public Guid Id { get; set; }

        [XmlIgnore]
        public Vino Vino { get; set; }

        [XmlIgnore]
        public Cantina Cantina { get; set; }

        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }

        [XmlElement(ElementName = "anno")]
        public string Anno { get; set; }

        [XmlElement(ElementName = "descrizione")]
        public string Descrizione { get; set; }

        [XmlElement(ElementName = "immagine")]
        public string Immagine { get; set; }

        [XmlElement(ElementName = "prezzo")]
        public decimal Prezzo { get; set; }

        [XmlElement(ElementName = "gradazione")]
        public double PercentualeAlcolica { get; set; }

        public Bottiglia() { }
        public Bottiglia(Guid id, Vino vino, Cantina cantina, string nome, string anno, string descrizione, string immagine , decimal prezzo, double percentualeAlcolica)
        {
            Id = id;
            Vino = vino;
            Cantina = cantina; 
            Nome = nome;
            Anno = anno;
            Descrizione = descrizione;
            Immagine = immagine;
            Prezzo = prezzo;
            PercentualeAlcolica = percentualeAlcolica;
        }
    }
}