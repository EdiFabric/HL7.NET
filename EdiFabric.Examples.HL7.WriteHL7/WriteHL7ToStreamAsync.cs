using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7ToStreamAsync
    {
        /// <summary>
        /// Generate and write HL7 document to a stream async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new Hl7Writer(stream))
                {
                    //  Write the dispense
                    await writer.WriteAsync(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
