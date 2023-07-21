
using EdiFabric.Examples.HL7.Common;

namespace EdiFabric.Examples.HL7.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Serialize to XML
            SerializeToXml.WithXmlSerializer();
            SerializeToXml.WithDataContractSerializer();

            //  Deserialize from XML
            DeserializeFromXml.WithXmlSerializer();
            DeserializeFromXml.WithDataContractSerializer();
        }
    }
}
