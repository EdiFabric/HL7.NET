using EdiFabric.Core.Model.Edi;
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
    class ReadHL7FileWithQPD
    {
        /// <summary>
        /// Reads the HL7 stream with QPD segments
        /// Data elements marked with typeof(ANY) are placeholders and are not validated. A list of ANY data elements at the last position in a segment, will read 
        /// any number of data elements.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Query.txt");

            //  2.  Read all the contents
            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
                hl7Items = hl7Reader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var queries = hl7Items.OfType<TSQBPZ81> ();
        }
    }
}
