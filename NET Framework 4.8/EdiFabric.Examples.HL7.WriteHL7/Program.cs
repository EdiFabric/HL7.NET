using EdiFabric.Examples.HL7.Common;
using System;

namespace EdiFabric.Examples.HL7.WriteHL7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Write EDI to stream and then to string or file
            WriteHL7ToStream.Run();
            WriteHL7ToStreamAsync.Run();

            //  Write EDI directly to file
            WriteHL7ToFile.Run();

            //  Write EDI with custom delimiters (this includes all delimiters set in ISA)
            WriteHL7WithCustomDelimiters.Run();

            //  Write EDI with postfix (such as new line) after each segment
            //WriteHL7WithNewLines.Run();

            //  Write batches
            WriteHL7Batch.Run1();
            WriteHL7Batch.Run2();
            WriteHL7BHSBatch.Run();
            WriteHL7FHSBatch.Run();

            //  Retain trailing data element delimiters for empty data elements
            WriteHL7WithEmptyDataElements.Run();

            //  Write with obfuscation
            WriteHL7WithObfuscation.Run();
        }
    }
}
