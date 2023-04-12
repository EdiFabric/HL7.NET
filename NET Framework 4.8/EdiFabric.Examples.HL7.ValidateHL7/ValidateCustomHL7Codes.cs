using EdiFabric.Core.Annotations.Edi;
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
using System.Runtime.Serialization;

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class ValidateCustomHL7Codes
    {
        /// <summary>
        /// Validate with custom HL7 codes, different than the standard HL7 codes
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set HL7 codes map where the original code type will be substituted with the partner-specific code type
            Dictionary<Type, Type> codeSetMap = new Dictionary<Type, Type>();
            codeSetMap.Add(typeof(HL7_ID_136), typeof(HL7_ID_136_PartnerA));

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\MixedTransactions.txt");

            List<IEdiItem> hl7Items;
            using (var reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
                hl7Items = reader.ReadToEnd().ToList();

            var dispenses = hl7Items.OfType<TSRDSO13>();

            foreach (var dispense in dispenses)
            {
                //  Validate using HL7 codes map
                MessageErrorContext errorContext;
                if (!dispense.IsValid(out errorContext, new ValidationSettings { DataElementTypeMap = codeSetMap }))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  dispense is valid, handle it downstream
                }
            }
        }

        /// <summary>
        /// Validate with custom HL7 codes, different than the standard HL7 codes. Load the code dynamically at runtime.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set HL7 codes map where the original code type will be substituted with the partner-specific code type
            var codeSetMap = new Dictionary<string, List<string>>();
            codeSetMap.Add("HL7_ID_136", new List<string> { "N", "Y", "M" });

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\MixedTransactions.txt");

            List<IEdiItem> hl7Items;
            using (var reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
                hl7Items = reader.ReadToEnd().ToList();

            var dispenses = hl7Items.OfType<TSRDSO13>();

            foreach (var dispense in dispenses)
            {
                //  Validate using HL7 codes map
                MessageErrorContext errorContext;
                if (!dispense.IsValid(out errorContext, new ValidationSettings { DataElementCodesMap = codeSetMap }))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  dispense is valid, handle it downstream
                }
            }
        }
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,M,")]
    public class HL7_ID_136_PartnerA
    {
    }
}
