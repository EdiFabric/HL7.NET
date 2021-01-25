namespace EdiFabric.Examples.HL7.WriteHL7
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

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
            WriteHL7TransactionBatch.Run1();
            WriteHL7TransactionBatch.Run2();
            WriteHL7GroupBatch.Run();
            WriteHL7InterchangeBatch.Run();

            //  Retain trailing data element delimiters for empty data elements
            WriteHL7WithEmptyDataElements.Run();
        }
    }
}
