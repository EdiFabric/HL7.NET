namespace EdiFabric.Templates.Hl726
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Hl7;
    
    
    /// <summary>
    // Extended telecommunications number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XTN")]
    public class ExtendedTelecommunicationsNumber
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Telephone Number
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XTN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string TelephoneNumber_01 { get; set; }
        /// <summary>
        // Telecommunication Use Code
        /// </summary>
        [DataMember]
        [DataElement("XTN_2", typeof(HL7_ID_201))]
        [Pos(2)]
        public virtual string TelecommunicationUseCode_02 { get; set; }
        /// <summary>
        // Telecommunication Equipment Type
        /// </summary>
        [DataMember]
        [DataElement("XTN_3", typeof(HL7_ID_202))]
        [Pos(3)]
        public virtual string TelecommunicationEquipmentType_03 { get; set; }
        /// <summary>
        // Email Address
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XTN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string EmailAddress_04 { get; set; }
        /// <summary>
        // Country Code
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("XTN_5", typeof(HL7_N))]
        [Pos(5)]
        public virtual string CountryCode_05 { get; set; }
        /// <summary>
        // Area/City Code
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("XTN_6", typeof(HL7_N))]
        [Pos(6)]
        public virtual string AreaCityCode_06 { get; set; }
        /// <summary>
        // Local Number
        /// </summary>
        [DataMember]
        [StringLength(0, 9)]
        [DataElement("XTN_7", typeof(HL7_N))]
        [Pos(7)]
        public virtual string LocalNumber_07 { get; set; }
        /// <summary>
        // Extension
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("XTN_8", typeof(HL7_N))]
        [Pos(8)]
        public virtual string Extension_08 { get; set; }
        /// <summary>
        // Any Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XTN_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string AnyText_09 { get; set; }
        /// <summary>
        // Extension Prefix
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("XTN_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string ExtensionPrefix_10 { get; set; }
        /// <summary>
        // Speed Dial Code
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("XTN_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string SpeedDialCode_11 { get; set; }
        /// <summary>
        // Unformatted Telephone number
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XTN_12", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string UnformattedTelephoneNumber_12 { get; set; }
    }
    
    /// <summary>
    // Name Context
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XPN_9")]
    public class NameContext
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string NameContext01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate
        /// </summary>
        [DataMember]
        [DataElement("CE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternate_06 { get; set; }
    }
    
    /// <summary>
    // Expiration Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XPN_13")]
    public class ExpirationDate
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("TS_1", typeof(HL7_DTM))]
        [Pos(1)]
        public virtual string Time_01 { get; set; }
        /// <summary>
        // Degree of Precision
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("TS_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string DegreeOfPrecision_02 { get; set; }
    }
    
    /// <summary>
    // Name Validity Range
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XPN_10")]
    public class NameValidityRange
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Range Start Date/Time
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ExpirationDate RangeStartDateTime_01 { get; set; }
        /// <summary>
        // Range End Date/Time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExpirationDate RangeEndDateTime_02 { get; set; }
    }
    
    /// <summary>
    // Family Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XPN_1")]
    public class FamilyName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Surname
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 50)]
        [DataElement("FN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Surname_01 { get; set; }
        /// <summary>
        // Own Surname Prefix
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("FN_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string OwnSurnamePrefix_02 { get; set; }
        /// <summary>
        // Own Surname
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("FN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string OwnSurname_03 { get; set; }
        /// <summary>
        // Surname Prefix From Partner/Spouse
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("FN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SurnamePrefixFromPartnerSpouse_04 { get; set; }
        /// <summary>
        // Surname From Partner/Spouse
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("FN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string SurnameFromPartnerSpouse_05 { get; set; }
    }
    
    /// <summary>
    // Extended person name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XPN")]
    public class ExtendedPersonName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual FamilyName FamilyName_01 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XPN_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string GivenName_02 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XPN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_03 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XPN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string Suffix_04 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XPN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Prefix_05 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("XPN_6", typeof(HL7_ID_360))]
        [Pos(6)]
        public virtual string Degree_06 { get; set; }
        /// <summary>
        // Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("XPN_7", typeof(HL7_ID_200))]
        [Pos(7)]
        public virtual string NameTypeCode_07 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XPN_8", typeof(HL7_ID_465))]
        [Pos(8)]
        public virtual string NameRepresentationCode_08 { get; set; }
        /// <summary>
        // Name Context
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual NameContext NameContext_09 { get; set; }
        /// <summary>
        // Name Validity Range
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual NameValidityRange NameValidityRange_10 { get; set; }
        /// <summary>
        // Name Assembly Order
        /// </summary>
        [DataMember]
        [DataElement("XPN_11", typeof(HL7_ID_444))]
        [Pos(11)]
        public virtual string NameAssemblyOrder_11 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ExpirationDate EffectiveDate_12 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ExpirationDate ExpirationDate_13 { get; set; }
        /// <summary>
        // Professional Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XPN_14", typeof(HL7_AN))]
        [Pos(14)]
        public virtual string ProfessionalSuffix_14 { get; set; }
    }
    
    /// <summary>
    // Extended Assigning Authority
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XON_6")]
    public class ExtendedAssigningAuthority
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("HD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ExtendedAssigningAuthority01 { get; set; }
        /// <summary>
        // Universal ID
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("HD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string UniversalID_02 { get; set; }
        /// <summary>
        // Universal ID Type
        /// </summary>
        [DataMember]
        [DataElement("HD_3", typeof(HL7_ID_301))]
        [Pos(3)]
        public virtual string UniversalIDType_03 { get; set; }
    }
    
    /// <summary>
    // Extended composite name and ID number for organizations
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XON")]
    public class ExtendedCompositeNameAndIDNumberForOrganizations
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Organization Name
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("XON_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string OrganizationName_01 { get; set; }
        /// <summary>
        // Organization Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("XON_2", typeof(HL7_ID_204))]
        [Pos(2)]
        public virtual string OrganizationNameTypeCode_02 { get; set; }
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("XON_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string IDNumber_03 { get; set; }
        /// <summary>
        // Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("XON_4", typeof(HL7_N))]
        [Pos(4)]
        public virtual string CheckDigit_04 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("XON_5", typeof(HL7_ID_61))]
        [Pos(5)]
        public virtual string CheckDigitScheme_05 { get; set; }
        /// <summary>
        // Extended Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ExtendedAssigningAuthority ExtendedAssigningAuthority_06 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("XON_7", typeof(HL7_ID_203))]
        [Pos(7)]
        public virtual string IdentifierTypeCode_07 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningFacility AssigningFacility_08 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XON_9", typeof(HL7_ID_465))]
        [Pos(9)]
        public virtual string NameRepresentationCode_09 { get; set; }
        /// <summary>
        // Organization Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XON_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string OrganizationIdentifier_10 { get; set; }
    }
    
    /// <summary>
    // Assigning Agency or Department
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XCN_23")]
    public class AssigningAgencyOrDepartment
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Identifier_01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Extended composite ID number and name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XCN")]
    public class ExtendedCompositeIDNumberAndName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("XCN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string IDNumber_01 { get; set; }
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FamilyName FamilyName_02 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_04 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("XCN_7", typeof(HL7_ID_360))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source Table
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("XCN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_09 { get; set; }
        /// <summary>
        // Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_10", typeof(HL7_ID_200))]
        [Pos(10)]
        public virtual string NameTypeCode_10 { get; set; }
        /// <summary>
        // Identifier Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("XCN_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string IdentifierCheckDigit_11 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("XCN_12", typeof(HL7_ID_61))]
        [Pos(12)]
        public virtual string CheckDigitScheme_12 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_13", typeof(HL7_ID_203))]
        [Pos(13)]
        public virtual string IdentifierTypeCode_13 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningFacility AssigningFacility_14 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_15", typeof(HL7_ID_465))]
        [Pos(15)]
        public virtual string NameRepresentationCode_15 { get; set; }
        /// <summary>
        // Name Context
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual NameContext NameContext_16 { get; set; }
        /// <summary>
        // Name Validity Range
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual NameValidityRange NameValidityRange_17 { get; set; }
        /// <summary>
        // Name Assembly Order
        /// </summary>
        [DataMember]
        [DataElement("XCN_18", typeof(HL7_ID_444))]
        [Pos(18)]
        public virtual string NameAssemblyOrder_18 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExpirationDate EffectiveDate_19 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExpirationDate ExpirationDate_20 { get; set; }
        /// <summary>
        // Professional Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XCN_21", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string ProfessionalSuffix_21 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_22 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_23 { get; set; }
    }
    
    /// <summary>
    // Street Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XAD_1")]
    public class StreetAddress
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Street or Mailing Address
        /// </summary>
        [DataMember]
        [StringLength(0, 120)]
        [DataElement("SAD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string StreetOrMailingAddress_01 { get; set; }
        /// <summary>
        // Street Name
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("SAD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string StreetName_02 { get; set; }
        /// <summary>
        // Dwelling Number
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("SAD_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string DwellingNumber_03 { get; set; }
    }
    
    /// <summary>
    // Extended address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("XAD")]
    public class ExtendedAddress
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Street Address
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual StreetAddress StreetAddress_01 { get; set; }
        /// <summary>
        // Other Designation
        /// </summary>
        [DataMember]
        [StringLength(0, 120)]
        [DataElement("XAD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string OtherDesignation_02 { get; set; }
        /// <summary>
        // City
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("XAD_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string City_03 { get; set; }
        /// <summary>
        // State or Province
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("XAD_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string StateOrProvince_04 { get; set; }
        /// <summary>
        // Zip or Postal Code
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("XAD_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string ZipOrPostalCode_05 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [DataElement("XAD_6", typeof(HL7_ID_399))]
        [Pos(6)]
        public virtual string Country_06 { get; set; }
        /// <summary>
        // Address Type
        /// </summary>
        [DataMember]
        [DataElement("XAD_7", typeof(HL7_ID_190))]
        [Pos(7)]
        public virtual string AddressType_07 { get; set; }
        /// <summary>
        // Other Geographic Designation
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("XAD_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string OtherGeographicDesignation_08 { get; set; }
        /// <summary>
        // County/Parish Code
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XAD_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string CountyParishCode_09 { get; set; }
        /// <summary>
        // Census Tract
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XAD_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string CensusTract_10 { get; set; }
        /// <summary>
        // Address Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XAD_11", typeof(HL7_ID_465))]
        [Pos(11)]
        public virtual string AddressRepresentationCode_11 { get; set; }
        /// <summary>
        // Address Validity Range
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual NameValidityRange AddressValidityRange_12 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ExpirationDate EffectiveDate_13 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ExpirationDate ExpirationDate_14 { get; set; }
    }
    
    /// <summary>
    // Waveform source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("WVS")]
    public class WaveformSource
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Source One Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 8)]
        [DataElement("WVS_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SourceOneName_01 { get; set; }
        /// <summary>
        // Source Two Name
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("WVS_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string SourceTwoName_02 { get; set; }
    }
    
    /// <summary>
    // Channel Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("WVI")]
    public class ChannelIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Channel Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("WVI_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string ChannelNumber_01 { get; set; }
        /// <summary>
        // Channel Name
        /// </summary>
        [DataMember]
        [StringLength(0, 17)]
        [DataElement("WVI_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string ChannelName_02 { get; set; }
    }
    
    /// <summary>
    // Value range
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("VR")]
    public class ValueRange
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // First Data Code Value
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("VR_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string FirstDataCodeValue_01 { get; set; }
        /// <summary>
        // Last Data Code Value
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("VR_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string LastDataCodeValue_02 { get; set; }
    }
    
    /// <summary>
    // Visiting hours
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("VH")]
    public class VisitingHours
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Start Day Range
        /// </summary>
        [DataMember]
        [DataElement("VH_1", typeof(HL7_ID_267))]
        [Pos(1)]
        public virtual string StartDayRange_01 { get; set; }
        /// <summary>
        // End Day Range
        /// </summary>
        [DataMember]
        [DataElement("VH_2", typeof(HL7_ID_267))]
        [Pos(2)]
        public virtual string EndDayRange_02 { get; set; }
        /// <summary>
        // Start Hour Range
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("VH_3", typeof(HL7_TM))]
        [Pos(3)]
        public virtual string StartHourRange_03 { get; set; }
        /// <summary>
        // End Hour Range
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("VH_4", typeof(HL7_TM))]
        [Pos(4)]
        public virtual string EndHourRange_04 { get; set; }
    }
    
    /// <summary>
    // Value Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("UVC_2")]
    public class ValueAmount
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MO_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        /// <summary>
        // Denomination
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("MO_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Denomination_02 { get; set; }
    }
    
    /// <summary>
    // Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("UVC_1")]
    public class ValueCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ValueCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // UB value code and amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("UVC")]
    public class UBValueCodeAndAmount
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Value Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ValueCode ValueCode_01 { get; set; }
        /// <summary>
        // Value Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ValueAmount ValueAmount_02 { get; set; }
    }
    
    /// <summary>
    // Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("TQ_2")]
    public class Interval
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Repeat Pattern
        /// </summary>
        [DataMember]
        [DataElement("RI_1", typeof(HL7_ID_335))]
        [Pos(1)]
        public virtual string RepeatPattern_01 { get; set; }
        /// <summary>
        // Explicit Time Interval
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("RI_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string ExplicitTimeInterval_02 { get; set; }
    }
    
    /// <summary>
    // Order Sequencing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("TQ_10")]
    public class OrderSequencing
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence/Results Flag
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("OSD_1", typeof(HL7_ID_524))]
        [Pos(1)]
        public virtual string SequenceResultsFlag_01 { get; set; }
        /// <summary>
        // Placer Order Number. Entity Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("OSD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string PlacerOrderNumberEntityIdentifier_02 { get; set; }
        /// <summary>
        // Placer Order Number. Namespace ID
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("OSD_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string PlacerOrderNumberNamespaceID_03 { get; set; }
        /// <summary>
        // Filler Order Number. Entity Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("OSD_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string FillerOrderNumberEntityIdentifier_04 { get; set; }
        /// <summary>
        // Filler Order Number. Namespace ID
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("OSD_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string FillerOrderNumberNamespaceID_05 { get; set; }
        /// <summary>
        // Sequence Condition Value
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("OSD_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string SequenceConditionValue_06 { get; set; }
        /// <summary>
        // Maximum Number of Repeats
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("OSD_7", typeof(HL7_N))]
        [Pos(7)]
        public virtual string MaximumNumberOfRepeats_07 { get; set; }
        /// <summary>
        // Placer Order Number. Universal ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("OSD_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string PlacerOrderNumberUniversalID_08 { get; set; }
        /// <summary>
        // Placer Order Number. Universal ID Type
        /// </summary>
        [DataMember]
        [DataElement("OSD_9", typeof(HL7_ID_301))]
        [Pos(9)]
        public virtual string PlacerOrderNumberUniversalIDType_09 { get; set; }
        /// <summary>
        // Filler Order Number. Universal ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("OSD_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string FillerOrderNumberUniversalID_10 { get; set; }
        /// <summary>
        // Filler Order Number. Universal ID Type
        /// </summary>
        [DataMember]
        [DataElement("OSD_11", typeof(HL7_ID_301))]
        [Pos(11)]
        public virtual string FillerOrderNumberUniversalIDType_11 { get; set; }
    }
    
    /// <summary>
    // Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("TQ_1")]
    public class Quantity
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("CQ_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        /// <summary>
        // Units
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual InternationalVersionID Units_02 { get; set; }
    }
    
    /// <summary>
    // Timing/quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("TQ")]
    public class Timingquantity
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Quantity Quantity_01 { get; set; }
        /// <summary>
        // Interval
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Interval Interval_02 { get; set; }
        /// <summary>
        // Duration
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("TQ_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Duration_03 { get; set; }
        /// <summary>
        // Start Date/Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExpirationDate StartDateTime_04 { get; set; }
        /// <summary>
        // End Date/Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExpirationDate EndDateTime_05 { get; set; }
        /// <summary>
        // Priority
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("TQ_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Priority_06 { get; set; }
        /// <summary>
        // Condition
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("TQ_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string Condition_07 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("TQ_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string Text_08 { get; set; }
        /// <summary>
        // Conjunction
        /// </summary>
        [DataMember]
        [DataElement("TQ_9", typeof(HL7_ID_472))]
        [Pos(9)]
        public virtual string Conjunction_09 { get; set; }
        /// <summary>
        // Order Sequencing
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual OrderSequencing OrderSequencing_10 { get; set; }
        /// <summary>
        // Occurrence Duration
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual InternationalVersionID OccurrenceDuration_11 { get; set; }
        /// <summary>
        // Total Occurrences
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("TQ_12", typeof(HL7_N))]
        [Pos(12)]
        public virtual string TotalOccurrences_12 { get; set; }
    }
    
    /// <summary>
    // Sort order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SRT")]
    public class SortOrder
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sort-by Field
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 12)]
        [DataElement("SRT_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SortbyField_01 { get; set; }
        /// <summary>
        // Sequencing
        /// </summary>
        [DataMember]
        [DataElement("SRT_2", typeof(HL7_ID_397))]
        [Pos(2)]
        public virtual string Sequencing_02 { get; set; }
    }
    
    /// <summary>
    // Specimen Role
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SPS_7")]
    public class SpecimenRole
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_369))]
        [Pos(1)]
        public virtual string SpecimenRole01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Site Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SPS_5")]
    public class SiteModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_495))]
        [Pos(1)]
        public virtual string SiteModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Body Site
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SPS_4")]
    public class BodySite
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_163))]
        [Pos(1)]
        public virtual string BodySite01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Additives
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SPS_2")]
    public class Additives
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_371))]
        [Pos(1)]
        public virtual string Additives01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SPS")]
    public class SpecimenSource
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Specimen Source Name or Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment SpecimenSourceNameOrCode_01 { get; set; }
        /// <summary>
        // Additives
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Additives Additives_02 { get; set; }
        /// <summary>
        // Specimen Collection Method
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("SPS_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string SpecimenCollectionMethod_03 { get; set; }
        /// <summary>
        // Body Site
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual BodySite BodySite_04 { get; set; }
        /// <summary>
        // Site Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SiteModifier SiteModifier_05 { get; set; }
        /// <summary>
        // Collection Method Modifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment CollectionMethodModifierCode_06 { get; set; }
        /// <summary>
        // Specimen Role
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SpecimenRole SpecimenRole_07 { get; set; }
    }
    
    /// <summary>
    // Specialty description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SPD")]
    public class SpecialtyDescription
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Specialty Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 50)]
        [DataElement("SPD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SpecialtyName_01 { get; set; }
        /// <summary>
        // Governing Board
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("SPD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string GoverningBoard_02 { get; set; }
        /// <summary>
        // Eligible or Certified
        /// </summary>
        [DataMember]
        [DataElement("SPD_3", typeof(HL7_ID_337))]
        [Pos(3)]
        public virtual string EligibleOrCertified_03 { get; set; }
        /// <summary>
        // Date of Certification
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("SPD_4", typeof(HL7_DT))]
        [Pos(4)]
        public virtual string DateOfCertification_04 { get; set; }
    }
    
    /// <summary>
    // Structured numeric
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SN")]
    public class StructuredNumeric
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Comparator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("SN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Comparator_01 { get; set; }
        /// <summary>
        // Num1
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("SN_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string Num_02 { get; set; }
        /// <summary>
        // Separator/Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("SN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string SeparatorSuffix_03 { get; set; }
        /// <summary>
        // Num2
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("SN_4", typeof(HL7_N))]
        [Pos(4)]
        public virtual string Num_04 { get; set; }
    }
    
    /// <summary>
    // Parameter Class
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SCV_1")]
    public class ParameterClass
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_294))]
        [Pos(1)]
        public virtual string ParameterClass01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Scheduling class value pair
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("SCV")]
    public class SchedulingClassValuePair
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Parameter Class
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ParameterClass ParameterClass_01 { get; set; }
        /// <summary>
        // Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("SCV_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string ParameterValue_02 { get; set; }
    }
    
    /// <summary>
    // Repeat Pattern Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RPT_1")]
    public class RepeatPatternCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_335))]
        [Pos(1)]
        public virtual string RepeatPatternCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Repeat pattern
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RPT")]
    public class RepeatPattern
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Repeat Pattern Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RepeatPatternCode RepeatPatternCode_01 { get; set; }
        /// <summary>
        // Calendar Alignment
        /// </summary>
        [DataMember]
        [DataElement("RPT_2", typeof(HL7_ID_527))]
        [Pos(2)]
        public virtual string CalendarAlignment_02 { get; set; }
        /// <summary>
        // Phase Range Begin Value
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("RPT_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string PhaseRangeBeginValue_03 { get; set; }
        /// <summary>
        // Phase Range End Value
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("RPT_4", typeof(HL7_N))]
        [Pos(4)]
        public virtual string PhaseRangeEndValue_04 { get; set; }
        /// <summary>
        // Period Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("RPT_5", typeof(HL7_N))]
        [Pos(5)]
        public virtual string PeriodQuantity_05 { get; set; }
        /// <summary>
        // Period Units
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("RPT_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string PeriodUnits_06 { get; set; }
        /// <summary>
        // Institution Specified Time
        /// </summary>
        [DataMember]
        [DataElement("RPT_7", typeof(HL7_ID_136))]
        [Pos(7)]
        public virtual string InstitutionSpecifiedTime_07 { get; set; }
        /// <summary>
        // Event
        /// </summary>
        [DataMember]
        [DataElement("RPT_8", typeof(HL7_ID_528))]
        [Pos(8)]
        public virtual string Event_08 { get; set; }
        /// <summary>
        // Event Offset Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("RPT_9", typeof(HL7_N))]
        [Pos(9)]
        public virtual string EventOffsetQuantity_09 { get; set; }
        /// <summary>
        // Event Offset Units
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("RPT_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string EventOffsetUnits_10 { get; set; }
        /// <summary>
        // General Timing Specification
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("RPT_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string GeneralTimingSpecification_11 { get; set; }
    }
    
    /// <summary>
    // Reference pointer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RP")]
    public class ReferencePointer
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Pointer
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("RP_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Pointer_01 { get; set; }
        /// <summary>
        // Application ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AssigningFacility ApplicationID_02 { get; set; }
        /// <summary>
        // Type of Data
        /// </summary>
        [DataMember]
        [DataElement("RP_3", typeof(HL7_ID_191))]
        [Pos(3)]
        public virtual string TypeOfData_03 { get; set; }
        /// <summary>
        // Subtype
        /// </summary>
        [DataMember]
        [DataElement("RP_4", typeof(HL7_ID_291))]
        [Pos(4)]
        public virtual string Subtype_04 { get; set; }
    }
    
    /// <summary>
    // Money or Percentage
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RMC_4")]
    public class MoneyOrPercentage
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // 148 Money or Percentage Indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 2)]
        [DataElement("MOP_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MoneyOrPercentageIndicator_01 { get; set; }
        /// <summary>
        // Money or Percentage Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 16)]
        [DataElement("MOP_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string MoneyOrPercentageQuantity_02 { get; set; }
        /// <summary>
        // Currency Denomination
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("MOP_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string CurrencyDenomination_03 { get; set; }
    }
    
    /// <summary>
    // Room coverage
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RMC")]
    public class RoomCoverage
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Room Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("RMC_1", typeof(HL7_ID_145))]
        [Pos(1)]
        public virtual string RoomType_01 { get; set; }
        /// <summary>
        // Amount Type
        /// </summary>
        [DataMember]
        [DataElement("RMC_2", typeof(HL7_ID_146))]
        [Pos(2)]
        public virtual string AmountType_02 { get; set; }
        /// <summary>
        // Coverage Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("RMC_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string CoverageAmount_03 { get; set; }
        /// <summary>
        // Money or Percentage
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual MoneyOrPercentage MoneyOrPercentage_04 { get; set; }
    }
    
    /// <summary>
    // Gestational Age Range
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RFR_4")]
    public class GestationalAgeRange
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Low Value
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("NR_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string LowValue_01 { get; set; }
        /// <summary>
        // High Value
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("NR_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string HighValue_02 { get; set; }
    }
    
    /// <summary>
    // Reference range
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RFR")]
    public class ReferenceRange
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Numeric Range
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GestationalAgeRange NumericRange_01 { get; set; }
        /// <summary>
        // Administrative Sex
        /// </summary>
        [DataMember]
        [DataElement("RFR_2", typeof(HL7_ID_1))]
        [Pos(2)]
        public virtual string AdministrativeSex_02 { get; set; }
        /// <summary>
        // Age Range
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual GestationalAgeRange AgeRange_03 { get; set; }
        /// <summary>
        // Gestational Age Range
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual GestationalAgeRange GestationalAgeRange_04 { get; set; }
        /// <summary>
        // Species
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("RFR_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Species_05 { get; set; }
        /// <summary>
        // Race/subspecies
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("RFR_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Racesubspecies_06 { get; set; }
        /// <summary>
        // Conditions
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("RFR_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string Conditions_07 { get; set; }
    }
    
    /// <summary>
    // Row column definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("RCD")]
    public class RowColumnDefinition
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Segment Field Name
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("RCD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SegmentFieldName_01 { get; set; }
        /// <summary>
        // HL7 Data Type
        /// </summary>
        [DataMember]
        [DataElement("RCD_2", typeof(HL7_ID_440))]
        [Pos(2)]
        public virtual string HLDataType_02 { get; set; }
        /// <summary>
        // Maximum Column Width
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("RCD_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string MaximumColumnWidth_03 { get; set; }
    }
    
    /// <summary>
    // Query selection criteria
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("QSC")]
    public class QuerySelectionCriteria
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Segment Field Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 12)]
        [DataElement("QSC_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SegmentFieldName_01 { get; set; }
        /// <summary>
        // Relational Operator
        /// </summary>
        [DataMember]
        [DataElement("QSC_2", typeof(HL7_ID_209))]
        [Pos(2)]
        public virtual string RelationalOperator_02 { get; set; }
        /// <summary>
        // Value
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("QSC_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Value_03 { get; set; }
        /// <summary>
        // Relational Conjunction
        /// </summary>
        [DataMember]
        [DataElement("QSC_4", typeof(HL7_ID_210))]
        [Pos(4)]
        public virtual string RelationalConjunction_04 { get; set; }
    }
    
    /// <summary>
    // Policy type and amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PTA")]
    public class PolicyTypeAndAmount
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // 147 Policy Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 5)]
        [DataElement("PTA_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PolicyType_01 { get; set; }
        /// <summary>
        // 193 Amount Class
        /// </summary>
        [DataMember]
        [StringLength(0, 9)]
        [DataElement("PTA_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string AmountClass_02 { get; set; }
        /// <summary>
        // Money or Percentage Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("PTA_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string MoneyOrPercentageQuantity_03 { get; set; }
        /// <summary>
        // Money or Percentage
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual MoneyOrPercentage MoneyOrPercentage_04 { get; set; }
    }
    
    /// <summary>
    // Type of Processing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PT")]
    public class TypeOfProcessing
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Processing ID
        /// </summary>
        [DataMember]
        [DataElement("PT_1", typeof(HL7_ID_103))]
        [Pos(1)]
        public virtual string ProcessingID_01 { get; set; }
        /// <summary>
        // Processing Mode
        /// </summary>
        [DataMember]
        [DataElement("PT_2", typeof(HL7_ID_207))]
        [Pos(2)]
        public virtual string ProcessingMode_02 { get; set; }
    }
    
    /// <summary>
    // Parent result link
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PRL")]
    public class ParentResultLink
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Parent Observation Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual InternationalVersionID ParentObservationIdentifier_01 { get; set; }
        /// <summary>
        // Parent Observation Subidentifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PRL_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string ParentObservationSubidentifier_02 { get; set; }
        /// <summary>
        // Parent Observation Value Descriptor
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("PRL_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ParentObservationValueDescriptor_03 { get; set; }
    }
    
    /// <summary>
    // Performing person time stamp
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PPN")]
    public class PerformingPersonTimeStamp
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("PPN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string IDNumber_01 { get; set; }
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FamilyName FamilyName_02 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("PPN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("PPN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_04 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PPN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PPN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("PPN_7", typeof(HL7_ID_360))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source Table
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("PPN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_09 { get; set; }
        /// <summary>
        // Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("PPN_10", typeof(HL7_ID_200))]
        [Pos(10)]
        public virtual string NameTypeCode_10 { get; set; }
        /// <summary>
        // Identifier Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("PPN_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string IdentifierCheckDigit_11 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("PPN_12", typeof(HL7_ID_61))]
        [Pos(12)]
        public virtual string CheckDigitScheme_12 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("PPN_13", typeof(HL7_ID_203))]
        [Pos(13)]
        public virtual string IdentifierTypeCode_13 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningFacility AssigningFacility_14 { get; set; }
        /// <summary>
        // Date/Time Action Performed
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual ExpirationDate DateTimeActionPerformed_15 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("PPN_16", typeof(HL7_ID_465))]
        [Pos(16)]
        public virtual string NameRepresentationCode_16 { get; set; }
        /// <summary>
        // Name Context
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual NameContext NameContext_17 { get; set; }
        /// <summary>
        // Name Validity Range
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual NameValidityRange NameValidityRange_18 { get; set; }
        /// <summary>
        // Name Assembly Order
        /// </summary>
        [DataMember]
        [DataElement("PPN_19", typeof(HL7_ID_444))]
        [Pos(19)]
        public virtual string NameAssemblyOrder_19 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExpirationDate EffectiveDate_20 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual ExpirationDate ExpirationDate_21 { get; set; }
        /// <summary>
        // Professional Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("PPN_22", typeof(HL7_AN))]
        [Pos(22)]
        public virtual string ProfessionalSuffix_22 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_23 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_24 { get; set; }
    }
    
    /// <summary>
    // Person Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PN")]
    public class PersonName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Family name
        /// </summary>
        [DataMember]
        [DataElement("PN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string FamilyName_01 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [DataElement("PN_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string GivenName_02 { get; set; }
        /// <summary>
        // Middle initial or name
        /// </summary>
        [DataMember]
        [DataElement("PN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string MiddleInitialOrName_03 { get; set; }
        /// <summary>
        // Suffix
        /// </summary>
        [DataMember]
        [DataElement("PN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string Suffix_04 { get; set; }
        /// <summary>
        // Prefix
        /// </summary>
        [DataMember]
        [DataElement("PN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Prefix_05 { get; set; }
        /// <summary>
        // Degree
        /// </summary>
        [DataMember]
        [DataElement("PN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Degree_06 { get; set; }
    }
    
    /// <summary>
    // Practitioner license or other ID number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PLN")]
    public class PractitionerLicenseOrOtherIDNumber
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("PLN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string IDNumber_01 { get; set; }
        /// <summary>
        // Type of ID Number
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("PLN_2", typeof(HL7_ID_338))]
        [Pos(2)]
        public virtual string TypeOfIDNumber_02 { get; set; }
        /// <summary>
        // State/other Qualifying Information
        /// </summary>
        [DataMember]
        [StringLength(0, 62)]
        [DataElement("PLN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string StateotherQualifyingInformation_03 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("PLN_4", typeof(HL7_DT))]
        [Pos(4)]
        public virtual string ExpirationDate_04 { get; set; }
    }
    
    /// <summary>
    // Comprehensive Location Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PL_10")]
    public class ComprehensiveLocationIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Entity Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("EI_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string EntityIdentifier_01 { get; set; }
        /// <summary>
        // Namespace ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("EI_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string NamespaceID_02 { get; set; }
        /// <summary>
        // Universal ID
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("EI_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string UniversalID_03 { get; set; }
        /// <summary>
        // Universal ID Type
        /// </summary>
        [DataMember]
        [DataElement("EI_4", typeof(HL7_ID_301))]
        [Pos(4)]
        public virtual string UniversalIDType_04 { get; set; }
    }
    
    /// <summary>
    // Person location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PL")]
    public class PersonLocation
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Point of Care
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PL_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PointOfCare_01 { get; set; }
        /// <summary>
        // Room
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PL_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Room_02 { get; set; }
        /// <summary>
        // Bed
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PL_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Bed_03 { get; set; }
        /// <summary>
        // Facility
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningFacility Facility_04 { get; set; }
        /// <summary>
        // Location Status
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PL_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string LocationStatus_05 { get; set; }
        /// <summary>
        // Person Location Type
        /// </summary>
        [DataMember]
        [DataElement("PL_6", typeof(HL7_ID_305))]
        [Pos(6)]
        public virtual string PersonLocationType_06 { get; set; }
        /// <summary>
        // Building
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PL_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string Building_07 { get; set; }
        /// <summary>
        // Floor
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("PL_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string Floor_08 { get; set; }
        /// <summary>
        // Location Description
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("PL_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string LocationDescription_09 { get; set; }
        /// <summary>
        // Comprehensive Location Identifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ComprehensiveLocationIdentifier ComprehensiveLocationIdentifier_10 { get; set; }
        /// <summary>
        // Assigning Authority for Location
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AssigningFacility AssigningAuthorityForLocation_11 { get; set; }
    }
    
    /// <summary>
    // Privilege Class
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PIP_2")]
    public class PrivilegeClass
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PrivilegeClass01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate
        /// </summary>
        [DataMember]
        [DataElement("CE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternate_06 { get; set; }
    }
    
    /// <summary>
    // Privilege
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PIP_1")]
    public class Privilege
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Privilege01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate
        /// </summary>
        [DataMember]
        [DataElement("CE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternate_06 { get; set; }
    }
    
    /// <summary>
    // Practitioner institutional privileges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("PIP")]
    public class PractitionerInstitutionalPrivileges
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Privilege
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Privilege Privilege_01 { get; set; }
        /// <summary>
        // Privilege Class
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PrivilegeClass PrivilegeClass_02 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("PIP_3", typeof(HL7_DT))]
        [Pos(3)]
        public virtual string ExpirationDate_03 { get; set; }
        /// <summary>
        // Activation Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("PIP_4", typeof(HL7_DT))]
        [Pos(4)]
        public virtual string ActivationDate_04 { get; set; }
        /// <summary>
        // Facility
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier Facility_05 { get; set; }
    }
    
    /// <summary>
    // Occurrence Span Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("OSP_1")]
    public class OccurrenceSpanCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string OccurrenceSpanCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Occurrence span code and date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("OSP")]
    public class OccurrenceSpanCodeAndDate
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Occurrence Span Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OccurrenceSpanCode OccurrenceSpanCode_01 { get; set; }
        /// <summary>
        // Occurrence Span Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("OSP_2", typeof(HL7_DT))]
        [Pos(2)]
        public virtual string OccurrenceSpanStartDate_02 { get; set; }
        /// <summary>
        // Occurrence Span Stop Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("OSP_3", typeof(HL7_DT))]
        [Pos(3)]
        public virtual string OccurrenceSpanStopDate_03 { get; set; }
    }
    
    /// <summary>
    // Occurrence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("OCD_1")]
    public class OccurrenceCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string OccurrenceCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Occurrence code and date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("OCD")]
    public class OccurrenceCodeAndDate
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Occurrence Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OccurrenceCode OccurrenceCode_01 { get; set; }
        /// <summary>
        // Occurrence Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 8)]
        [DataElement("OCD_2", typeof(HL7_DT))]
        [Pos(2)]
        public virtual string OccurrenceDate_02 { get; set; }
    }
    
    /// <summary>
    // Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("NDL_1")]
    public class Name
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("CNN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string IDNumber_01 { get; set; }
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("CNN_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string FamilyName_02 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("CNN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("CNN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_04 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("CNN_7", typeof(HL7_ID_360))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source Table
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("CNN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning Authority - Namespace ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNN_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string AssigningAuthorityNamespaceID_09 { get; set; }
        /// <summary>
        // Assigning Authority - Universal ID
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNN_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string AssigningAuthorityUniversalID_10 { get; set; }
        /// <summary>
        // Assigning Authority - Universal ID Type
        /// </summary>
        [DataMember]
        [DataElement("CNN_11", typeof(HL7_ID_301))]
        [Pos(11)]
        public virtual string AssigningAuthorityUniversalIDType_11 { get; set; }
    }
    
    /// <summary>
    // Name with location and date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("NDL")]
    public class NameWithLocationAndDate
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Name Name_01 { get; set; }
        /// <summary>
        // Start Date/time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExpirationDate StartDatetime_02 { get; set; }
        /// <summary>
        // End Date/time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ExpirationDate EndDatetime_03 { get; set; }
        /// <summary>
        // Point of Care
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("NDL_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string PointOfCare_04 { get; set; }
        /// <summary>
        // Room
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("NDL_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Room_05 { get; set; }
        /// <summary>
        // Bed
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("NDL_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Bed_06 { get; set; }
        /// <summary>
        // Facility
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AssigningFacility Facility_07 { get; set; }
        /// <summary>
        // Location Status
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("NDL_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string LocationStatus_08 { get; set; }
        /// <summary>
        // Patient Location Type
        /// </summary>
        [DataMember]
        [DataElement("NDL_9", typeof(HL7_ID_305))]
        [Pos(9)]
        public virtual string PatientLocationType_09 { get; set; }
        /// <summary>
        // Building
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("NDL_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string Building_10 { get; set; }
        /// <summary>
        // Floor
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("NDL_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string Floor_11 { get; set; }
    }
    
    /// <summary>
    // Numeric array
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("NA")]
    public class NumericArray
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 16)]
        [DataElement("NA_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string NumericArray01 { get; set; }
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("NA_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string NumericArray02 { get; set; }
    }
    
    /// <summary>
    // Money and charge code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("MOC")]
    public class MoneyAndChargeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ValueAmount MonetaryAmount_01 { get; set; }
        /// <summary>
        // Charge Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual InternationalVersionID ChargeCode_02 { get; set; }
    }
    
    /// <summary>
    // Multiplexed array
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("MA")]
    public class MultiplexedArray
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sample 1 From Channel 1
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MA_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SampleFromChannel_01 { get; set; }
        /// <summary>
        // Sample 1 From Channel 2
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MA_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string SampleFromChannel_02 { get; set; }
        /// <summary>
        // Sample 1 From Channel N
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MA_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string SampleFromChannelN_03 { get; set; }
        /// <summary>
        // Sample 2 From Channel 1
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MA_4", typeof(HL7_N))]
        [Pos(4)]
        public virtual string SampleFromChannel_04 { get; set; }
        /// <summary>
        // Sample 2 From Channel N
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MA_5", typeof(HL7_N))]
        [Pos(5)]
        public virtual string SampleFromChannelN_05 { get; set; }
        /// <summary>
        // Sample N From Channel N
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("MA_6", typeof(HL7_N))]
        [Pos(6)]
        public virtual string SampleNFromChannelN_06 { get; set; }
    }
    
    /// <summary>
    // Error location and details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("LD")]
    public class ErrorLocationAndDetails
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // segment ID
        /// </summary>
        [DataMember]
        [DataElement("LD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SegmentID_01 { get; set; }
        /// <summary>
        // sequence
        /// </summary>
        [DataMember]
        [DataElement("LD_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string Sequence_02 { get; set; }
        /// <summary>
        // field position
        /// </summary>
        [DataMember]
        [DataElement("LD_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string FieldPosition_03 { get; set; }
        /// <summary>
        // code identifying error
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual InternationalVersionID CodeIdentifyingError_04 { get; set; }
    }
    
    /// <summary>
    // Location with address variation 2
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("LA2")]
    public class LocationWithAddressVariation
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // 302 Point of Care
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PointOfCare_01 { get; set; }
        /// <summary>
        // 303 Room
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Room_02 { get; set; }
        /// <summary>
        // 304 Bed
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Bed_03 { get; set; }
        /// <summary>
        // Facility
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningFacility Facility_04 { get; set; }
        /// <summary>
        // 306 Location Status
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string LocationStatus_05 { get; set; }
        /// <summary>
        // 305 Patient Location Type
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string PatientLocationType_06 { get; set; }
        /// <summary>
        // 307 Building
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string Building_07 { get; set; }
        /// <summary>
        // 308 Floor
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA2_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string Floor_08 { get; set; }
        /// <summary>
        // Street Address
        /// </summary>
        [DataMember]
        [StringLength(0, 120)]
        [DataElement("LA2_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string StreetAddress_09 { get; set; }
        /// <summary>
        // Other Designation
        /// </summary>
        [DataMember]
        [StringLength(0, 120)]
        [DataElement("LA2_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string OtherDesignation_10 { get; set; }
        /// <summary>
        // City
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("LA2_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string City_11 { get; set; }
        /// <summary>
        // State or Province
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("LA2_12", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string StateOrProvince_12 { get; set; }
        /// <summary>
        // Zip or Postal Code
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("LA2_13", typeof(HL7_AN))]
        [Pos(13)]
        public virtual string ZipOrPostalCode_13 { get; set; }
        /// <summary>
        // 399 Country
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("LA2_14", typeof(HL7_AN))]
        [Pos(14)]
        public virtual string Country_14 { get; set; }
        /// <summary>
        // 190 Address Type
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("LA2_15", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string AddressType_15 { get; set; }
        /// <summary>
        // Other Geographic Designation
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("LA2_16", typeof(HL7_AN))]
        [Pos(16)]
        public virtual string OtherGeographicDesignation_16 { get; set; }
    }
    
    /// <summary>
    // Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("LA1_9")]
    public class Address
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Street Address
        /// </summary>
        [DataMember]
        [StringLength(0, 120)]
        [DataElement("AD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string StreetAddress_01 { get; set; }
        /// <summary>
        // Other Designation
        /// </summary>
        [DataMember]
        [StringLength(0, 120)]
        [DataElement("AD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string OtherDesignation_02 { get; set; }
        /// <summary>
        // City
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("AD_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string City_03 { get; set; }
        /// <summary>
        // State or Province
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("AD_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string StateOrProvince_04 { get; set; }
        /// <summary>
        // Zip or Postal COde
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("AD_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string ZipOrPostalCOde_05 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [DataElement("AD_6", typeof(HL7_ID_399))]
        [Pos(6)]
        public virtual string Country_06 { get; set; }
        /// <summary>
        // Address Type
        /// </summary>
        [DataMember]
        [DataElement("AD_7", typeof(HL7_ID_190))]
        [Pos(7)]
        public virtual string AddressType_07 { get; set; }
        /// <summary>
        // Other Geographic Designation
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("AD_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string OtherGeographicDesignation_08 { get; set; }
    }
    
    /// <summary>
    // Location with address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("LA1")]
    public class LocationWithAddress
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // 302 Point of Care
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PointOfCare_01 { get; set; }
        /// <summary>
        // 303 Room
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Room_02 { get; set; }
        /// <summary>
        // 304 Bed
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Bed_03 { get; set; }
        /// <summary>
        // Facility
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningFacility Facility_04 { get; set; }
        /// <summary>
        // 306 Location Status
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string LocationStatus_05 { get; set; }
        /// <summary>
        // 305 Patient Location Type
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string PatientLocationType_06 { get; set; }
        /// <summary>
        // 307 Building
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string Building_07 { get; set; }
        /// <summary>
        // 308 Floor
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("LA1_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string Floor_08 { get; set; }
        /// <summary>
        // Address
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Address Address_09 { get; set; }
    }
    
    /// <summary>
    // Job code/class
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("JCC")]
    public class JobCodeclass
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Job Code
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("JCC_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string JobCode_01 { get; set; }
        /// <summary>
        // Job Class
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("JCC_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string JobClass_02 { get; set; }
        /// <summary>
        // Job Description Text
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("JCC_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string JobDescriptionText_03 { get; set; }
    }
    
    /// <summary>
    // Insurance certification definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("ICD")]
    public class InsuranceCertificationDefinition
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // 150 Certification Patient Type
        /// </summary>
        [DataMember]
        [StringLength(0, 11)]
        [DataElement("ICD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CertificationPatientType_01 { get; set; }
        /// <summary>
        // 136 Certification Required
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 1)]
        [DataElement("ICD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CertificationRequired_02 { get; set; }
        /// <summary>
        // Date/Time Certification Required
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ExpirationDate DateTimeCertificationRequired_03 { get; set; }
    }
    
    /// <summary>
    // Financial class
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("FC")]
    public class FinancialClass
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Financial Class Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("FC_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string FinancialClassCode_01 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExpirationDate EffectiveDate_02 { get; set; }
    }
    
    /// <summary>
    // Error location and description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("ELD")]
    public class ErrorLocationAndDescription
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Segment ID
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("ELD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SegmentID_01 { get; set; }
        /// <summary>
        // Segment Sequence
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("ELD_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string SegmentSequence_02 { get; set; }
        /// <summary>
        // Field Position
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("ELD_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string FieldPosition_03 { get; set; }
        /// <summary>
        // Code Identifying Error
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CodeIdentifyingError CodeIdentifyingError_04 { get; set; }
    }
    
    /// <summary>
    // Entity identifier pair
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("EIP")]
    public class EntityIdentifierPair
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Placer Assigned Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier PlacerAssignedIdentifier_01 { get; set; }
        /// <summary>
        // Filler Assigned Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier FillerAssignedIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // Encapsulated data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("ED")]
    public class EncapsulatedData
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Source Application
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AssigningFacility SourceApplication_01 { get; set; }
        /// <summary>
        // Type of Data
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("ED_2", typeof(HL7_ID_191))]
        [Pos(2)]
        public virtual string TypeOfData_02 { get; set; }
        /// <summary>
        // Data Subtype
        /// </summary>
        [DataMember]
        [DataElement("ED_3", typeof(HL7_ID_291))]
        [Pos(3)]
        public virtual string DataSubtype_03 { get; set; }
        /// <summary>
        // Encoding
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("ED_4", typeof(HL7_ID_299))]
        [Pos(4)]
        public virtual string Encoding_04 { get; set; }
        /// <summary>
        // Data
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("ED_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Data_05 { get; set; }
    }
    
    /// <summary>
    // Day type and number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DTN")]
    public class DayTypeAndNumber
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Day Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("DTN_1", typeof(HL7_ID_149))]
        [Pos(1)]
        public virtual string DayType_01 { get; set; }
        /// <summary>
        // Number of Days
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 3)]
        [DataElement("DTN_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string NumberOfDays_02 { get; set; }
    }
    
    /// <summary>
    // Delta
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DLT")]
    public class Delta
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Normal Range
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual GestationalAgeRange NormalRange_01 { get; set; }
        /// <summary>
        // Numeric Threshold
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("DLT_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string NumericThreshold_02 { get; set; }
        /// <summary>
        // Change Computation
        /// </summary>
        [DataMember]
        [DataElement("DLT_3", typeof(HL7_ID_523))]
        [Pos(3)]
        public virtual string ChangeComputation_03 { get; set; }
        /// <summary>
        // Days Retained
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("DLT_4", typeof(HL7_N))]
        [Pos(4)]
        public virtual string DaysRetained_04 { get; set; }
    }
    
    /// <summary>
    // Driver's license number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DLN")]
    public class DriversLicenseNumber
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // License Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("DLN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string LicenseNumber_01 { get; set; }
        /// <summary>
        // Issuing State
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("DLN_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string IssuingState_02 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("DLN_3", typeof(HL7_DT))]
        [Pos(3)]
        public virtual string ExpirationDate_03 { get; set; }
    }
    
    /// <summary>
    // Discharge to location and date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DLD")]
    public class DischargeToLocationAndDate
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Discharge Location
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("DLD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DischargeLocation_01 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExpirationDate EffectiveDate_02 { get; set; }
    }
    
    /// <summary>
    // Institution Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DIN_2")]
    public class InstitutionName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string InstitutionName01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate
        /// </summary>
        [DataMember]
        [DataElement("CE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternate_06 { get; set; }
    }
    
    /// <summary>
    // Date and institution name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DIN")]
    public class DateAndInstitutionName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ExpirationDate Date_01 { get; set; }
        /// <summary>
        // Institution Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual InstitutionName InstitutionName_02 { get; set; }
    }
    
    /// <summary>
    // Daily deductible information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("DDI")]
    public class DailyDeductibleInformation
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Delay Days
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("DDI_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string DelayDays_01 { get; set; }
        /// <summary>
        // Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ValueAmount MonetaryAmount_02 { get; set; }
        /// <summary>
        // Number of Days
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("DDI_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string NumberOfDays_03 { get; set; }
    }
    
    /// <summary>
    // Extended composite ID with check digit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CX")]
    public class ExtendedCompositeIDWithCheckDigit
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("CX_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string IDNumber_01 { get; set; }
        /// <summary>
        // Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("CX_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CheckDigit_02 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("CX_3", typeof(HL7_ID_61))]
        [Pos(3)]
        public virtual string CheckDigitScheme_03 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_04 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("CX_5", typeof(HL7_ID_203))]
        [Pos(5)]
        public virtual string IdentifierTypeCode_05 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningFacility AssigningFacility_06 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("CX_7", typeof(HL7_DT))]
        [Pos(7)]
        public virtual string EffectiveDate_07 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("CX_8", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string ExpirationDate_08 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_09 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_10 { get; set; }
    }
    
    /// <summary>
    // Channel sensitivity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CSU")]
    public class ChannelSensitivity
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Channel Sensitivity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("CSU_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string ChannelSensitivity_01 { get; set; }
        /// <summary>
        // Unit of Measure Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CSU_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string UnitOfMeasureIdentifier_02 { get; set; }
        /// <summary>
        // Unit of Measure Description
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CSU_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string UnitOfMeasureDescription_03 { get; set; }
        /// <summary>
        // Unit of Measure Coding System
        /// </summary>
        [DataMember]
        [DataElement("CSU_4", typeof(HL7_ID_396))]
        [Pos(4)]
        public virtual string UnitOfMeasureCodingSystem_04 { get; set; }
        /// <summary>
        // Alternate Unit of Measure Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CSU_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateUnitOfMeasureIdentifier_05 { get; set; }
        /// <summary>
        // Alternate Unit of Measure Description
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CSU_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string AlternateUnitOfMeasureDescription_06 { get; set; }
        /// <summary>
        // Alternate Unit of Measure Coding System
        /// </summary>
        [DataMember]
        [DataElement("CSU_7", typeof(HL7_ID_396))]
        [Pos(7)]
        public virtual string AlternateUnitOfMeasureCodingSystem_07 { get; set; }
    }
    
    /// <summary>
    // Composite price
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CP")]
    public class CompositePrice
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Price
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ValueAmount Price_01 { get; set; }
        /// <summary>
        // Price Type
        /// </summary>
        [DataMember]
        [DataElement("CP_2", typeof(HL7_ID_205))]
        [Pos(2)]
        public virtual string PriceType_02 { get; set; }
        /// <summary>
        // From Value
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("CP_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string FromValue_03 { get; set; }
        /// <summary>
        // To Value
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("CP_4", typeof(HL7_N))]
        [Pos(4)]
        public virtual string ToValue_04 { get; set; }
        /// <summary>
        // Range Units
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual InternationalVersionID RangeUnits_05 { get; set; }
        /// <summary>
        // Range Type
        /// </summary>
        [DataMember]
        [DataElement("CP_6", typeof(HL7_ID_298))]
        [Pos(6)]
        public virtual string RangeType_06 { get; set; }
    }
    
    /// <summary>
    // Composite name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CNS_1")]
    public class CompositeName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID
        /// </summary>
        [DataMember]
        [DataElement("CN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ID_01 { get; set; }
        /// <summary>
        // Family name
        /// </summary>
        [DataMember]
        [DataElement("CN_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string FamilyName_02 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [DataElement("CN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Middle initial or name
        /// </summary>
        [DataMember]
        [DataElement("CN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string MiddleInitialOrName_04 { get; set; }
        /// <summary>
        // Suffix
        /// </summary>
        [DataMember]
        [DataElement("CN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix
        /// </summary>
        [DataMember]
        [DataElement("CN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree
        /// </summary>
        [DataMember]
        [DataElement("CN_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source table
        /// </summary>
        [DataMember]
        [DataElement("CN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning authority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAuthority AssigningAuthority_09 { get; set; }
    }
    
    /// <summary>
    // Composite ID number and name simplified
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CNS")]
    public class CompositeIDNumberAndNameSimplified
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Composite name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CompositeName CompositeName_01 { get; set; }
        /// <summary>
        // start date/time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExpirationDate StartDatetime_02 { get; set; }
        /// <summary>
        // end date/time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ExpirationDate EndDatetime_03 { get; set; }
        /// <summary>
        // point of care
        /// </summary>
        [DataMember]
        [DataElement("CNS_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string PointOfCare_04 { get; set; }
        /// <summary>
        // room
        /// </summary>
        [DataMember]
        [DataElement("CNS_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Room_05 { get; set; }
        /// <summary>
        // bed
        /// </summary>
        [DataMember]
        [DataElement("CNS_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Bed_06 { get; set; }
        /// <summary>
        // facility
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AssigningFacility Facility_07 { get; set; }
        /// <summary>
        // location status
        /// </summary>
        [DataMember]
        [DataElement("CNS_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string LocationStatus_08 { get; set; }
        /// <summary>
        // patient location type
        /// </summary>
        [DataMember]
        [DataElement("CNS_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string PatientLocationType_09 { get; set; }
        /// <summary>
        // building
        /// </summary>
        [DataMember]
        [DataElement("CNS_10", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string Building_10 { get; set; }
        /// <summary>
        // floor
        /// </summary>
        [DataMember]
        [DataElement("CNS_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string Floor_11 { get; set; }
    }
    
    /// <summary>
    // Coded with no exceptions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CNE")]
    public class CodedWithNoExceptions
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Identifier_01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Composite
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CM")]
    public class Composite
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CM_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Composite01 { get; set; }
        [DataMember]
        [DataElement("CM_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Composite02 { get; set; }
    }
    
    /// <summary>
    // Composite ID with check digit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CK")]
    public class CompositeIDWithCheckDigit
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ID Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("CK_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string IDNumber_01 { get; set; }
        /// <summary>
        // Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("CK_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CheckDigit_02 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("CK_3", typeof(HL7_ID_61))]
        [Pos(3)]
        public virtual string CheckDigitScheme_03 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_04 { get; set; }
    }
    
    /// <summary>
    // Coded element with formatted values
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CF")]
    public class CodedElementWithFormattedValues
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CF_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Identifier_01 { get; set; }
        /// <summary>
        // Formatted Text
        /// </summary>
        [DataMember]
        [DataElement("CF_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string FormattedText_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CF_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CF_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Formatted Text
        /// </summary>
        [DataMember]
        [DataElement("CF_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateFormattedText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CF_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
    }
    
    /// <summary>
    // Channel Calibration Parameters
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CD_4")]
    public class ChannelCalibrationParameters
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Channel Calibration Sensitivity Correction Factor
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("CCP_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string ChannelCalibrationSensitivityCorrectionFactor_01 { get; set; }
        /// <summary>
        // Channel Calibration Baseline
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("CCP_2", typeof(HL7_N))]
        [Pos(2)]
        public virtual string ChannelCalibrationBaseline_02 { get; set; }
        /// <summary>
        // Channel Calibration Time Skew
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("CCP_3", typeof(HL7_N))]
        [Pos(3)]
        public virtual string ChannelCalibrationTimeSkew_03 { get; set; }
    }
    
    /// <summary>
    // Charge code and date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CCD")]
    public class ChargeCodeAndDate
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Invocation Event
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("CCD_1", typeof(HL7_ID_100))]
        [Pos(1)]
        public virtual string InvocationEvent_01 { get; set; }
        /// <summary>
        // Date/time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExpirationDate Datetime_02 { get; set; }
    }
    
    /// <summary>
    // Authorization information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("AUI")]
    public class AuthorizationInformation
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Authorization Number
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("AUI_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AuthorizationNumber_01 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("AUI_2", typeof(HL7_DT))]
        [Pos(2)]
        public virtual string Date_02 { get; set; }
        /// <summary>
        // Source
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("AUI_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Source_03 { get; set; }
    }
    
    /// <summary>
    // User Authentication Credential Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02267")]
    public class UserAuthenticationCredentialTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_615))]
        [Pos(1)]
        public virtual string UserAuthenticationCredentialTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Supply Risk Codes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02266")]
    public class SupplyRiskCodes
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_871))]
        [Pos(1)]
        public virtual string SupplyRiskCodes01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Documentation Completion Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02262")]
    public class ReferralDocumentationCompletionStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ReferralDocumentationCompletionStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Provider Organization Method of Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02260")]
    public class ProviderOrganizationMethodOfContact
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_185))]
        [Pos(1)]
        public virtual string ProviderOrganizationMethodOfContact01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Mood Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02239")]
    public class MoodCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_725))]
        [Pos(1)]
        public virtual string MoodCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Problem Perspective
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02235")]
    public class ProblemPerspective
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ProblemPerspective01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Problem Severity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02234")]
    public class ProblemSeverity
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ProblemSeverity01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Default Order Unit Of Measure Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02223")]
    public class DefaultOrderUnitOfMeasureIndicator
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_532))]
        [Pos(1)]
        public virtual string DefaultOrderUnitOfMeasureIndicator01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Packaging Units
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02222")]
    public class PackagingUnits
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_818))]
        [Pos(1)]
        public virtual string PackagingUnits01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Maintenance Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02216")]
    public class MaintenanceType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MaintenanceType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Maintenance Cycle
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02215")]
    public class MaintenanceCycle
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MaintenanceCycle01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Sterilization Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02213")]
    public class SterilizationType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_806))]
        [Pos(1)]
        public virtual string SterilizationType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Ruling Act
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02201")]
    public class RulingAct
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_793))]
        [Pos(1)]
        public virtual string RulingAct01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Item Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02188")]
    public class ItemType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_778))]
        [Pos(1)]
        public virtual string ItemType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Status of item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02187")]
    public class StatusOfItem
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_776))]
        [Pos(1)]
        public virtual string StatusOfItem01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Generic resource type or category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02184")]
    public class GenericResourceTypeOrCategory
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string GenericResourceTypeOrCategory01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Observation Site
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02179")]
    public class ObservationSite
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_163))]
        [Pos(1)]
        public virtual string ObservationSite01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // PCCL Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02158")]
    public class PCCLValueCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_728))]
        [Pos(1)]
        public virtual string PCCLValueCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Grouper Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02157")]
    public class GrouperStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_734))]
        [Pos(1)]
        public virtual string GrouperStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Access Restriction Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02146")]
    public class AccessRestrictionReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_719))]
        [Pos(1)]
        public virtual string AccessRestrictionReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Access Restriction Value
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02145")]
    public class AccessRestrictionValue
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_717))]
        [Pos(1)]
        public virtual string AccessRestrictionValue01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Access Restriction Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02144")]
    public class AccessRestrictionActionCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_206))]
        [Pos(1)]
        public virtual string AccessRestrictionActionCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Cycle Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02131")]
    public class CycleType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_702))]
        [Pos(1)]
        public virtual string CycleType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Device Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02113")]
    public class DeviceStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_682))]
        [Pos(1)]
        public virtual string DeviceStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Lot Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02093")]
    public class LotControl
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_659))]
        [Pos(1)]
        public virtual string LotControl01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Device Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02092")]
    public class DeviceType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_657))]
        [Pos(1)]
        public virtual string DeviceType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Date Format
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02089")]
    public class DateFormat
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_653))]
        [Pos(1)]
        public virtual string DateFormat01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Labor Calculation Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02088")]
    public class LaborCalculationType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_651))]
        [Pos(1)]
        public virtual string LaborCalculationType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Recommended Reorder Theory
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02080")]
    public class RecommendedReorderTheory
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_642))]
        [Pos(1)]
        public virtual string RecommendedReorderTheory01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Item Importance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02073")]
    public class ItemImportanceCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_634))]
        [Pos(1)]
        public virtual string ItemImportanceCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Item Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02065")]
    public class ItemStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_625))]
        [Pos(1)]
        public virtual string ItemStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // IPR Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02033")]
    public class IPRStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_571))]
        [Pos(1)]
        public virtual string IPRStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Payment Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02021")]
    public class PaymentMethod
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_570))]
        [Pos(1)]
        public virtual string PaymentMethod01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Adjustment Reason PA
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02009")]
    public class AdjustmentReasonPA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_565))]
        [Pos(1)]
        public virtual string AdjustmentReasonPA01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Adjustment Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("02008")]
    public class AdjustmentQuantity
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("CQ_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        [DataMember]
        [DataElement("CQ_2", typeof(HL7_ID_560))]
        [Pos(2)]
        public virtual string AdjustmentQuantity02 { get; set; }
    }
    
    /// <summary>
    // Side of body
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01987")]
    public class SideOfBody
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_894))]
        [Pos(1)]
        public virtual string SideOfBody01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Medical Role Executing Physician
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01986")]
    public class MedicalRoleExecutingPhysician
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_882))]
        [Pos(1)]
        public virtual string MedicalRoleExecutingPhysician01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Role Executing Physician
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01985")]
    public class RoleExecutingPhysician
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_881))]
        [Pos(1)]
        public virtual string RoleExecutingPhysician01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Related Product/Service Code Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01976")]
    public class RelatedProductServiceCodeIndicator
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string RelatedProductServiceCodeIndicator01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Product/Service Code Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01962")]
    public class ProductServiceCodeModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ProductServiceCodeModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Product/Service Line Item Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01960")]
    public class ProductServiceLineItemStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_559))]
        [Pos(1)]
        public virtual string ProductServiceLineItemStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01908")]
    public class SpecimenHandlingCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_376))]
        [Pos(1)]
        public virtual string SpecimenHandlingCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Risk Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01903")]
    public class SpecimenRiskCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_489))]
        [Pos(1)]
        public virtual string SpecimenRiskCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01900")]
    public class SpecimenType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_487))]
        [Pos(1)]
        public virtual string SpecimenType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Jurisdiction Breadth
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01895")]
    public class JurisdictionBreadth
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_547))]
        [Pos(1)]
        public virtual string JurisdictionBreadth01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Inactive Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01893")]
    public class InactiveReasonCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_540))]
        [Pos(1)]
        public virtual string InactiveReasonCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Cost Center Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01891")]
    public class CostCenterCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CostCenterCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Institution Relationship Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01888")]
    public class InstitutionRelationshipTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_538))]
        [Pos(1)]
        public virtual string InstitutionRelationshipTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Certificate Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01884")]
    public class CertificateStatusCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_536))]
        [Pos(1)]
        public virtual string CertificateStatusCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Jurisdiction County/Parish
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01874")]
    public class JurisdictionCountyParish
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string JurisdictionCountyParish01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Jurisdiction State/Province
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01873")]
    public class JurisdictionStateProvince
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_347))]
        [Pos(1)]
        public virtual string JurisdictionStateProvince01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // NDC Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01845")]
    public class NDCCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string NDCCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Tribal Citizenship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01840")]
    public class TribalCitizenship
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string TribalCitizenship01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Business Rule Override Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01830")]
    public class BusinessRuleOverrideCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string BusinessRuleOverrideCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Business Rule Override Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01829")]
    public class BusinessRuleOverrideType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_518))]
        [Pos(1)]
        public virtual string BusinessRuleOverrideType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Non-subject Consenter Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01798")]
    public class NonsubjectConsenterReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_502))]
        [Pos(1)]
        public virtual string NonsubjectConsenterReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Non-disclosure Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01797")]
    public class ConsentNondisclosureReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_501))]
        [Pos(1)]
        public virtual string ConsentNondisclosureReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Bypass Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01795")]
    public class ConsentBypassReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_499))]
        [Pos(1)]
        public virtual string ConsentBypassReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Language Translated To
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01793")]
    public class LanguageTranslatedTo
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string LanguageTranslatedTo01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01786")]
    public class ConsentStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_498))]
        [Pos(1)]
        public virtual string ConsentStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Mode
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01785")]
    public class ConsentMode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_497))]
        [Pos(1)]
        public virtual string ConsentMode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01777")]
    public class ConsentType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_496))]
        [Pos(1)]
        public virtual string ConsentType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Child Role
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01775")]
    public class SpecimenChildRole
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_494))]
        [Pos(1)]
        public virtual string SpecimenChildRole01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Container Condition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01774")]
    public class ContainerCondition
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ContainerCondition01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Condition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01770")]
    public class SpecimenCondition
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_493))]
        [Pos(1)]
        public virtual string SpecimenCondition01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Appropriateness
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01769")]
    public class SpecimenAppropriateness
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_492))]
        [Pos(1)]
        public virtual string SpecimenAppropriateness01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Quality
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01768")]
    public class SpecimenQuality
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_491))]
        [Pos(1)]
        public virtual string SpecimenQuality01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Reject Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01767")]
    public class SpecimenRejectReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_490))]
        [Pos(1)]
        public virtual string SpecimenRejectReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Collection Site
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01761")]
    public class SpecimenCollectionSite
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SpecimenCollectionSite01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Source Site Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01760")]
    public class SpecimenSourceSiteModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SpecimenSourceSiteModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Collection Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01759")]
    public class SpecimenCollectionMethod
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_488))]
        [Pos(1)]
        public virtual string SpecimenCollectionMethod01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Additives
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01758")]
    public class SpecimenAdditives
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_371))]
        [Pos(1)]
        public virtual string SpecimenAdditives01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Type Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01757")]
    public class SpecimenTypeModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SpecimenTypeModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // BP Transfusion Interrupted Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01753")]
    public class BPTransfusionInterruptedReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string BPTransfusionInterruptedReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // BP Adverse Reaction Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01752")]
    public class BPAdverseReactionType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_514))]
        [Pos(1)]
        public virtual string BPAdverseReactionType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // BP Transfusion/Disposition Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01745")]
    public class BPTransfusionDispositionStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_513))]
        [Pos(1)]
        public virtual string BPTransfusionDispositionStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // CP Commercial Product
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01739")]
    public class CPCommercialProduct
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CPCommercialProduct01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // BP Dispense Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01715")]
    public class BPDispenseStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_510))]
        [Pos(1)]
        public virtual string BPDispenseStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // BP Indication for Use
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01712")]
    public class BPIndicationForUse
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string BPIndicationForUse01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // BP Processing Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01702")]
    public class BPProcessingRequirements
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_508))]
        [Pos(1)]
        public virtual string BPProcessingRequirements01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Dispense Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01691")]
    public class DispenseType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_484))]
        [Pos(1)]
        public virtual string DispenseType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Controlled Substance Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01676")]
    public class ControlledSubstanceSchedule
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_477))]
        [Pos(1)]
        public virtual string ControlledSubstanceSchedule01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Administration Site Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01670")]
    public class AdministrationSiteModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_495))]
        [Pos(1)]
        public virtual string AdministrationSiteModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Medically Necessary Duplicate Procedure Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01646")]
    public class MedicallyNecessaryDuplicateProcedureReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MedicallyNecessaryDuplicateProcedureReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Charge Type Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01645")]
    public class ChargeTypeReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_475))]
        [Pos(1)]
        public virtual string ChargeTypeReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Enterer Authorization Mode
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01644")]
    public class EntererAuthorizationMode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_483))]
        [Pos(1)]
        public virtual string EntererAuthorizationMode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Order Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01643")]
    public class OrderType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_482))]
        [Pos(1)]
        public virtual string OrderType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Advanced Beneficiary Notice Override Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01641")]
    public class AdvancedBeneficiaryNoticeOverrideReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AdvancedBeneficiaryNoticeOverrideReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Priority
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01635")]
    public class Priority
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_485))]
        [Pos(1)]
        public virtual string Priority01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Organization Unit Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01625")]
    public class OrganizationUnitTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_474))]
        [Pos(1)]
        public virtual string OrganizationUnitTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Health Care Provider Classification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01614")]
    public class HealthCareProviderClassificationCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string HealthCareProviderClassificationCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Health Care Provider Area of Specialization Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01615")]
    public class HealthCareProviderAreaOfSpecializationCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string HealthCareProviderAreaOfSpecializationCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Institution
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01613")]
    public class Institution
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Institution01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Ambulatory Payment Classification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01609")]
    public class AmbulatoryPaymentClassificationCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_466))]
        [Pos(1)]
        public virtual string AmbulatoryPaymentClassificationCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Location Cost Center
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01584")]
    public class LocationCostCenter
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string LocationCostCenter01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Allergy Clinical Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01562")]
    public class AllergyClinicalStatusCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_438))]
        [Pos(1)]
        public virtual string AllergyClinicalStatusCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Alert Device Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01561")]
    public class AlertDeviceCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_437))]
        [Pos(1)]
        public virtual string AlertDeviceCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Relationship to Patient Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01560")]
    public class RelationshipToPatientCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_63))]
        [Pos(1)]
        public virtual string RelationshipToPatientCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Sensitivity to Causative Agent Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01554")]
    public class SensitivityToCausativeAgentCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_436))]
        [Pos(1)]
        public virtual string SensitivityToCausativeAgentCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Advance Directive Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01548")]
    public class AdvanceDirectiveCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_435))]
        [Pos(1)]
        public virtual string AdvanceDirectiveCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Patient Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01547")]
    public class PatientConditionCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_434))]
        [Pos(1)]
        public virtual string PatientConditionCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Precaution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01546")]
    public class PrecautionCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_433))]
        [Pos(1)]
        public virtual string PrecautionCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Admission Level of Care Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01545")]
    public class AdmissionLevelOfCareCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_432))]
        [Pos(1)]
        public virtual string AdmissionLevelOfCareCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Recreational Drug Use Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01544")]
    public class RecreationalDrugUseCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_431))]
        [Pos(1)]
        public virtual string RecreationalDrugUseCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Mode of Arrival Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01543")]
    public class ModeOfArrivalCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_430))]
        [Pos(1)]
        public virtual string ModeOfArrivalCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Production Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01542")]
    public class ProductionClassCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_429))]
        [Pos(1)]
        public virtual string ProductionClassCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Breed Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01540")]
    public class BreedCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string BreedCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Species Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01539")]
    public class SpeciesCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SpeciesCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Incident Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01533")]
    public class IncidentTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_428))]
        [Pos(1)]
        public virtual string IncidentTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Risk Management Incident Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01530")]
    public class RiskManagementIncidentCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_427))]
        [Pos(1)]
        public virtual string RiskManagementIncidentCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Newborn Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01526")]
    public class NewbornCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_425))]
        [Pos(1)]
        public virtual string NewbornCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Gestation Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01524")]
    public class GestationCategoryCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_424))]
        [Pos(1)]
        public virtual string GestationCategoryCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Case Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01522")]
    public class CaseCategoryCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_423))]
        [Pos(1)]
        public virtual string CaseCategoryCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Triage Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01519")]
    public class TriageCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_422))]
        [Pos(1)]
        public virtual string TriageCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Severity of Illness Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01516")]
    public class SeverityOfIllnessCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_421))]
        [Pos(1)]
        public virtual string SeverityOfIllnessCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Transfer Medical Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01515")]
    public class TransferMedicalServiceCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_69))]
        [Pos(1)]
        public virtual string TransferMedicalServiceCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Discharge Care Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01514")]
    public class DischargeCareProvider
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("XCN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DischargeCareProvider01 { get; set; }
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FamilyName FamilyName_02 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_04 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("XCN_7", typeof(HL7_ID_360))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source Table
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("XCN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_09 { get; set; }
        /// <summary>
        // Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_10", typeof(HL7_ID_200))]
        [Pos(10)]
        public virtual string NameTypeCode_10 { get; set; }
        /// <summary>
        // Identifier Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("XCN_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string IdentifierCheckDigit_11 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("XCN_12", typeof(HL7_ID_61))]
        [Pos(12)]
        public virtual string CheckDigitScheme_12 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_13", typeof(HL7_ID_203))]
        [Pos(13)]
        public virtual string IdentifierTypeCode_13 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningFacility AssigningFacility_14 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_15", typeof(HL7_ID_465))]
        [Pos(15)]
        public virtual string NameRepresentationCode_15 { get; set; }
        /// <summary>
        // Name Context
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual NameContext NameContext_16 { get; set; }
        /// <summary>
        // Name Validity Range
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual NameValidityRange NameValidityRange_17 { get; set; }
        /// <summary>
        // Name Assembly Order
        /// </summary>
        [DataMember]
        [DataElement("XCN_18", typeof(HL7_ID_444))]
        [Pos(18)]
        public virtual string NameAssemblyOrder_18 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExpirationDate EffectiveDate_19 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExpirationDate ExpirationDate_20 { get; set; }
        /// <summary>
        // Professional Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XCN_21", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string ProfessionalSuffix_21 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_22 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_23 { get; set; }
    }
    
    /// <summary>
    // Tissue Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01502")]
    public class TissueTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_417))]
        [Pos(1)]
        public virtual string TissueTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Category Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01481")]
    public class CategoryIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CategoryIdentifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Waiting Period Units
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01496")]
    public class ConsentWaitingPeriodUnits
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ConsentWaitingPeriodUnits01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01490")]
    public class ConsentIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ConsentIdentifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Filler Supplemental Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01475")]
    public class FillerSupplementalServiceInformation
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string FillerSupplementalServiceInformation01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Health Care Provider Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01464")]
    public class HealthCareProviderTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string HealthCareProviderTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Organization Unit Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01461")]
    public class OrganizationUnitType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_406))]
        [Pos(1)]
        public virtual string OrganizationUnitType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Organization Unit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01460")]
    public class OrganizationUnitCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string OrganizationUnitCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Language Proficiency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01458")]
    public class LanguageProficiencyCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_404))]
        [Pos(1)]
        public virtual string LanguageProficiencyCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Language Ability Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01457")]
    public class LanguageAbilityCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_403))]
        [Pos(1)]
        public virtual string LanguageAbilityCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // School Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01453")]
    public class SchoolTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_402))]
        [Pos(1)]
        public virtual string SchoolTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Response Modality
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01440")]
    public class ResponseModality
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CNE_1", typeof(HL7_ID_394))]
        [Pos(1)]
        public virtual string ResponseModality01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Algorithm Descriptor
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01438")]
    public class AlgorithmDescriptor
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_393))]
        [Pos(1)]
        public virtual string AlgorithmDescriptor01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Event type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01430")]
    public class EventType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_450))]
        [Pos(1)]
        public virtual string EventType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Substance Manufacturer Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01429")]
    public class SubstanceManufacturerIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SubstanceManufacturerIdentifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Analyte Repeat Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01425")]
    public class AnalyteRepeatStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_389))]
        [Pos(1)]
        public virtual string AnalyteRepeatStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Processing Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01419")]
    public class ProcessingType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_388))]
        [Pos(1)]
        public virtual string ProcessingType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Notification Alert Severity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01400")]
    public class NotificationAlertSeverity
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_367))]
        [Pos(1)]
        public virtual string NotificationAlertSeverity01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Command Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01395")]
    public class CommandResponse
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_387))]
        [Pos(1)]
        public virtual string CommandResponse01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Remote Control Command
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01391")]
    public class RemoteControlCommand
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_368))]
        [Pos(1)]
        public virtual string RemoteControlCommand01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Supplier Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01389")]
    public class SupplierIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SupplierIdentifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Government Reimbursement Billing Eligibility
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01388")]
    public class GovernmentReimbursementBillingEligibility
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_401))]
        [Pos(1)]
        public virtual string GovernmentReimbursementBillingEligibility01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Message Query Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01375")]
    public class MessageQueryName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MessageQueryName01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Drug Interference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01368")]
    public class DrugInterference
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DrugInterference01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Substance Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01374")]
    public class SubstanceType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_384))]
        [Pos(1)]
        public virtual string SubstanceType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Substance Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01373")]
    public class SubstanceStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_383))]
        [Pos(1)]
        public virtual string SubstanceStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Substance Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01372")]
    public class SubstanceIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_451))]
        [Pos(1)]
        public virtual string SubstanceIdentifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Other Environmental Factors
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01371")]
    public class OtherEnvironmentalFactors
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_377))]
        [Pos(1)]
        public virtual string OtherEnvironmentalFactors01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Artificial Blood
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01369")]
    public class ArtificialBlood
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_375))]
        [Pos(1)]
        public virtual string ArtificialBlood01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // System Induced Contaminants
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01367")]
    public class SystemInducedContaminants
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_374))]
        [Pos(1)]
        public virtual string SystemInducedContaminants01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Treatment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01357")]
    public class Treatment
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_373))]
        [Pos(1)]
        public virtual string Treatment01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specimen Component
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01355")]
    public class SpecimenComponent
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_372))]
        [Pos(1)]
        public virtual string SpecimenComponent01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Cap Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01353")]
    public class CapType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CapType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Separator Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01352")]
    public class SeparatorType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SeparatorType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Tray Type - SAC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01339")]
    public class TrayTypeSAC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string TrayTypeSAC01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Carrier Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01336")]
    public class CarrierType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CarrierType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Container Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01335")]
    public class ContainerStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_370))]
        [Pos(1)]
        public virtual string ContainerStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Local/Remote Control State
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01324")]
    public class LocalRemoteControlState
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_366))]
        [Pos(1)]
        public virtual string LocalRemoteControlState01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Equipment State
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01323")]
    public class EquipmentState
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_365))]
        [Pos(1)]
        public virtual string EquipmentState01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Comment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01318")]
    public class CommentType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_364))]
        [Pos(1)]
        public virtual string CommentType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Procedure Code Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01316")]
    public class ProcedureCodeModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ProcedureCodeModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Advanced Beneficiary Notice Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01310")]
    public class AdvancedBeneficiaryNoticeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_339))]
        [Pos(1)]
        public virtual string AdvancedBeneficiaryNoticeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Primary Key Value - CDM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01306")]
    public class PrimaryKeyValueCDM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PrimaryKeyValueCDM01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Location Characteristic ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01295")]
    public class LocationCharacteristicID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_324))]
        [Pos(1)]
        public virtual string LocationCharacteristicID01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Location Characteristic Value - LCH
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01294")]
    public class LocationCharacteristicValueLCH
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_136))]
        [Pos(1)]
        public virtual string LocationCharacteristicValueLCH01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Guarantor Race
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01291")]
    public class GuarantorRace
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_5))]
        [Pos(1)]
        public virtual string GuarantorRace01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Location Relationship ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01277")]
    public class LocationRelationshipID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_325))]
        [Pos(1)]
        public virtual string LocationRelationshipID01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Employment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01276")]
    public class EmploymentStatusCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_66))]
        [Pos(1)]
        public virtual string EmploymentStatusCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01228")]
    public class ReferralReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_336))]
        [Pos(1)]
        public virtual string ReferralReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Role-ROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01197")]
    public class RoleROL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_443))]
        [Pos(1)]
        public virtual string RoleROL01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Provider Role
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01155")]
    public class ProviderRole
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_286))]
        [Pos(1)]
        public virtual string ProviderRole01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Authorizing Payor Company
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01147")]
    public class AuthorizingPayorCompany
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AuthorizingPayorCompany01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Authorizing Payor Plan
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01146")]
    public class AuthorizingPayorPlan
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AuthorizingPayorPlan01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01141")]
    public class ReferralCategory
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_284))]
        [Pos(1)]
        public virtual string ReferralCategory01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Disposition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01140")]
    public class ReferralDisposition
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_282))]
        [Pos(1)]
        public virtual string ReferralDisposition01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01139")]
    public class ReferralType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_281))]
        [Pos(1)]
        public virtual string ReferralType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Priority
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01138")]
    public class ReferralPriority
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_280))]
        [Pos(1)]
        public virtual string ReferralPriority01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Referral Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01137")]
    public class ReferralStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_283))]
        [Pos(1)]
        public virtual string ReferralStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Substance Manufacturer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01131")]
    public class SubstanceManufacturerName
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_227))]
        [Pos(1)]
        public virtual string SubstanceManufacturerName01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Product Evaluation Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01112")]
    public class ProductEvaluationStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_247))]
        [Pos(1)]
        public virtual string ProductEvaluationStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Billing Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("01007")]
    public class BillingCategory
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string BillingCategory01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Facility ID-PRC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00995")]
    public class FacilityIDPRC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string FacilityIDPRC01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Inventory Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00990")]
    public class InventoryNumber
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string InventoryNumber01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Accommodation Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00980")]
    public class AccommodationType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AccommodationType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Specialty Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00966")]
    public class SpecialtyType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_265))]
        [Pos(1)]
        public virtual string SpecialtyType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Location Department
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00964")]
    public class LocationDepartment
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string LocationDepartment01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // License Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00951")]
    public class LicenseNumber
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string LicenseNumber01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Modality Of Imaging Measurement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00942")]
    public class ModalityOfImagingMeasurement
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_259))]
        [Pos(1)]
        public virtual string ModalityOfImagingMeasurement01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Relationship Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00940")]
    public class RelationshipModifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_258))]
        [Pos(1)]
        public virtual string RelationshipModifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Point Versus Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00938")]
    public class PointVersusInterval
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_255))]
        [Pos(1)]
        public virtual string PointVersusInterval01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Kind of Quantity Observed
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00937")]
    public class KindOfQuantityObserved
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_254))]
        [Pos(1)]
        public virtual string KindOfQuantityObserved01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Resource Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00907")]
    public class ResourceType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ResourceType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Location Type - AIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00904")]
    public class LocationTypeAIL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_305))]
        [Pos(1)]
        public virtual string LocationTypeAIL01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Filler Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00889")]
    public class FillerStatusCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_278))]
        [Pos(1)]
        public virtual string FillerStatusCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Appointment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00867")]
    public class AppointmentType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_277))]
        [Pos(1)]
        public virtual string AppointmentType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Appointment Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00866")]
    public class AppointmentReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_276))]
        [Pos(1)]
        public virtual string AppointmentReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Patient's Relationship to Insured
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00811")]
    public class PatientsRelationshipToInsured
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_344))]
        [Pos(1)]
        public virtual string PatientsRelationshipToInsured01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Military Handicapped Program
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00805")]
    public class MilitaryHandicappedProgram
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MilitaryHandicappedProgram01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Guarantor Marital Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00781")]
    public class GuarantorMaritalStatusCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_2))]
        [Pos(1)]
        public virtual string GuarantorMaritalStatusCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Guarantor Charge Adjustment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00777")]
    public class GuarantorChargeAdjustmentCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string GuarantorChargeAdjustmentCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Guarantor Credit Rating Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00774")]
    public class GuarantorCreditRatingCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string GuarantorCreditRatingCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Associated Diagnosis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00772")]
    public class AssociatedDiagnosisCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AssociatedDiagnosisCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Contact Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00747")]
    public class ContactReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ContactReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Publicity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00743")]
    public class PublicityCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_215))]
        [Pos(1)]
        public virtual string PublicityCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Nationality
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00739")]
    public class Nationality
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Nationality01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Practitioner Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00686")]
    public class PractitionerGroup
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PractitionerGroup01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Department
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00676")]
    public class Department
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string Department01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Staff Identifier List
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00672")]
    public class StaffIdentifierList
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CX_1", typeof(HL7_ID_61))]
        [Pos(1)]
        public virtual string StaffIdentifierList01 { get; set; }
        /// <summary>
        // Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("CX_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CheckDigit_02 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("CX_3", typeof(HL7_ID_61))]
        [Pos(3)]
        public virtual string CheckDigitScheme_03 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_04 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("CX_5", typeof(HL7_ID_203))]
        [Pos(5)]
        public virtual string IdentifierTypeCode_05 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningFacility AssigningFacility_06 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("CX_7", typeof(HL7_DT))]
        [Pos(7)]
        public virtual string EffectiveDate_07 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("CX_8", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string ExpirationDate_08 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_09 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_10 { get; set; }
    }
    
    /// <summary>
    // MFN Record Level Error Return
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00669")]
    public class MFNRecordLevelErrorReturn
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_181))]
        [Pos(1)]
        public virtual string MFNRecordLevelErrorReturn01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Master File Application Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00659")]
    public class MasterFileApplicationIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("HD_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MasterFileApplicationIdentifier01 { get; set; }
        /// <summary>
        // Universal ID
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("HD_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string UniversalID_02 { get; set; }
        /// <summary>
        // Universal ID Type
        /// </summary>
        [DataMember]
        [DataElement("HD_3", typeof(HL7_ID_301))]
        [Pos(3)]
        public virtual string UniversalIDType_03 { get; set; }
    }
    
    /// <summary>
    // Master File Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00658")]
    public class MasterFileIdentifier
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_175))]
        [Pos(1)]
        public virtual string MasterFileIdentifier01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Confidentiality Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00615")]
    public class ConfidentialityCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_177))]
        [Pos(1)]
        public virtual string ConfidentialityCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Occurrence Span (33)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00546")]
    public class OccurrenceSpan
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string OccurrenceSpan01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // PSRO/UR Approval Indicator (87)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00542")]
    public class PSROURApprovalIndicator
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PSROURApprovalIndicator01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Special Program Indicator (44)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00541")]
    public class SpecialProgramIndicator
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SpecialProgramIndicator01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Accident Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00528")]
    public class AccidentCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AccidentCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Certification Agency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00519")]
    public class CertificationAgency
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string CertificationAgency01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Appeal Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00518")]
    public class AppealReason
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AppealReason01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Non-Concur Code/Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00513")]
    public class NonConcurCodeDescription
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string NonConcurCodeDescription01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Dependent Of Military Recipient
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00482")]
    public class DependentOfMilitaryRecipient
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DependentOfMilitaryRecipient01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Consent Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00403")]
    public class ConsentCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ConsentCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Procedure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00393")]
    public class ProcedureCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ProcedureCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Outlier Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00385")]
    public class OutlierType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_83))]
        [Pos(1)]
        public virtual string OutlierType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Diagnostic Related Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00382")]
    public class DiagnosticRelatedGroup
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DiagnosticRelatedGroup01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Major Diagnostic Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00381")]
    public class MajorDiagnosticCategory
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("CNE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string MajorDiagnosticCategory01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CNE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CNE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CNE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CNE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Performed By Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00372")]
    public class PerformedByCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("XCN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string PerformedByCode01 { get; set; }
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FamilyName FamilyName_02 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_04 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("XCN_7", typeof(HL7_ID_360))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source Table
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("XCN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_09 { get; set; }
        /// <summary>
        // Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_10", typeof(HL7_ID_200))]
        [Pos(10)]
        public virtual string NameTypeCode_10 { get; set; }
        /// <summary>
        // Identifier Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("XCN_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string IdentifierCheckDigit_11 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("XCN_12", typeof(HL7_ID_61))]
        [Pos(12)]
        public virtual string CheckDigitScheme_12 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_13", typeof(HL7_ID_203))]
        [Pos(13)]
        public virtual string IdentifierTypeCode_13 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningFacility AssigningFacility_14 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_15", typeof(HL7_ID_465))]
        [Pos(15)]
        public virtual string NameRepresentationCode_15 { get; set; }
        /// <summary>
        // Name Context
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual NameContext NameContext_16 { get; set; }
        /// <summary>
        // Name Validity Range
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual NameValidityRange NameValidityRange_17 { get; set; }
        /// <summary>
        // Name Assembly Order
        /// </summary>
        [DataMember]
        [DataElement("XCN_18", typeof(HL7_ID_444))]
        [Pos(18)]
        public virtual string NameAssemblyOrder_18 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExpirationDate EffectiveDate_19 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExpirationDate ExpirationDate_20 { get; set; }
        /// <summary>
        // Professional Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XCN_21", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string ProfessionalSuffix_21 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_22 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_23 { get; set; }
    }
    
    /// <summary>
    // Department Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00367")]
    public class DepartmentCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DepartmentCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Administered Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00347")]
    public class AdministeredCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_292))]
        [Pos(1)]
        public virtual string AdministeredCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Administration Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00312")]
    public class AdministrationMethod
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_165))]
        [Pos(1)]
        public virtual string AdministrationMethod01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Administration Device
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00311")]
    public class AdministrationDevice
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_164))]
        [Pos(1)]
        public virtual string AdministrationDevice01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Administration Site
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00310")]
    public class AdministrationSite
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_550))]
        [Pos(1)]
        public virtual string AdministrationSite01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Route
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00309")]
    public class Route
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_162))]
        [Pos(1)]
        public virtual string Route01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Tray Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00273")]
    public class TrayType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_160))]
        [Pos(1)]
        public virtual string TrayType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Allergy Severity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00206")]
    public class AllergySeverityCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_128))]
        [Pos(1)]
        public virtual string AllergySeverityCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Allergen Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00204")]
    public class AllergenTypeCode
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_127))]
        [Pos(1)]
        public virtual string AllergenTypeCode01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Contact Role
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00196")]
    public class ContactRole
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_131))]
        [Pos(1)]
        public virtual string ContactRole01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Alternate Visit ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00180")]
    public class AlternateVisitID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("CX_1", typeof(HL7_ID_203))]
        [Pos(1)]
        public virtual string AlternateVisitID01 { get; set; }
        /// <summary>
        // Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("CX_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CheckDigit_02 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("CX_3", typeof(HL7_ID_61))]
        [Pos(3)]
        public virtual string CheckDigitScheme_03 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_04 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("CX_5", typeof(HL7_ID_203))]
        [Pos(5)]
        public virtual string IdentifierTypeCode_05 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningFacility AssigningFacility_06 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("CX_7", typeof(HL7_DT))]
        [Pos(7)]
        public virtual string EffectiveDate_07 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("CX_8", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string ExpirationDate_08 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_09 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_10 { get; set; }
    }
    
    /// <summary>
    // Diet Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00168")]
    public class DietType
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string DietType01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Veterans Military Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00130")]
    public class VeteransMilitaryStatus
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string VeteransMilitaryStatus01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Ethnic Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00125")]
    public class EthnicGroup
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_189))]
        [Pos(1)]
        public virtual string EthnicGroup01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Religion
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00120")]
    public class Religion
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_6))]
        [Pos(1)]
        public virtual string Religion01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Operator ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00103")]
    public class OperatorID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("XCN_1", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string OperatorID01 { get; set; }
        /// <summary>
        // Family Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FamilyName FamilyName_02 { get; set; }
        /// <summary>
        // Given Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_3", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // Second and Further Given Names or Initials Thereof
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("XCN_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SecondAndFurtherGivenNamesOrInitialsThereof_04 { get; set; }
        /// <summary>
        // Suffix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Suffix_05 { get; set; }
        /// <summary>
        // Prefix (e.g.
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("XCN_6", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Prefix_06 { get; set; }
        /// <summary>
        // Degree (e.g.
        /// </summary>
        [DataMember]
        [DataElement("XCN_7", typeof(HL7_ID_360))]
        [Pos(7)]
        public virtual string Degree_07 { get; set; }
        /// <summary>
        // Source Table
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("XCN_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SourceTable_08 { get; set; }
        /// <summary>
        // Assigning Authority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAssigningAuthority AssigningAuthority_09 { get; set; }
        /// <summary>
        // Name Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_10", typeof(HL7_ID_200))]
        [Pos(10)]
        public virtual string NameTypeCode_10 { get; set; }
        /// <summary>
        // Identifier Check Digit
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("XCN_11", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string IdentifierCheckDigit_11 { get; set; }
        /// <summary>
        // Check Digit Scheme
        /// </summary>
        [DataMember]
        [DataElement("XCN_12", typeof(HL7_ID_61))]
        [Pos(12)]
        public virtual string CheckDigitScheme_12 { get; set; }
        /// <summary>
        // Identifier Type Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_13", typeof(HL7_ID_203))]
        [Pos(13)]
        public virtual string IdentifierTypeCode_13 { get; set; }
        /// <summary>
        // Assigning Facility
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningFacility AssigningFacility_14 { get; set; }
        /// <summary>
        // Name Representation Code
        /// </summary>
        [DataMember]
        [DataElement("XCN_15", typeof(HL7_ID_465))]
        [Pos(15)]
        public virtual string NameRepresentationCode_15 { get; set; }
        /// <summary>
        // Name Context
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual NameContext NameContext_16 { get; set; }
        /// <summary>
        // Name Validity Range
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual NameValidityRange NameValidityRange_17 { get; set; }
        /// <summary>
        // Name Assembly Order
        /// </summary>
        [DataMember]
        [DataElement("XCN_18", typeof(HL7_ID_444))]
        [Pos(18)]
        public virtual string NameAssemblyOrder_18 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExpirationDate EffectiveDate_19 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExpirationDate ExpirationDate_20 { get; set; }
        /// <summary>
        // Professional Suffix
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("XCN_21", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string ProfessionalSuffix_21 { get; set; }
        /// <summary>
        // Assigning Jurisdiction
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual AssigningAgencyOrDepartment AssigningJurisdiction_22 { get; set; }
        /// <summary>
        // Assigning Agency or Department
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment AssigningAgencyOrDepartment_23 { get; set; }
    }
    
    /// <summary>
    // R/U What Subject Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00048")]
    public class RUWhatSubjectDefinition
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [DataElement("CWE_1", typeof(HL7_ID_48))]
        [Pos(1)]
        public virtual string RUWhatSubjectDefinition01 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_2", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string Text_02 { get; set; }
        /// <summary>
        // Name of Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_3", typeof(HL7_ID_396))]
        [Pos(3)]
        public virtual string NameOfCodingSystem_03 { get; set; }
        /// <summary>
        // Alternate Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("CWE_4", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string AlternateIdentifier_04 { get; set; }
        /// <summary>
        // Alternate Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_5", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string AlternateText_05 { get; set; }
        /// <summary>
        // Name of Alternate Coding System
        /// </summary>
        [DataMember]
        [DataElement("CWE_6", typeof(HL7_ID_396))]
        [Pos(6)]
        public virtual string NameOfAlternateCodingSystem_06 { get; set; }
        /// <summary>
        // Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_7", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CodingSystemVersionID_07 { get; set; }
        /// <summary>
        // Alternate Coding System Version ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("CWE_8", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AlternateCodingSystemVersionID_08 { get; set; }
        /// <summary>
        // Original Text
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("CWE_9", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string OriginalText_09 { get; set; }
    }
    
    /// <summary>
    // Quantity Limited Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("00031")]
    public class QuantityLimitedRequest
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("CQ_1", typeof(HL7_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        [DataMember]
        [DataElement("CQ_2", typeof(HL7_ID_126))]
        [Pos(2)]
        public virtual string QuantityLimitedRequest02 { get; set; }
    }
}
