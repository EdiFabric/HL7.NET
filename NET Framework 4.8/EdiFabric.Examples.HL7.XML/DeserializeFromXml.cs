using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Examples.HL7.Common;
using EdiFabric.Templates.Hl726;

namespace EdiFabric.Examples.HL7.XML
{
    class DeserializeFromXml
    {
        /// <summary>
        /// De-serialize to an HL7 object from XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PharmacyTreatmentDispense.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TSRDSO13>();
        }

        /// <summary>
        /// De-serialize to an HL7 object from XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PharmacyTreatmentDispense2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TSRDSO13>();
        }
    }
}
