using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
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
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Examples.HL7.Common"))
            {
                hl7Items = hl7Reader.ReadToEnd().ToList();
            }

            var transactions = hl7Items.OfType<TSRDSO13>();
            foreach (var transaction in transactions)
            {
                var options = new JsonSerializerOptions
                {
                    //TypeInfoResolver = new DefaultJsonTypeInfoResolver
                    //{
                    //    Modifiers =
                    //    {
                    //        typeInfo =>
                    //        {
                    //            if (typeInfo.Kind != JsonTypeInfoKind.Object)
                    //                return;

                    //            foreach (var property in typeInfo.Properties)
                    //            {
                    //                if (property.Name == "Id" )
                    //                {
                    //                    property.ShouldSerialize = (obj, value) => false;
                    //                }
                    //            }
                    //        }
                    //    }
                    //},
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                var json = JsonSerializer.Serialize(transaction, options);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}
