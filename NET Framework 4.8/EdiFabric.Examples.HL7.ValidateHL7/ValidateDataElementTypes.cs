using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Hl7;
using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class ValidateDataElementTypes
    {
        /// <summary>
        /// Validate data element data type using the default HL7 code set. These aren't validated by default and need to be explicitly requested.
        /// </summary>
        public static void Default()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\MixedTransactions.txt");

            List<IEdiItem> hl7Items;
            using (var reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
                hl7Items = reader.ReadToEnd().ToList();

            var dispenses = hl7Items.OfType<TSRDSO13>();

            foreach (var dispense in dispenses)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!dispense.IsValid(out errorContext, new ValidationSettings { SyntaxSet = new Default() }))
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
}
