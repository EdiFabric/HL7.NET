using EdiFabric.Examples.HL7.Common;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Read HL7 file to the end
            ReadHL7FileToEnd.Run();
            ReadHL7FileToEndAsync.Run();

            //  Read one item at a time
            ReadHL7FileStreaming.Run();
            ReadHL7FileStreamingAsync.Run();

            //  Read batches of transactions
            ReadHL7FileBatch.Run();

            //  Split transactions to repeating loops
            ReadHL7FileSplitting.Run();
            ReadHL7FileSplitting.RunWithCopy();

            //  Read HL7 files with issues
            ReadHL7FileCorrupt.Run();

            //  Read using partner-specific template (inherited)
            ReadHL7FileWithInheritedTemplate.Run();

            //  Read using dynamic template resolution
            ReadHL7FileWithTemplateResolution.RunWithAssemblyFactory();
            ReadHL7FileWithTemplateResolution.RunWithTypeFactory();

            //  Read file with ADD segments
            ReadHL7FileWithADD.Run();

            //  Read file with unlimited number of repeating data element in the last position
            ReadHL7FileWithQPD.Run();

            //  Read file with continuation started
            ReadHL7FileWithDSC.Run();

            //  Read file with continuation to a DSC
            //  Placeholder segment HXX is not parsed or validated
            ReadHL7FileWithADDandDSC.Run();

            //  Read file with escaped delimiters
            ReadHL7FileWithEscapedDelimiters.Run();

            //  Read with custom FHS or BHS
            ReadHL7FileWithCustomFHSorBHS.Run();
        }
    }
}
