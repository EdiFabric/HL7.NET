using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework.Writers;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7WithNewLines
    {
        /// <summary>
        /// Write with segment postfix.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new Hl7Writer(stream, new Hl7WriterSettings() { Postfix = Environment.NewLine }))
                {
                    //  Write the dispense
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
