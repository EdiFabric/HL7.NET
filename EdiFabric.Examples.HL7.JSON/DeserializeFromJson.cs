using EdiFabric.Examples.HL7.Common;
using EdiFabric.Templates.Hl726;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.JSON
{
    class DeserializeFromJson
    {
        /// <summary>
        /// De-serialize to an HL7 object from Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispense.json");
            var transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<TSRDSO13>(hl7Stream.LoadToString());
        }
    }
}
