using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Hl7;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileWithTemplateResolution
    {
        /// <summary>
        /// Reads the HL7 stream from start to end using assembly factory. Allows you to dynamically specify a separate assembly to be used for parsing.
        /// </summary>
        public static void RunWithAssemblyFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispenses.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(hl7Stream, AssemblyFactory))
                ediItems = hl7Reader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var dispenses = ediItems.OfType<TSRDSO13>();
        }

        public static Assembly AssemblyFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "26")
                return Assembly.Load("EdiFabric.Templates.Hl7");

            throw new Exception(string.Format("Version {0} is not supported.", messageContext.Version));
        }

        /// <summary>
        /// Reads the HL7 stream from start to end using type factory. Allows you to dynamically specify the exact template to be used for parsing.
        /// </summary>
        public static void RunWithTypeFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispenses.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(hl7Stream, TypeFactory))
                ediItems = hl7Reader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var dispenses = ediItems.OfType<TSRDSO13>();
        }

        public static TypeInfo TypeFactory(FHS fhs, BHS bhs, MSH msh)
        {
            if (msh.MessageType_08.MessageCode_01 == "RDS" && msh.MessageType_08.TriggerEvent_02 == "O13")
                return typeof(TSRDSO13).GetTypeInfo();            

            throw new Exception(string.Format("Transaction {0} for trigger {1} is not supported.",
                msh.MessageType_08.MessageCode_01, msh.MessageType_08.TriggerEvent_02));
        }
    }
}
