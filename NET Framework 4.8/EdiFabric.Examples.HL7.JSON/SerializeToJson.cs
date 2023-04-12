using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;

namespace EdiFabric.Examples.HL7.JSON
{
    class SerializeToJson
    {
        /// <summary>
        /// Serialize an HL7 object to Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PharmacyTreatmentDispense.txt");

            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
            {
                hl7Items = hl7Reader.ReadToEnd().ToList();
            }

            var transactions = hl7Items.OfType<TSRDSO13>();
            foreach (var transaction in transactions)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(transaction);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}
