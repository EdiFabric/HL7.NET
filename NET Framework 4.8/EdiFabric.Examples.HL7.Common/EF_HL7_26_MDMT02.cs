namespace EdiFabric.Templates.Hl726
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Hl7;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Original document notification and content
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("HL7", "MDMT02")]
    public class TSMDMT02 : EdiMessage
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Message Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MSH MSH { get; set; }
        /// <summary>
        /// Software Segment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<SFT> SFT { get; set; }
        /// <summary>
        /// User Authentication Credential Segment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual UAC UAC { get; set; }
        /// <summary>
        /// Event Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual EVN EVN { get; set; }
        /// <summary>
        /// Patient Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual PID PID { get; set; }
        /// <summary>
        /// Patient Visit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual PV1 PV1 { get; set; }
        /// <summary>
        /// Patient Visit
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_ORC_TSMDMT02> LoopORC { get; set; }
        /// <summary>
        /// Transcription Document Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual TXA TXA { get; set; }
        /// <summary>
        /// Transcription Document Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual List<Loop_OBX_TSMDMT02> LoopOBX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ORC))]
    public class Loop_ORC_TSMDMT02
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Common Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ORC ORC { get; set; }
        /// <summary>
        /// Common Order
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_TQ1_TSMDMT02> LoopTQ1 { get; set; }
        /// <summary>
        /// Observation Request
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual OBR OBR { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(OBX))]
    public class Loop_OBX_TSMDMT02
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Observation Result
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OBX OBX { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TQ1))]
    public class Loop_TQ1_TSMDMT02
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Timing Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TQ1 TQ1 { get; set; }
        /// <summary>
        /// Timing Quantity Relationship
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TQ2> TQ2 { get; set; }
    }
}
