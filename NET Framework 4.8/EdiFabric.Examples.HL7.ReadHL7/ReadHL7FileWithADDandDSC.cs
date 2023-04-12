using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Hl7;
using EdiFabric.Examples.HL7.Common;
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
    class ReadHL7FileWithADDandDSC
    {
        /// <summary>
        /// Reads the HL7 stream with ADD segment, as a continuation of a DSC segment
        /// ORC loop contains a placeholder segment HXX. Segments of system type HXX are not validated and not parsed, but added as a whole.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ObservationADD_DSC.txt");

            //  2.  Read all the contents
            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, (FHS fhs, BHS bhs, MSH msh) => typeof(TSRDSO13TAdd).GetTypeInfo()))
                hl7Items = hl7Reader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var observations = hl7Items.OfType<TSRDSO13TAdd> ();
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("HL7", "TSRDSO13")]
    public class TSRDSO13TAdd : TSRDSO13
    {
        //  Inject an ADD segment right after the MSH
        [DataMember]
        [Pos(2)]
        public ADD ADD { get; set; }

        //  Push all others a position down
        [DataMember]
        [Pos(3)]
        public new List<SFT> SFT { get; set; }
        [DataMember]
        [Pos(4)]
        public new UAC UAC { get; set; }
        [DataMember]
        [Pos(5)]
        public new List<NTE> NTE { get; set; }
        [DataMember]
        [Pos(6)]
        public new Loop_PID_TSRDSO13 LoopPID { get; set; }
        [DataMember]
        [Pos(7)]
        [Required]
        public new List<Loop_ORC_TSRDSTEST> LoopORC { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(ORC))]
    public class Loop_ORC_TSRDSTEST
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public ORC ORC { get; set; }

        //  HXX segment
        [DataMember]
        [Pos(2)]
        public List<HXX> HXX { get; set; }
    }
}
