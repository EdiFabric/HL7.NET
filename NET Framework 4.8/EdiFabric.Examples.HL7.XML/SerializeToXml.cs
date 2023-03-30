using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;

namespace EdiFabric.Examples.HL7.XML
{
    class SerializeToXml
    {
        /// <summary>
        /// Serialize an HL7 object to XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispense.txt");

            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
            {
                hl7Items = hl7Reader.ReadToEnd().ToList();
            }

            var transactions = hl7Items.OfType<TSRDSO13>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.Serialize();
                Debug.WriteLine(xml.Root.ToString());
            }
        }

        /// <summary>
        /// Serialize an HL7 object to XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispense.txt");

            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
            {
                hl7Items = hl7Reader.ReadToEnd().ToList();
            }

            var transactions = hl7Items.OfType<TSRDSO13>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.SerializeDataContract();
                Debug.WriteLine(xml.Root.ToString());
            }
        }
    }
}
