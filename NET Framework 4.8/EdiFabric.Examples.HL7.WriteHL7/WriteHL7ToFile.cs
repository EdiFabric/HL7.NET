using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7ToFile
    {
        /// <summary>
        /// Generate and write HL7 document to a file
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Write directly to a file
            //  Change the path to a file on your machine
            using (var writer = new Hl7Writer(@"C:\Test\Output.txt", false))
            {
                writer.Write(SegmentBuilders.BuildFhs("LAB1", "LAB", "DEST2", "DEST", "TESTFILE", "1"));
                writer.Write(SegmentBuilders.BuildBhs("LAB1", "LAB", "DEST2", "DEST", "TESTBATCH", "1"));
                writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
            }
        }
    }
}
