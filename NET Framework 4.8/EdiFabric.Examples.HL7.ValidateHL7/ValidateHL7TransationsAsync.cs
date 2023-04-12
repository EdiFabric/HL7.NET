using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class ValidateHL7TransationsAsync
    {
        /// <summary>
        /// Validate EDI transactions async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PharmacyTreatmentDispense.txt");

            List<IEdiItem> hl7Items;
            using (var reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
                hl7Items = reader.ReadToEnd().ToList();

            var dispenses = hl7Items.OfType<TSRDSO13>();

            foreach (var dispense in dispenses)
            {
                //  Validate
                Tuple<bool, MessageErrorContext> result = await dispense.IsValidAsync();
                if (!result.Item1)
                {
                    //  Report it back to the sender, log, etc.
                    var errors = result.Item2.Flatten();
                }
                else
                {
                    //  dispense is valid, handle it downstream
                }
            }
        }
    }
}
