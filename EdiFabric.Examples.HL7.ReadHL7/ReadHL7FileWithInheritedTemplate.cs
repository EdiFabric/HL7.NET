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
    class ReadHL7FileWithInheritedTemplate
    {
        /// <summary>
        /// Reads HL7 file into a custom, partner-specific template.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PharmacyTreatmentDispenseCustom.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var hl7Reader = new Hl7Reader(hl7Stream, (FHS fhs, BHS bhs, MSH msh) => typeof(TSRDSO13Custom).GetTypeInfo()))
                ediItems = hl7Reader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var customDispanses = ediItems.OfType<TSRDSO13Custom>();
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("HL7", "TSRDSO13")]
    public class TSRDSO13Custom : TSRDSO13
    {
        [DataMember]
        [Pos(5)]
        public new Loop_PID_TSRDSO13Custom LoopPID { get; set; }
    }

    [Serializable()]
    [Group(typeof(PID))]
    public class Loop_PID_TSRDSO13Custom : Loop_PID_TSRDSO13
    {
        [DataMember]
        [Pos(3)]
        public new List<NTECustom> NTE { get; set; }
    }

    [DataContract]
    [Segment("NTE")]
    public class NTECustom : NTE
    {
        //  Change the comment from repeatable to single, with maximum length of 10 characters
        [StringLength(1, 10)]
        [DataElement("00098", typeof(HL7_AN))]
        [DataMember]
        [Pos(3)]
        public new string Comment_03 { get; set; }
    }
}
