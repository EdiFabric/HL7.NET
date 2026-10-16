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
    /// Query by parameter Z81
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("HL7", "QBPZ81")]
    public class TSQBPZ81 : EdiMessage
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
        /// Query Parameter Definition
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual QPD QPD { get; set; }
        /// <summary>
        /// Response Control Parameter
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual RCP RCP { get; set; }
        /// <summary>
        /// Continuation Pointer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DSC DSC { get; set; }
    }
}
