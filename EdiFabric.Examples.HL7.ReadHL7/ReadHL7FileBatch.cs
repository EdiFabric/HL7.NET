using EdiFabric.Core.Model.Hl7;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileBatch
    {
        /// <summary>
        /// Reads dispense and observations batched up in the same interchange.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\MixedTransactions.txt");

            //  2.  Read multiple transactions batched up in the same interchange
            using (var hl7Reader = new Hl7Reader(ediStream, "EdiFabric.Templates.Hl7"))
            {
                while (hl7Reader.Read())
                {
                    //  Process dispenses if no parsing errors
                    var dispense = hl7Reader.Item as TSRDSO13;
                    if (dispense != null && !dispense.HasErrors)
                        ProcessDispense(hl7Reader.CurrentInterchangeHeader, hl7Reader.CurrentGroupHeader, dispense);

                    //  Process observations if no parsing errors
                    var observation = hl7Reader.Item as TSORUR01;
                    if (observation != null && !observation.HasErrors)
                        ProcessObservation(hl7Reader.CurrentInterchangeHeader, hl7Reader.CurrentGroupHeader, observation);
                }
            }
        }

        private static void ProcessDispense(FHS fhs, BHS bhs, TSRDSO13 dispense)
        {
            //  Do something with the dispense
        }

        private static void ProcessObservation(FHS fhs, BHS bhs, TSORUR01 observation)
        {
            //  Do something with the observation
        }
    }
}
