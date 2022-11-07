using System.Xml.Serialization;
namespace Blazoteca.Data
{
    public static class Enoteca
    {
        private static string DataSetPath = @"Data\DB\Bottiglie.xml";
        private static List<Bottiglia> DataSetBottiglie = new List<Bottiglia>();

        public static void FillDataSet()
        {
            if (!File.Exists(DataSetPath)) return;

            using (StreamReader sr = new StreamReader(DataSetPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Bottiglia>));
                DataSetBottiglie = serializer.Deserialize(sr) as List<Bottiglia>;
            }
        }
        public static List<Bottiglia> GetListaVini()
        {
            return DataSetBottiglie;
        }
    }
}
