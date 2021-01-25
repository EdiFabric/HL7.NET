using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7Batch
    {
        /// <summary>
        /// Batch multiple transactions in the same envelope\HL7 stream.
        /// </summary>
        public static void Run1()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new Hl7Writer(stream))
                {
                    //  Envelope
                    writer.Write(SegmentBuilders.BuildFhs("LAB1", "LAB", "DEST2", "DEST", "TESTFILE", "1234"));
                    writer.Write(SegmentBuilders.BuildBhs("LAB1", "LAB", "DEST2", "DEST", "TESTBATCH", "1234"));

                    //  Write the first dispense
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
                    //  Write the second dispense
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple transactions in the same HL7 stream.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new Hl7Writer(stream))
                {
                    //  NO Envelope

                    //  Write the first dispense
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
                    //  Write the second dispense
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
