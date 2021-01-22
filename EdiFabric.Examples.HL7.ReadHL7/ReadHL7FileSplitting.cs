using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Hl7;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileSplitting
    {
        /// <summary>
        /// Split a message into parts (blocks of segments) and read each part individually.
        /// Use to process large transactions with repeating loops.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\MedicalRecord.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(ediStream, (FHS fhs, BHS bhs, MSH msh) => typeof(TSMDMT02Splitter).GetTypeInfo(), new Hl7ReaderSettings { Split = true }))
                ediItems = hl7Reader.ReadToEnd().ToList();

            //  Find all N1 loops, they are all different ediItems
            var obxLoop = ediItems.OfType<TSMDMT02Splitter>().Where(m => m.LoopOBX != null).SelectMany(m => m.LoopOBX);
            Debug.WriteLine(string.Format("OBX parts {0}", obxLoop.Count()));
        }

        /// <summary>
        /// Copy a message and remove unwanted parts.
        /// </summary>
        public static void RunWithCopy()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\MedicalRecord.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(ediStream, "EdiFabric.Templates.Hl7"))
                ediItems = hl7Reader.ReadToEnd().ToList();

            var medRecords = ediItems.OfType<TSMDMT02>();
            var splitMedRecords = new List<TSMDMT02>();

            foreach (var medRecord in medRecords)
            {
                foreach (var obxLoop in medRecord.LoopOBX)
                {
                    var splitMedRecord = medRecord.Copy() as TSMDMT02;
                    splitMedRecord.LoopOBX.RemoveAll(l => splitMedRecord.LoopOBX.IndexOf(l) != medRecord.LoopOBX.IndexOf(obxLoop));
                    splitMedRecords.Add(splitMedRecord);
                }
            }

            foreach (var medRecord in medRecords)
                Debug.WriteLine(string.Format("Original: Med Record - OBX parts {0}", medRecord.LoopOBX.Count()));

            foreach (var splitMedRecord in splitMedRecords)
                Debug.WriteLine(string.Format("Split: Med Record - OBX parts {0}", splitMedRecord.LoopOBX.Count()));
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("HL7", "MDMT02")]
    public class TSMDMT02Splitter : TSMDMT02
    {
        [Splitter]
        [DataMember]
        [Required]
        [Pos(9)]
        public new List<Loop_OBX_TSMDMT02> LoopOBX { get; set; }
    }
}
