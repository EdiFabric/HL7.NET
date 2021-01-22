using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileCorrupt
    {
        /// <summary>
        /// Reads file with a corrupt MSH and a valid MSH
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\CorruptMsh.txt");

            //  Set the continue on error flag to true
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(ediStream, "EdiFabric.Templates.Hl7", new Hl7ReaderSettings() { ContinueOnError = true }))
                ediItems = hl7Reader.ReadToEnd().ToList();

            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var dispenses = ediItems.OfType<TSRDSO13>();
            foreach (var dispense in dispenses)
            {
                //  All valid dispenses were extracted
            }
        }
    }
}
