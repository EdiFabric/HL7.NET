using EdiFabric.Core.Model.Hl7;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileStreaming
    {
        /// <summary>
        /// Reads one item at a time from the HL7 stream.
        /// Use for interchanges containing multiple transactions.
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispenses.txt");

            //  2. Read item by item, that is each call to Read() 
            //  brings back either a control segment (or a transaction
            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
            {
                while (hl7Reader.Read())
                {
                    //  3. Check if current item is dispense
                    var dispense = hl7Reader.Item as TSRDSO13;
                    if (dispense != null)
                    {
                        ProcessDispense(hl7Reader.CurrentInterchangeHeader, hl7Reader.CurrentGroupHeader, dispense);
                    }
                }
            }
        }

        private static void ProcessDispense(FHS fhs, BHS bhs, TSRDSO13 dispense)
        {
            //  Do something with the dispense
        }
    }
}
