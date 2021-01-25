using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7WithEmptyDataElements
    {
        /// <summary>
        /// Write transactions with whitespace.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var dispense = SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1");

            //  Add "" as the value to account for a delete
            dispense.LoopORC[0].ORC.PlacerOrderNumber_02.NamespaceID_02 = "\"\"";

            //  Add empty string as the value to add an extra separator to keep the position
            dispense.LoopORC[0].ORC.PlacerOrderNumber_02.UniversalID_03 = "";

            using (var stream = new MemoryStream())
            {
                using (var writer = new Hl7Writer(stream, new Hl7WriterSettings() { PreserveWhitespace = true }))
                {
                    //  Write the dispense
                    writer.Write(dispense);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
