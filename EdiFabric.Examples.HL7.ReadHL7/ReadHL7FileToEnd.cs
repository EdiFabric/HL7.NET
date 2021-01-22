using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileToEnd
    {
        /// <summary>
        /// Reads the HL7 stream from start to end.
        /// This method loads the file into memory. Do not use for large files. 
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispenses.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(ediStream, "EdiFabric.Templates.Hl7"))
                ediItems = hl7Reader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var dispenses = ediItems.OfType<TSRDSO13>();
        }
    }
}
