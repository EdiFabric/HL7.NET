using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.HL7.Common;
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

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\CorruptMsh.txt");

            //  Set the continue on error flag to true
            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7", new Hl7ReaderSettings() { ContinueOnError = true }))
                hl7Items = hl7Reader.ReadToEnd().ToList();

            var readerErrors = hl7Items.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var dispenses = hl7Items.OfType<TSRDSO13>();
            foreach (var dispense in dispenses)
            {
                //  All valid dispenses were extracted
            }
        }
    }
}
