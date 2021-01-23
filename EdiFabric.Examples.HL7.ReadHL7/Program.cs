﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

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
        }
    }
}