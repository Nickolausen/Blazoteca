namespace Blazoteca.Data;
using System.Xml.Serialization;
public static class DBHandler
{
    public static void FillDataSet(string dataSetPath,Enoteca enoteca)
    {
        if (!File.Exists(dataSetPath)) return;

        using (StreamReader sr = new StreamReader(dataSetPath))
        {
            XmlRootAttribute xRoot = new XmlRootAttribute {
                ElementName = "bottiglie",
                IsNullable = true
            };

            XmlSerializer serializer = new XmlSerializer(typeof(List<Bottiglia>), xRoot);
            enoteca.DataSetBottiglie = serializer.Deserialize(sr) as List<Bottiglia>;
        }
    }
}