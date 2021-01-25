using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7GroupBatch
    {
        /// <summary>
        /// Batch multiple transactions under multiple functional groups in the same HL7 stream
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
                    writer.Write(SegmentBuilders.BuildFhs("LAB1", "LAB", "DEST2", "DEST", "TESTFILE", "1234"));

                    //  1.  Write the first group               
                    writer.Write(SegmentBuilders.BuildBhs("LAB1", "LAB", "DEST2", "DEST", "TESTBATCH", "1"));
                    //  Write the transactions...
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));

                    //  2.  Write the second group
                    writer.Write(SegmentBuilders.BuildBhs("LAB1", "LAB", "DEST2", "DEST", "TESTBATCH", "2"));
                    //  Write the transactions...
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
