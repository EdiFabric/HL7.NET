using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Examples.HL7.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Translator Demo 

            //  Supported versions/transactions are:
            //  HL7 2.6, all classes that begin with TS in namespace EdiFabric.Templates.HL726

            //  If you need a different HL7 version or transaction, please contact us at https://support.edifabric.com/hc/en-us/requests/new, EdiFabric supports all versions and transactions for HL7.

            SerialKey.Set(Common.SerialKey.Get());

            Translate_HL7_26();
        }

        public static void Translate_HL7_26()
        {
            //  Change the path to point to your own file to test with
            var path = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispense.txt");

            List<IEdiItem> ediItems;
            using (var reader = new Hl7Reader(path, "EdiFabric.Templates.Hl7", new Hl7ReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            foreach (var message in ediItems.OfType<EdiMessage>())
            {
                if (!message.HasErrors)
                {
                    //  Message was successfully parsed

                    MessageErrorContext mec;
                    if (message.IsValid(out mec))
                    {
                        //  Message was successfully validated
                    }
                    else
                    {
                        //  Message failed validation with the following validation issues:
                        var validationIssues = mec.Flatten();
                    }
                }
                else
                {
                    //  Message was partially parsed with errors
                }
            }

        }   //  Add a breakpoint here, run in debug mode and inspect ediItems
    }
}
