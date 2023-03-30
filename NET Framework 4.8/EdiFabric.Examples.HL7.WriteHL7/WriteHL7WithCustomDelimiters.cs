using EdiFabric.Examples.HL7.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class WriteHL7WithCustomDelimiters
    {
        /// <summary>
        /// Write with custom separators, by default it uses the standard separators.
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
                    //  Set a custom subcomponent separator.
                    var separators = Separators.Hl7;
                    separators.SubComponent = '#';

                    //  Write the dispense
                    writer.Write(SegmentBuilders.BuildDispense("LAB1", "LAB", "DEST2", "DEST", "1"), true, separators);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
