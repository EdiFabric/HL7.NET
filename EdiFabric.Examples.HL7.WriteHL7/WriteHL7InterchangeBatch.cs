using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7InterchangeBatch
    {
        /// <summary>
        /// Batch multiple interchanges in the same HL7 stream
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new Hl7Writer(stream))
                {
                    //  1.  Write the first interchange 
                    writer.Write(SegmentBuilders.BuildFhs("LAB1", "LAB", "DEST2", "DEST", "TESTFILE", "1"));
                    writer.Write(SegmentBuilders.BuildBhs("LAB1", "LAB", "DEST2", "DEST", "TESTBATCH", "1"));
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));

                    //  2.  Write the second interchange
                    writer.Write(SegmentBuilders.BuildFhs("LAB1", "LAB", "DEST2", "DEST", "TESTFILE", "2"));
                    writer.Write(SegmentBuilders.BuildBhs("LAB1", "LAB", "DEST2", "DEST", "TESTBATCH", "1"));
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
