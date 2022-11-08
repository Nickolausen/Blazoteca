using System.Xml.Serialization;
namespace Blazoteca.Data
{
    public class Enoteca
    {
        public List<Bottiglia> DataSetBottiglie { get; set; }
        public Enoteca()
        {
            DataSetBottiglie = new List<Bottiglia>();
            DBHandler.FillDataSet(@"Data\DB\Bottiglie.xml", this);
        }
        public List<Bottiglia> GetListaVini()
        {
            return DataSetBottiglie;
        }
    }
}
