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
    /// Pharmacy/treatment dispense
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("HL7", "RDSO13")]
    public class TSRDSO13 : EdiMessage
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
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PID_TSRDSO13 LoopPID { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [Splitter]
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_ORC_TSRDSO13> LoopORC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_TSRDSO13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Patient Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PID PID { get; set; }
        /// <summary>
        /// Patient Additional Demographic
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PD1 PD1 { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Patient Allergy Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<AL1> AL1 { get; set; }
        /// <summary>
        /// Patient Allergy Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PV1_TSRDSO13 LoopPV1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ORC))]
    public class Loop_ORC_TSRDSO13
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
        public virtual List<Loop_TQ1_TSRDSO13> LoopTQ1 { get; set; }
        /// <summary>
        /// Common Order
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_RXO_TSRDSO13 LoopRXO { get; set; }
        /// <summary>
        /// Common Order
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_RXE_TSRDSO13 LoopRXE { get; set; }
        /// <summary>
        /// Pharmacy Treatment Dispense
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual RXD RXD { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Pharmacy Treatment Route
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<RXR> RXR { get; set; }
        /// <summary>
        /// Pharmacy Treatment Component Order
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<RXC> RXC { get; set; }
        /// <summary>
        /// Pharmacy Treatment Component Order
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_OBX_TSRDSO13> LoopOBX { get; set; }
        /// <summary>
        /// Financial Transaction
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<FT1> FT1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TQ1))]
    public class Loop_TQ1_TSRDSO13
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
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RXO))]
    public class Loop_RXO_TSRDSO13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Pharmacy Treatment Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RXO RXO { get; set; }
        /// <summary>
        /// Pharmacy Treatment Order
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_NTE_TSRDSO13 LoopNTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RXE))]
    public class Loop_RXE_TSRDSO13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Pharmacy Treatment Encoded Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RXE RXE { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_TQ1_TSRDSO13_2> LoopTQ1 { get; set; }
        /// <summary>
        /// Pharmacy Treatment Route
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<RXR> RXR { get; set; }
        /// <summary>
        /// Pharmacy Treatment Component Order
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<RXC> RXC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(OBX))]
    public class Loop_OBX_TSRDSO13
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
    public class Loop_TQ1_TSRDSO13_2
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
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NTE))]
    public class Loop_NTE_TSRDSO13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Pharmacy Treatment Route
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<RXR> RXR { get; set; }
        /// <summary>
        /// Pharmacy Treatment Route
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_RXC_TSRDSO13> LoopRXC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RXC))]
    public class Loop_RXC_TSRDSO13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Pharmacy Treatment Component Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RXC RXC { get; set; }
        /// <summary>
        /// Notes And Comments
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PV1))]
    public class Loop_PV1_TSRDSO13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        /// Patient Visit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PV1 PV1 { get; set; }
        /// <summary>
        /// Patient Visit Additional Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PV2 PV2 { get; set; }
    }
}
