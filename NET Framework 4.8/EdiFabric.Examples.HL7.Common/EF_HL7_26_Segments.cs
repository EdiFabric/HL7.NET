namespace EdiFabric.Templates.Hl726
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model;
    using EdiFabric.Core.Model.Hl7;
    
    
    /// <summary>
    // Abstract
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ABS")]
    public class ABS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Discharge Care Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DischargeCareProvider DischargeCareProvider_01 { get; set; }
        /// <summary>
        // Transfer Medical Service Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TransferMedicalServiceCode TransferMedicalServiceCode_02 { get; set; }
        /// <summary>
        // Severity of Illness Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SeverityOfIllnessCode SeverityOfIllnessCode_03 { get; set; }
        /// <summary>
        // Date/Time of Attestation
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01517", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string DateTimeOfAttestation_04 { get; set; }
        /// <summary>
        // Attested By
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDNumberAndName AttestedBy_05 { get; set; }
        /// <summary>
        // Triage Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual TriageCode TriageCode_06 { get; set; }
        /// <summary>
        // Abstract Completion Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01520", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string AbstractCompletionDateTime_07 { get; set; }
        /// <summary>
        // Abstracted By
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ExtendedCompositeIDNumberAndName AbstractedBy_08 { get; set; }
        /// <summary>
        // Case Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual CaseCategoryCode CaseCategoryCode_09 { get; set; }
        /// <summary>
        // Caesarian Section Indicator
        /// </summary>
        [DataMember]
        [DataElement("01523", typeof(HL7_ID_136))]
        [Pos(10)]
        public virtual string CaesarianSectionIndicator_10 { get; set; }
        /// <summary>
        // Gestation Category Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual GestationCategoryCode GestationCategoryCode_11 { get; set; }
        /// <summary>
        // Gestation Period - Weeks
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("01525", typeof(HL7_N))]
        [Pos(12)]
        public virtual string GestationPeriodWeeks_12 { get; set; }
        /// <summary>
        // Newborn Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual NewbornCode NewbornCode_13 { get; set; }
        /// <summary>
        // Stillborn Indicator
        /// </summary>
        [DataMember]
        [DataElement("01527", typeof(HL7_ID_136))]
        [Pos(14)]
        public virtual string StillbornIndicator_14 { get; set; }
    }
    
    /// <summary>
    // Accident
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ACC")]
    public class ACC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Accident Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00527", typeof(HL7_DTM))]
        [Pos(1)]
        public virtual string AccidentDateTime_01 { get; set; }
        /// <summary>
        // Accident Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AccidentCode AccidentCode_02 { get; set; }
        /// <summary>
        // Accident Location
        /// </summary>
        [DataMember]
        [StringLength(0, 25)]
        [DataElement("00529", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string AccidentLocation_03 { get; set; }
        /// <summary>
        // Auto Accident State
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual JurisdictionStateProvince AutoAccidentState_04 { get; set; }
        /// <summary>
        // Accident Job Related Indicator
        /// </summary>
        [DataMember]
        [DataElement("00813", typeof(HL7_ID_136))]
        [Pos(5)]
        public virtual string AccidentJobRelatedIndicator_05 { get; set; }
        /// <summary>
        // Accident Death Indicator
        /// </summary>
        [DataMember]
        [DataElement("00814", typeof(HL7_ID_136))]
        [Pos(6)]
        public virtual string AccidentDeathIndicator_06 { get; set; }
        /// <summary>
        // Entered By
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ExtendedCompositeIDNumberAndName EnteredBy_07 { get; set; }
        /// <summary>
        // Accident Description
        /// </summary>
        [DataMember]
        [StringLength(0, 25)]
        [DataElement("01503", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AccidentDescription_08 { get; set; }
        /// <summary>
        // Brought In By
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("01504", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string BroughtInBy_09 { get; set; }
        /// <summary>
        // Police Notified Indicator
        /// </summary>
        [DataMember]
        [DataElement("01505", typeof(HL7_ID_136))]
        [Pos(10)]
        public virtual string PoliceNotifiedIndicator_10 { get; set; }
        /// <summary>
        // Accident Address
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual ExtendedAddress AccidentAddress_11 { get; set; }
    }
    
    /// <summary>
    // Adjustment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADJ")]
    public class ADJ
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Provider Adjustment Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ProviderAdjustmentNumber_01 { get; set; }
        /// <summary>
        // Payer Adjustment Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PayerAdjustmentNumber_02 { get; set; }
        /// <summary>
        // Adjustment Sequence Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("02005", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string AdjustmentSequenceNumber_03 { get; set; }
        /// <summary>
        // Adjustment Category
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("02006", typeof(HL7_ID_564))]
        [Pos(4)]
        public virtual string AdjustmentCategory_04 { get; set; }
        /// <summary>
        // Adjustment Amount
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<CompositePrice> AdjustmentAmount_05 { get; set; }
        /// <summary>
        // Adjustment Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AdjustmentQuantity AdjustmentQuantity_06 { get; set; }
        /// <summary>
        // Adjustment Reason PA
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AdjustmentReasonPA AdjustmentReasonPA_07 { get; set; }
        /// <summary>
        // Adjustment Description
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("02010", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string AdjustmentDescription_08 { get; set; }
        /// <summary>
        // Original Value
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("02011", typeof(HL7_N))]
        [Pos(9)]
        public virtual string OriginalValue_09 { get; set; }
        /// <summary>
        // Substitute Value
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("02012", typeof(HL7_N))]
        [Pos(10)]
        public virtual string SubstituteValue_10 { get; set; }
        /// <summary>
        // Adjustment Action
        /// </summary>
        [DataMember]
        [DataElement("02013", typeof(HL7_ID_569))]
        [Pos(11)]
        public virtual string AdjustmentAction_11 { get; set; }
        /// <summary>
        // Provider Adjustment Number Cross Reference
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ComprehensiveLocationIdentifier ProviderAdjustmentNumberCrossReference_12 { get; set; }
        /// <summary>
        // Provider Product/Service Line Item Number Cross Reference
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ComprehensiveLocationIdentifier ProviderProductServiceLineItemNumberCrossReference_13 { get; set; }
        /// <summary>
        // Adjustment Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 26)]
        [DataElement("02016", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string AdjustmentDate_14 { get; set; }
        /// <summary>
        // Responsible Organization
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations ResponsibleOrganization_15 { get; set; }
    }
    
    /// <summary>
    // Professional Affiliation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AFF")]
    public class AFF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - AFF
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("01427", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDAFF_01 { get; set; }
        /// <summary>
        // Professional Organization
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations ProfessionalOrganization_02 { get; set; }
        /// <summary>
        // Professional Organization Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ExtendedAddress ProfessionalOrganizationAddress_03 { get; set; }
        /// <summary>
        // Professional Organization Affiliation Date Range
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<NameValidityRange> ProfessionalOrganizationAffiliationDateRange_04 { get; set; }
        /// <summary>
        // Professional Affiliation Additional Information
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01447", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string ProfessionalAffiliationAdditionalInformation_05 { get; set; }
    }
    
    /// <summary>
    // Appointment Information - General Resource
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AIG")]
    public class AIG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - AIG
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00896", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDAIG_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Resource ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment ResourceID_03 { get; set; }
        /// <summary>
        // Resource Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment ResourceType_04 { get; set; }
        /// <summary>
        // Resource Group
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AssigningAgencyOrDepartment> ResourceGroup_05 { get; set; }
        /// <summary>
        // Resource Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00900", typeof(HL7_N))]
        [Pos(6)]
        public virtual string ResourceQuantity_06 { get; set; }
        /// <summary>
        // Resource Quantity Units
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CodedWithNoExceptions ResourceQuantityUnits_07 { get; set; }
        /// <summary>
        // Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01202", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string StartDateTime_08 { get; set; }
        /// <summary>
        // Start Date/Time Offset
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00891", typeof(HL7_N))]
        [Pos(9)]
        public virtual string StartDateTimeOffset_09 { get; set; }
        /// <summary>
        // Start Date/Time Offset Units
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CodedWithNoExceptions StartDateTimeOffsetUnits_10 { get; set; }
        /// <summary>
        // Duration
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00893", typeof(HL7_N))]
        [Pos(11)]
        public virtual string Duration_11 { get; set; }
        /// <summary>
        // Duration Units
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual CodedWithNoExceptions DurationUnits_12 { get; set; }
        /// <summary>
        // Allow Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("00895", typeof(HL7_ID_279))]
        [Pos(13)]
        public virtual string AllowSubstitutionCode_13 { get; set; }
        /// <summary>
        // Filler Status Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual FillerStatusCode FillerStatusCode_14 { get; set; }
    }
    
    /// <summary>
    // Appointment Information - Location Resource
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AIL")]
    public class AIL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - AIL
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00902", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDAIL_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Location Resource ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PersonLocation> LocationResourceID_03 { get; set; }
        /// <summary>
        // Location Type - AIL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LocationTypeAIL LocationTypeAIL_04 { get; set; }
        /// <summary>
        // Location Group
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment LocationGroup_05 { get; set; }
        /// <summary>
        // Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01202", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string StartDateTime_06 { get; set; }
        /// <summary>
        // Start Date/Time Offset
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00891", typeof(HL7_N))]
        [Pos(7)]
        public virtual string StartDateTimeOffset_07 { get; set; }
        /// <summary>
        // Start Date/Time Offset Units
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual CodedWithNoExceptions StartDateTimeOffsetUnits_08 { get; set; }
        /// <summary>
        // Duration
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00893", typeof(HL7_N))]
        [Pos(9)]
        public virtual string Duration_09 { get; set; }
        /// <summary>
        // Duration Units
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CodedWithNoExceptions DurationUnits_10 { get; set; }
        /// <summary>
        // Allow Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("00895", typeof(HL7_ID_279))]
        [Pos(11)]
        public virtual string AllowSubstitutionCode_11 { get; set; }
        /// <summary>
        // Filler Status Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual FillerStatusCode FillerStatusCode_12 { get; set; }
    }
    
    /// <summary>
    // Appointment Information - Personnel Resource
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AIP")]
    public class AIP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - AIP
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00906", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDAIP_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Personnel Resource ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDNumberAndName> PersonnelResourceID_03 { get; set; }
        /// <summary>
        // Resource Type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ResourceType ResourceType_04 { get; set; }
        /// <summary>
        // Resource Group
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ResourceGroup_05 { get; set; }
        /// <summary>
        // Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01202", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string StartDateTime_06 { get; set; }
        /// <summary>
        // Start Date/Time Offset
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00891", typeof(HL7_N))]
        [Pos(7)]
        public virtual string StartDateTimeOffset_07 { get; set; }
        /// <summary>
        // Start Date/Time Offset Units
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual CodedWithNoExceptions StartDateTimeOffsetUnits_08 { get; set; }
        /// <summary>
        // Duration
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00893", typeof(HL7_N))]
        [Pos(9)]
        public virtual string Duration_09 { get; set; }
        /// <summary>
        // Duration Units
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CodedWithNoExceptions DurationUnits_10 { get; set; }
        /// <summary>
        // Allow Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("00895", typeof(HL7_ID_279))]
        [Pos(11)]
        public virtual string AllowSubstitutionCode_11 { get; set; }
        /// <summary>
        // Filler Status Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual FillerStatusCode FillerStatusCode_12 { get; set; }
    }
    
    /// <summary>
    // Appointment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AIS")]
    public class AIS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - AIS
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00890", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDAIS_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Universal Service Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment UniversalServiceIdentifier_03 { get; set; }
        /// <summary>
        // Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01202", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string StartDateTime_04 { get; set; }
        /// <summary>
        // Start Date/Time Offset
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00891", typeof(HL7_N))]
        [Pos(5)]
        public virtual string StartDateTimeOffset_05 { get; set; }
        /// <summary>
        // Start Date/Time Offset Units
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CodedWithNoExceptions StartDateTimeOffsetUnits_06 { get; set; }
        /// <summary>
        // Duration
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00893", typeof(HL7_N))]
        [Pos(7)]
        public virtual string Duration_07 { get; set; }
        /// <summary>
        // Duration Units
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual CodedWithNoExceptions DurationUnits_08 { get; set; }
        /// <summary>
        // Allow Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("00895", typeof(HL7_ID_279))]
        [Pos(9)]
        public virtual string AllowSubstitutionCode_09 { get; set; }
        /// <summary>
        // Filler Status Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual FillerStatusCode FillerStatusCode_10 { get; set; }
        /// <summary>
        // Placer Supplemental Service Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<FillerSupplementalServiceInformation> PlacerSupplementalServiceInformation_11 { get; set; }
        /// <summary>
        // Filler Supplemental Service Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<FillerSupplementalServiceInformation> FillerSupplementalServiceInformation_12 { get; set; }
    }
    
    /// <summary>
    // Patient Allergy Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AL1")]
    public class AL1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - AL1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00203", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDAL_01 { get; set; }
        /// <summary>
        // Allergen Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AllergenTypeCode AllergenTypeCode_02 { get; set; }
        /// <summary>
        // Allergen Code/Mnemonic/Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment AllergenCodeMnemonicDescription_03 { get; set; }
        /// <summary>
        // Allergy Severity Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AllergySeverityCode AllergySeverityCode_04 { get; set; }
        /// <summary>
        // Allergy Reaction Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 15)]
        [DataElement("00207", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> AllergyReactionCode_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Identification Date
        /// </summary>
        [DataMember]
        [DataElement("00208", typeof(HL7_DT))]
        [Pos(6)]
        public virtual string IdentificationDate_06 { get; set; }
    }
    
    /// <summary>
    // Appointment Preferences
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("APR")]
    public class APR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Time Selection Criteria
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<SchedulingClassValuePair> TimeSelectionCriteria_01 { get; set; }
        /// <summary>
        // Resource Selection Criteria
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<SchedulingClassValuePair> ResourceSelectionCriteria_02 { get; set; }
        /// <summary>
        // Location Selection Criteria
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<SchedulingClassValuePair> LocationSelectionCriteria_03 { get; set; }
        /// <summary>
        // Slot Spacing Criteria
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00911", typeof(HL7_N))]
        [Pos(4)]
        public virtual string SlotSpacingCriteria_04 { get; set; }
        /// <summary>
        // Filler Override Criteria
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<SchedulingClassValuePair> FillerOverrideCriteria_05 { get; set; }
    }
    
    /// <summary>
    // Appointment Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ARQ")]
    public class ARQ
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Placer Appointment ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier PlacerAppointmentID_01 { get; set; }
        /// <summary>
        // Filler Appointment ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier FillerAppointmentID_02 { get; set; }
        /// <summary>
        // Occurrence Number
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00862", typeof(HL7_N))]
        [Pos(3)]
        public virtual string OccurrenceNumber_03 { get; set; }
        /// <summary>
        // Placer Group Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier PlacerGroupNumber_04 { get; set; }
        /// <summary>
        // Schedule ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ScheduleID_05 { get; set; }
        /// <summary>
        // Request Event Reason
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment RequestEventReason_06 { get; set; }
        /// <summary>
        // Appointment Reason
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AppointmentReason AppointmentReason_07 { get; set; }
        /// <summary>
        // Appointment Type
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AppointmentType AppointmentType_08 { get; set; }
        /// <summary>
        // Appointment Duration
        /// </summary>
        [DataMember]
        [DataElement("00868", typeof(HL7_N))]
        [Pos(9)]
        public virtual string AppointmentDuration_09 { get; set; }
        /// <summary>
        // Appointment Duration Units
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CodedWithNoExceptions AppointmentDurationUnits_10 { get; set; }
        /// <summary>
        // Requested Start Date/Time Range
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<NameValidityRange> RequestedStartDateTimeRange_11 { get; set; }
        /// <summary>
        // Priority-ARQ
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00871", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string PriorityARQ_12 { get; set; }
        /// <summary>
        // Repeating Interval
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual Interval RepeatingInterval_13 { get; set; }
        /// <summary>
        // Repeating Interval Duration
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00873", typeof(HL7_AN))]
        [Pos(14)]
        public virtual string RepeatingIntervalDuration_14 { get; set; }
        /// <summary>
        // Placer Contact Person
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<ExtendedCompositeIDNumberAndName> PlacerContactPerson_15 { get; set; }
        /// <summary>
        // Placer Contact Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedTelecommunicationsNumber> PlacerContactPhoneNumber_16 { get; set; }
        /// <summary>
        // Placer Contact Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<ExtendedAddress> PlacerContactAddress_17 { get; set; }
        /// <summary>
        // Placer Contact Location
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual PersonLocation PlacerContactLocation_18 { get; set; }
        /// <summary>
        // Entered By Person
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ExtendedCompositeIDNumberAndName> EnteredByPerson_19 { get; set; }
        /// <summary>
        // Entered By Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<ExtendedTelecommunicationsNumber> EnteredByPhoneNumber_20 { get; set; }
        /// <summary>
        // Entered By Location
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual PersonLocation EnteredByLocation_21 { get; set; }
        /// <summary>
        // Parent Placer Appointment ID
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual ComprehensiveLocationIdentifier ParentPlacerAppointmentID_22 { get; set; }
        /// <summary>
        // Parent Filler Appointment ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual ComprehensiveLocationIdentifier ParentFillerAppointmentID_23 { get; set; }
        /// <summary>
        // Placer Order Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<ComprehensiveLocationIdentifier> PlacerOrderNumber_24 { get; set; }
        /// <summary>
        // Filler Order Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(25)]
        public virtual List<ComprehensiveLocationIdentifier> FillerOrderNumber_25 { get; set; }
    }
    
    /// <summary>
    // Access Restriction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ARV")]
    public class ARV
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("02143", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetID_01 { get; set; }
        /// <summary>
        // Access Restriction Action Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AccessRestrictionActionCode AccessRestrictionActionCode_02 { get; set; }
        /// <summary>
        // Access Restriction Value
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AccessRestrictionValue AccessRestrictionValue_03 { get; set; }
        /// <summary>
        // Access Restriction Reason
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<AccessRestrictionReason> AccessRestrictionReason_04 { get; set; }
        /// <summary>
        // Special Access Restriction Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 250)]
        [DataElement("02147", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> SpecialAccessRestrictionInstructions_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Access Restriction Date Range
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual NameValidityRange AccessRestrictionDateRange_06 { get; set; }
    }
    
    /// <summary>
    // Blood Product Transfusion/Disposition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BTX")]
    public class BTX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - BTX
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01735", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDBTX_01 { get; set; }
        /// <summary>
        // BC Donation ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier BCDonationID_02 { get; set; }
        /// <summary>
        // BC Component
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CodedWithNoExceptions BCComponent_03 { get; set; }
        /// <summary>
        // BC Blood Group
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CodedWithNoExceptions BCBloodGroup_04 { get; set; }
        /// <summary>
        // CP Commercial Product
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CPCommercialProduct CPCommercialProduct_05 { get; set; }
        /// <summary>
        // CP Manufacturer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations CPManufacturer_06 { get; set; }
        /// <summary>
        // CP Lot Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ComprehensiveLocationIdentifier CPLotNumber_07 { get; set; }
        /// <summary>
        // BP Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 5)]
        [DataElement("01742", typeof(HL7_N))]
        [Pos(8)]
        public virtual string BPQuantity_08 { get; set; }
        /// <summary>
        // BP Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01743", typeof(HL7_N))]
        [Pos(9)]
        public virtual string BPAmount_09 { get; set; }
        /// <summary>
        // BP Units
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment BPUnits_10 { get; set; }
        /// <summary>
        // BP Transfusion/Disposition Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual BPTransfusionDispositionStatus BPTransfusionDispositionStatus_11 { get; set; }
        /// <summary>
        // BP Message Status
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01746", typeof(HL7_ID_511))]
        [Pos(12)]
        public virtual string BPMessageStatus_12 { get; set; }
        /// <summary>
        // BP Date/Time of Status
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01747", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string BPDateTimeOfStatus_13 { get; set; }
        /// <summary>
        // BP Transfusion Administrator
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ExtendedCompositeIDNumberAndName BPTransfusionAdministrator_14 { get; set; }
        /// <summary>
        // BP Transfusion Verifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual ExtendedCompositeIDNumberAndName BPTransfusionVerifier_15 { get; set; }
        /// <summary>
        // BP Transfusion Start Date/Time of Status
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01750", typeof(HL7_DTM))]
        [Pos(16)]
        public virtual string BPTransfusionStartDateTimeOfStatus_16 { get; set; }
        /// <summary>
        // BP Transfusion End Date/Time of Status
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01751", typeof(HL7_DTM))]
        [Pos(17)]
        public virtual string BPTransfusionEndDateTimeOfStatus_17 { get; set; }
        /// <summary>
        // BP Adverse Reaction Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<BPAdverseReactionType> BPAdverseReactionType_18 { get; set; }
        /// <summary>
        // BP Transfusion Interrupted Reason
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual BPTransfusionInterruptedReason BPTransfusionInterruptedReason_19 { get; set; }
    }
    
    /// <summary>
    // Charge Description Master
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDM")]
    public class CDM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - CDM
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PrimaryKeyValueCDM PrimaryKeyValueCDM_01 { get; set; }
        /// <summary>
        // Charge Code Alias
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AssigningAgencyOrDepartment> ChargeCodeAlias_02 { get; set; }
        /// <summary>
        // Charge Description Short
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00984", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ChargeDescriptionShort_03 { get; set; }
        /// <summary>
        // Charge Description Long
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("00985", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string ChargeDescriptionLong_04 { get; set; }
        /// <summary>
        // Description Override Indicator
        /// </summary>
        [DataMember]
        [DataElement("00986", typeof(HL7_ID_268))]
        [Pos(5)]
        public virtual string DescriptionOverrideIndicator_05 { get; set; }
        /// <summary>
        // Exploding Charges
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PrimaryKeyValueCDM> ExplodingCharges_06 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ProcedureCode> ProcedureCode_07 { get; set; }
        /// <summary>
        // Active/Inactive Flag
        /// </summary>
        [DataMember]
        [DataElement("00675", typeof(HL7_ID_183))]
        [Pos(8)]
        public virtual string ActiveInactiveFlag_08 { get; set; }
        /// <summary>
        // Inventory Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<InventoryNumber> InventoryNumber_09 { get; set; }
        /// <summary>
        // Resource Load
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00991", typeof(HL7_N))]
        [Pos(10)]
        public virtual string ResourceLoad_10 { get; set; }
        /// <summary>
        // Contract Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> ContractNumber_11 { get; set; }
        /// <summary>
        // Contract Organization
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> ContractOrganization_12 { get; set; }
        /// <summary>
        // Room Fee Indicator
        /// </summary>
        [DataMember]
        [DataElement("00994", typeof(HL7_ID_136))]
        [Pos(13)]
        public virtual string RoomFeeIndicator_13 { get; set; }
    }
    
    /// <summary>
    // Certificate Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CER")]
    public class CER
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - CER
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01856", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDCER_01 { get; set; }
        /// <summary>
        // Serial Number
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("01857", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string SerialNumber_02 { get; set; }
        /// <summary>
        // Version
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("01858", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string Version_03 { get; set; }
        /// <summary>
        // Granting Authority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations GrantingAuthority_04 { get; set; }
        /// <summary>
        // Issuing Authority
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDNumberAndName IssuingAuthority_05 { get; set; }
        /// <summary>
        // Signature of Issuing Authority
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual EncapsulatedData SignatureOfIssuingAuthority_06 { get; set; }
        /// <summary>
        // Granting Country
        /// </summary>
        [DataMember]
        [DataElement("01862", typeof(HL7_ID_399))]
        [Pos(7)]
        public virtual string GrantingCountry_07 { get; set; }
        /// <summary>
        // Granting State/Province
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual JurisdictionStateProvince GrantingStateProvince_08 { get; set; }
        /// <summary>
        // Granting County/Parish
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual JurisdictionCountyParish GrantingCountyParish_09 { get; set; }
        /// <summary>
        // Certificate Type
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment CertificateType_10 { get; set; }
        /// <summary>
        // Certificate Domain
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AssigningAgencyOrDepartment CertificateDomain_11 { get; set; }
        /// <summary>
        // Subject ID
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01867", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string SubjectID_12 { get; set; }
        /// <summary>
        // Subject Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 250)]
        [DataElement("01907", typeof(HL7_AN))]
        [Pos(13)]
        public virtual string SubjectName_13 { get; set; }
        /// <summary>
        // Subject Directory Attribute Extension
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<AssigningAgencyOrDepartment> SubjectDirectoryAttributeExtension_14 { get; set; }
        /// <summary>
        // Subject Public Key Info
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual AssigningAgencyOrDepartment SubjectPublicKeyInfo_15 { get; set; }
        /// <summary>
        // Authority Key Identifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment AuthorityKeyIdentifier_16 { get; set; }
        /// <summary>
        // Basic Constraint
        /// </summary>
        [DataMember]
        [DataElement("01871", typeof(HL7_ID_136))]
        [Pos(17)]
        public virtual string BasicConstraint_17 { get; set; }
        /// <summary>
        // CRL Distribution Point
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<AssigningAgencyOrDepartment> CRLDistributionPoint_18 { get; set; }
        /// <summary>
        // Jurisdiction Country
        /// </summary>
        [DataMember]
        [DataElement("01875", typeof(HL7_ID_399))]
        [Pos(19)]
        public virtual string JurisdictionCountry_19 { get; set; }
        /// <summary>
        // Jurisdiction State/Province
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual JurisdictionStateProvince JurisdictionStateProvince_20 { get; set; }
        /// <summary>
        // Jurisdiction County/Parish
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual JurisdictionCountyParish JurisdictionCountyParish_21 { get; set; }
        /// <summary>
        // Jurisdiction Breadth
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<JurisdictionBreadth> JurisdictionBreadth_22 { get; set; }
        /// <summary>
        // Granting Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01876", typeof(HL7_DTM))]
        [Pos(23)]
        public virtual string GrantingDate_23 { get; set; }
        /// <summary>
        // Issuing Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01877", typeof(HL7_DTM))]
        [Pos(24)]
        public virtual string IssuingDate_24 { get; set; }
        /// <summary>
        // Activation Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01878", typeof(HL7_DTM))]
        [Pos(25)]
        public virtual string ActivationDate_25 { get; set; }
        /// <summary>
        // Inactivation Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01879", typeof(HL7_DTM))]
        [Pos(26)]
        public virtual string InactivationDate_26 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01880", typeof(HL7_DTM))]
        [Pos(27)]
        public virtual string ExpirationDate_27 { get; set; }
        /// <summary>
        // Renewal Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01881", typeof(HL7_DTM))]
        [Pos(28)]
        public virtual string RenewalDate_28 { get; set; }
        /// <summary>
        // Revocation Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01882", typeof(HL7_DTM))]
        [Pos(29)]
        public virtual string RevocationDate_29 { get; set; }
        /// <summary>
        // Revocation Reason Code
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual AssigningAgencyOrDepartment RevocationReasonCode_30 { get; set; }
        /// <summary>
        // Certificate Status Code
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual CertificateStatusCode CertificateStatusCode_31 { get; set; }
    }
    
    /// <summary>
    // Clinical Study Master
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CM0")]
    public class CM0
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - CM0
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01010", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDCM_01 { get; set; }
        /// <summary>
        // Sponsor Study ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier SponsorStudyID_02 { get; set; }
        /// <summary>
        // Alternate Study ID
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<ComprehensiveLocationIdentifier> AlternateStudyID_03 { get; set; }
        /// <summary>
        // Title of Study
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 300)]
        [DataElement("01013", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string TitleOfStudy_04 { get; set; }
        /// <summary>
        // Chairman of Study
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedCompositeIDNumberAndName> ChairmanOfStudy_05 { get; set; }
        /// <summary>
        // Last IRB Approval Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01015", typeof(HL7_DT))]
        [Pos(6)]
        public virtual string LastIRBApprovalDate_06 { get; set; }
        /// <summary>
        // Total Accrual to Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01016", typeof(HL7_N))]
        [Pos(7)]
        public virtual string TotalAccrualToDate_07 { get; set; }
        /// <summary>
        // Last Accrual Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01017", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string LastAccrualDate_08 { get; set; }
        /// <summary>
        // Contact for Study
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ExtendedCompositeIDNumberAndName> ContactForStudy_09 { get; set; }
        /// <summary>
        // Contact's Telephone Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ExtendedTelecommunicationsNumber ContactsTelephoneNumber_10 { get; set; }
        /// <summary>
        // Contact's Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedAddress> ContactsAddress_11 { get; set; }
    }
    
    /// <summary>
    // Clinical Study Phase Master
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CM1")]
    public class CM1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - CM1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01021", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDCM_01 { get; set; }
        /// <summary>
        // Study Phase Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment StudyPhaseIdentifier_02 { get; set; }
        /// <summary>
        // Description of Study Phase
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 3)]
        [DataElement("01023", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string DescriptionOfStudyPhase_03 { get; set; }
    }
    
    /// <summary>
    // Clinical Study Schedule Master
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CM2")]
    public class CM2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID- CM2
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01024", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDCM_01 { get; set; }
        /// <summary>
        // Scheduled Time Point
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment ScheduledTimePoint_02 { get; set; }
        /// <summary>
        // Description of Time Point
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("01026", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string DescriptionOfTimePoint_03 { get; set; }
        /// <summary>
        // Events Scheduled This Time Point
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(200)]
        [Pos(4)]
        public virtual List<AssigningAgencyOrDepartment> EventsScheduledThisTimePoint_04 { get; set; }
    }
    
    /// <summary>
    // Authorization Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AUT")]
    public class AUT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Authorizing Payor Plan
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AuthorizingPayorPlan AuthorizingPayorPlan_01 { get; set; }
        /// <summary>
        // Authorizing Payor Company
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AuthorizingPayorCompany AuthorizingPayorCompany_02 { get; set; }
        /// <summary>
        // Authorizing Payor
        /// </summary>
        [DataMember]
        [StringLength(0, 45)]
        [DataElement("01148", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string AuthorizingPayor_03 { get; set; }
        /// <summary>
        // Authorization Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01149", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string AuthorizationEffectiveDate_04 { get; set; }
        /// <summary>
        // Authorization Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01150", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string AuthorizationExpirationDate_05 { get; set; }
        /// <summary>
        // Authorization Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ComprehensiveLocationIdentifier AuthorizationIdentifier_06 { get; set; }
        /// <summary>
        // Reimbursement Limit
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CompositePrice ReimbursementLimit_07 { get; set; }
        /// <summary>
        // Requested Number of Treatments
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("01153", typeof(HL7_N))]
        [Pos(8)]
        public virtual string RequestedNumberOfTreatments_08 { get; set; }
        /// <summary>
        // Authorized Number of Treatments
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("01154", typeof(HL7_N))]
        [Pos(9)]
        public virtual string AuthorizedNumberOfTreatments_09 { get; set; }
        /// <summary>
        // Process Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01145", typeof(HL7_DTM))]
        [Pos(10)]
        public virtual string ProcessDate_10 { get; set; }
    }
    
    /// <summary>
    // Blood Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BLC")]
    public class BLC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Blood Product Code
        /// </summary>
        [DataMember]
        [DataElement("01528", typeof(HL7_ID_426))]
        [Pos(1)]
        public virtual string BloodProductCode_01 { get; set; }
        /// <summary>
        // Blood Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Quantity BloodAmount_02 { get; set; }
    }
    
    /// <summary>
    // Billing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BLG")]
    public class BLG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // When to Charge
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ChargeCodeAndDate WhenToCharge_01 { get; set; }
        /// <summary>
        // Charge Type
        /// </summary>
        [DataMember]
        [DataElement("00235", typeof(HL7_ID_122))]
        [Pos(2)]
        public virtual string ChargeType_02 { get; set; }
        /// <summary>
        // Account ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ExtendedCompositeIDWithCheckDigit AccountID_03 { get; set; }
        /// <summary>
        // Charge Type Reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ChargeTypeReason ChargeTypeReason_04 { get; set; }
    }
    
    /// <summary>
    // Blood product order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPO")]
    public class BPO
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - BPO
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01700", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDBPO_01 { get; set; }
        /// <summary>
        // BP Universal Service Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment BPUniversalServiceIdentifier_02 { get; set; }
        /// <summary>
        // BP Processing Requirements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<BPProcessingRequirements> BPProcessingRequirements_03 { get; set; }
        /// <summary>
        // BP Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 5)]
        [DataElement("01703", typeof(HL7_N))]
        [Pos(4)]
        public virtual string BPQuantity_04 { get; set; }
        /// <summary>
        // BP Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01704", typeof(HL7_N))]
        [Pos(5)]
        public virtual string BPAmount_05 { get; set; }
        /// <summary>
        // BP Units
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment BPUnits_06 { get; set; }
        /// <summary>
        // BP Intended Use Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01706", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string BPIntendedUseDateTime_07 { get; set; }
        /// <summary>
        // BP Intended Dispense From Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PersonLocation BPIntendedDispenseFromLocation_08 { get; set; }
        /// <summary>
        // BP Intended Dispense From Address
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAddress BPIntendedDispenseFromAddress_09 { get; set; }
        /// <summary>
        // BP Requested Dispense Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01709", typeof(HL7_DTM))]
        [Pos(10)]
        public virtual string BPRequestedDispenseDateTime_10 { get; set; }
        /// <summary>
        // BP Requested Dispense To Location
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual PersonLocation BPRequestedDispenseToLocation_11 { get; set; }
        /// <summary>
        // BP Requested Dispense To Address
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ExtendedAddress BPRequestedDispenseToAddress_12 { get; set; }
        /// <summary>
        // BP Indication for Use
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<BPIndicationForUse> BPIndicationForUse_13 { get; set; }
        /// <summary>
        // BP Informed Consent Indicator
        /// </summary>
        [DataMember]
        [DataElement("01713", typeof(HL7_ID_136))]
        [Pos(14)]
        public virtual string BPInformedConsentIndicator_14 { get; set; }
    }
    
    /// <summary>
    // Blood product dispense status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPX")]
    public class BPX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - BPX
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01714", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDBPX_01 { get; set; }
        /// <summary>
        // BP Dispense Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPDispenseStatus BPDispenseStatus_02 { get; set; }
        /// <summary>
        // BP Status
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01716", typeof(HL7_ID_511))]
        [Pos(3)]
        public virtual string BPStatus_03 { get; set; }
        /// <summary>
        // BP Date/Time of Status
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01717", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string BPDateTimeOfStatus_04 { get; set; }
        /// <summary>
        // BC Donation ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier BCDonationID_05 { get; set; }
        /// <summary>
        // BC Component
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CodedWithNoExceptions BCComponent_06 { get; set; }
        /// <summary>
        // BC Donation Type / Intended Use
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CodedWithNoExceptions BCDonationTypeIntendedUse_07 { get; set; }
        /// <summary>
        // CP Commercial Product
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual CPCommercialProduct CPCommercialProduct_08 { get; set; }
        /// <summary>
        // CP Manufacturer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations CPManufacturer_09 { get; set; }
        /// <summary>
        // CP Lot Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ComprehensiveLocationIdentifier CPLotNumber_10 { get; set; }
        /// <summary>
        // BP Blood Group
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CodedWithNoExceptions BPBloodGroup_11 { get; set; }
        /// <summary>
        // BC Special Testing
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<CodedWithNoExceptions> BCSpecialTesting_12 { get; set; }
        /// <summary>
        // BP Expiration Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01726", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string BPExpirationDateTime_13 { get; set; }
        /// <summary>
        // BP Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 5)]
        [DataElement("01727", typeof(HL7_N))]
        [Pos(14)]
        public virtual string BPQuantity_14 { get; set; }
        /// <summary>
        // BP Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01728", typeof(HL7_N))]
        [Pos(15)]
        public virtual string BPAmount_15 { get; set; }
        /// <summary>
        // BP Units
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment BPUnits_16 { get; set; }
        /// <summary>
        // BP Unique ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual ComprehensiveLocationIdentifier BPUniqueID_17 { get; set; }
        /// <summary>
        // BP Actual Dispensed To Location
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual PersonLocation BPActualDispensedToLocation_18 { get; set; }
        /// <summary>
        // BP Actual Dispensed To Address
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExtendedAddress BPActualDispensedToAddress_19 { get; set; }
        /// <summary>
        // BP Dispensed to Receiver
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExtendedCompositeIDNumberAndName BPDispensedToReceiver_20 { get; set; }
        /// <summary>
        // BP Dispensing Individual
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual ExtendedCompositeIDNumberAndName BPDispensingIndividual_21 { get; set; }
    }
    
    /// <summary>
    // Clear Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNS")]
    public class CNS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Starting Notification Reference Number
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01402", typeof(HL7_N))]
        [Pos(1)]
        public virtual string StartingNotificationReferenceNumber_01 { get; set; }
        /// <summary>
        // Ending Notification Reference Number
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01403", typeof(HL7_N))]
        [Pos(2)]
        public virtual string EndingNotificationReferenceNumber_02 { get; set; }
        /// <summary>
        // Starting Notification Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01404", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string StartingNotificationDateTime_03 { get; set; }
        /// <summary>
        // Ending Notification Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01405", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string EndingNotificationDateTime_04 { get; set; }
        /// <summary>
        // Starting Notification Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment StartingNotificationCode_05 { get; set; }
        /// <summary>
        // Ending Notification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment EndingNotificationCode_06 { get; set; }
    }
    
    /// <summary>
    // Consent Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CON")]
    public class CON
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - CON
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01776", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDCON_01 { get; set; }
        /// <summary>
        // Consent Type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ConsentType ConsentType_02 { get; set; }
        /// <summary>
        // Consent Form ID and Version
        /// </summary>
        [DataMember]
        [StringLength(0, 40)]
        [DataElement("01778", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ConsentFormIDAndVersion_03 { get; set; }
        /// <summary>
        // Consent Form Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier ConsentFormNumber_04 { get; set; }
        /// <summary>
        // Consent Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01780", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> ConsentText_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Subject-specific Consent Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01781", typeof(HL7_AN))]
        [Pos(6)]
        public virtual List<string> SubjectspecificConsentText_06 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Consent Background Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01782", typeof(HL7_AN))]
        [Pos(7)]
        public virtual List<string> ConsentBackgroundInformation_07 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Subject-specific Consent Background Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01783", typeof(HL7_AN))]
        [Pos(8)]
        public virtual List<string> SubjectspecificConsentBackgroundText_08 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Consenter-imposed limitations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01784", typeof(HL7_AN))]
        [Pos(9)]
        public virtual List<string> ConsenterimposedLimitations_09 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Consent Mode
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ConsentMode ConsentMode_10 { get; set; }
        /// <summary>
        // Consent Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual ConsentStatus ConsentStatus_11 { get; set; }
        /// <summary>
        // Consent Discussion Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01787", typeof(HL7_DTM))]
        [Pos(12)]
        public virtual string ConsentDiscussionDateTime_12 { get; set; }
        /// <summary>
        // Consent Decision Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01788", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string ConsentDecisionDateTime_13 { get; set; }
        /// <summary>
        // Consent Effective Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01789", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string ConsentEffectiveDateTime_14 { get; set; }
        /// <summary>
        // Consent End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01790", typeof(HL7_DTM))]
        [Pos(15)]
        public virtual string ConsentEndDateTime_15 { get; set; }
        /// <summary>
        // Subject Competence Indicator
        /// </summary>
        [DataMember]
        [DataElement("01791", typeof(HL7_ID_136))]
        [Pos(16)]
        public virtual string SubjectCompetenceIndicator_16 { get; set; }
        /// <summary>
        // Translator Assistance Indicator
        /// </summary>
        [DataMember]
        [DataElement("01792", typeof(HL7_ID_136))]
        [Pos(17)]
        public virtual string TranslatorAssistanceIndicator_17 { get; set; }
        /// <summary>
        // Language Translated To
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual LanguageTranslatedTo LanguageTranslatedTo_18 { get; set; }
        /// <summary>
        // Informational Material Supplied Indicator
        /// </summary>
        [DataMember]
        [DataElement("01794", typeof(HL7_ID_136))]
        [Pos(19)]
        public virtual string InformationalMaterialSuppliedIndicator_19 { get; set; }
        /// <summary>
        // Consent Bypass Reason
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ConsentBypassReason ConsentBypassReason_20 { get; set; }
        /// <summary>
        // Consent Disclosure Level
        /// </summary>
        [DataMember]
        [DataElement("01796", typeof(HL7_ID_500))]
        [Pos(21)]
        public virtual string ConsentDisclosureLevel_21 { get; set; }
        /// <summary>
        // Consent Non-disclosure Reason
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual ConsentNondisclosureReason ConsentNondisclosureReason_22 { get; set; }
        /// <summary>
        // Non-subject Consenter Reason
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual NonsubjectConsenterReason NonsubjectConsenterReason_23 { get; set; }
        /// <summary>
        // Consenter ID
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<ExtendedPersonName> ConsenterID_24 { get; set; }
        /// <summary>
        // Relationship to Subject
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [DataElement("01898", typeof(HL7_ID_548))]
        [Pos(25)]
        public virtual List<string> RelationshipToSubject_25 
        {
            get { return _stringList6; }
            set { _stringList6 = value; }
        }

        private List<string> _stringList6 { get; set; }
        public virtual string StringList6
        {
            get
            {
                if (_stringList6 != null)
                    return string.Join("^", _stringList6);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList6 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Clinical Study Phase
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CSP")]
    public class CSP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Study Phase Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment StudyPhaseIdentifier_01 { get; set; }
        /// <summary>
        // Date/time Study Phase Began
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01052", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string DatetimeStudyPhaseBegan_02 { get; set; }
        /// <summary>
        // Date/time Study Phase Ended
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01053", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string DatetimeStudyPhaseEnded_03 { get; set; }
        /// <summary>
        // Study Phase Evaluability
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment StudyPhaseEvaluability_04 { get; set; }
    }
    
    /// <summary>
    // Clinical Study Registration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CSR")]
    public class CSR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sponsor Study ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier SponsorStudyID_01 { get; set; }
        /// <summary>
        // Alternate Study ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier AlternateStudyID_02 { get; set; }
        /// <summary>
        // Institution Registering the Patient
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment InstitutionRegisteringThePatient_03 { get; set; }
        /// <summary>
        // Sponsor Patient ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual ExtendedCompositeIDWithCheckDigit SponsorPatientID_04 { get; set; }
        /// <summary>
        // Alternate Patient ID - CSR
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDWithCheckDigit AlternatePatientIDCSR_05 { get; set; }
        /// <summary>
        // Date/Time of Patient Study Registration
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01040", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string DateTimeOfPatientStudyRegistration_06 { get; set; }
        /// <summary>
        // Person Performing Study Registration
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedCompositeIDNumberAndName> PersonPerformingStudyRegistration_07 { get; set; }
        /// <summary>
        // Study Authorizing Provider
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<ExtendedCompositeIDNumberAndName> StudyAuthorizingProvider_08 { get; set; }
        /// <summary>
        // Date/time Patient Study Consent Signed
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01043", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual string DatetimePatientStudyConsentSigned_09 { get; set; }
        /// <summary>
        // Patient Study Eligibility Status
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment PatientStudyEligibilityStatus_10 { get; set; }
        /// <summary>
        // Study Randomization Date/time
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [StringLength(0, 24)]
        [DataElement("01045", typeof(HL7_DTM))]
        [Pos(11)]
        public virtual List<string> StudyRandomizationDatetime_11 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Randomized Study Arm
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(12)]
        public virtual List<AssigningAgencyOrDepartment> RandomizedStudyArm_12 { get; set; }
        /// <summary>
        // Stratum for Study Randomization
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(13)]
        public virtual List<AssigningAgencyOrDepartment> StratumForStudyRandomization_13 { get; set; }
        /// <summary>
        // Patient Evaluability Status
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningAgencyOrDepartment PatientEvaluabilityStatus_14 { get; set; }
        /// <summary>
        // Date/time Ended Study
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01049", typeof(HL7_DTM))]
        [Pos(15)]
        public virtual string DatetimeEndedStudy_15 { get; set; }
        /// <summary>
        // Reason Ended Study
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment ReasonEndedStudy_16 { get; set; }
    }
    
    /// <summary>
    // Clinical Study Data Schedule Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CSS")]
    public class CSS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Study Scheduled Time Point
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment StudyScheduledTimePoint_01 { get; set; }
        /// <summary>
        // Study Scheduled Patient Time Point
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01056", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string StudyScheduledPatientTimePoint_02 { get; set; }
        /// <summary>
        // Study Quality Control Codes
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<AssigningAgencyOrDepartment> StudyQualityControlCodes_03 { get; set; }
    }
    
    /// <summary>
    // Contact Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTD")]
    public class CTD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Contact Role
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<ContactRole> ContactRole_01 { get; set; }
        /// <summary>
        // Contact Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ExtendedPersonName> ContactName_02 { get; set; }
        /// <summary>
        // Contact Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedAddress> ContactAddress_03 { get; set; }
        /// <summary>
        // Contact Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PersonLocation ContactLocation_04 { get; set; }
        /// <summary>
        // Contact Communication Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedTelecommunicationsNumber> ContactCommunicationInformation_05 { get; set; }
        /// <summary>
        // Preferred Method of Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ProviderOrganizationMethodOfContact PreferredMethodOfContact_06 { get; set; }
        /// <summary>
        // Contact Identifiers
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<PractitionerLicenseOrOtherIDNumber> ContactIdentifiers_07 { get; set; }
    }
    
    /// <summary>
    // Clinical Trial Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTI")]
    public class CTI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sponsor Study ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier SponsorStudyID_01 { get; set; }
        /// <summary>
        // Study Phase Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment StudyPhaseIdentifier_02 { get; set; }
        /// <summary>
        // Study Scheduled Time Point
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment StudyScheduledTimePoint_03 { get; set; }
    }
    
    /// <summary>
    // Disability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DB1")]
    public class DB1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - DB1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01283", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDDB_01 { get; set; }
        /// <summary>
        // Disabled Person Code
        /// </summary>
        [DataMember]
        [DataElement("01284", typeof(HL7_ID_334))]
        [Pos(2)]
        public virtual string DisabledPersonCode_02 { get; set; }
        /// <summary>
        // Disabled Person Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> DisabledPersonIdentifier_03 { get; set; }
        /// <summary>
        // Disability Indicator
        /// </summary>
        [DataMember]
        [DataElement("01286", typeof(HL7_ID_136))]
        [Pos(4)]
        public virtual string DisabilityIndicator_04 { get; set; }
        /// <summary>
        // Disability Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01287", typeof(HL7_DT))]
        [Pos(5)]
        public virtual string DisabilityStartDate_05 { get; set; }
        /// <summary>
        // Disability End Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01288", typeof(HL7_DT))]
        [Pos(6)]
        public virtual string DisabilityEndDate_06 { get; set; }
        /// <summary>
        // Disability Return to Work Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01289", typeof(HL7_DT))]
        [Pos(7)]
        public virtual string DisabilityReturnToWorkDate_07 { get; set; }
        /// <summary>
        // Disability Unable to Work Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01290", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string DisabilityUnableToWorkDate_08 { get; set; }
    }
    
    /// <summary>
    // Diagnosis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DG1")]
    public class DG1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - DG1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00375", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDDG_01 { get; set; }
        [DataMember]
        [DataElement("00376", typeof(ANY))]
        [Pos(2)]
        public virtual string DG102 { get; set; }
        /// <summary>
        // Diagnosis Code - DG1
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssociatedDiagnosisCode DiagnosisCodeDG_03 { get; set; }
        [DataMember]
        [DataElement("00378", typeof(ANY))]
        [Pos(4)]
        public virtual string DG104 { get; set; }
        /// <summary>
        // Diagnosis Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00379", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string DiagnosisDateTime_05 { get; set; }
        /// <summary>
        // Diagnosis Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00380", typeof(HL7_ID_52))]
        [Pos(6)]
        public virtual string DiagnosisType_06 { get; set; }
        /// <summary>
        // Major Diagnostic Category
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MajorDiagnosticCategory MajorDiagnosticCategory_07 { get; set; }
        /// <summary>
        // Diagnostic Related Group
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DiagnosticRelatedGroup DiagnosticRelatedGroup_08 { get; set; }
        /// <summary>
        // DRG Approval Indicator
        /// </summary>
        [DataMember]
        [DataElement("00383", typeof(HL7_ID_136))]
        [Pos(9)]
        public virtual string DRGApprovalIndicator_09 { get; set; }
        /// <summary>
        // DRG Grouper Review Code
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00384", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string DRGGrouperReviewCode_10 { get; set; }
        /// <summary>
        // Outlier Type
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual OutlierType OutlierType_11 { get; set; }
        /// <summary>
        // Outlier Days
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00386", typeof(HL7_N))]
        [Pos(12)]
        public virtual string OutlierDays_12 { get; set; }
        /// <summary>
        // Outlier Cost
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CompositePrice OutlierCost_13 { get; set; }
        [DataMember]
        [DataElement("00388", typeof(ANY))]
        [Pos(14)]
        public virtual string DG114 { get; set; }
        /// <summary>
        // Diagnosis Priority
        /// </summary>
        [DataMember]
        [DataElement("00389", typeof(HL7_ID_359))]
        [Pos(15)]
        public virtual string DiagnosisPriority_15 { get; set; }
        /// <summary>
        // Diagnosing Clinician
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedCompositeIDNumberAndName> DiagnosingClinician_16 { get; set; }
        /// <summary>
        // Diagnosis Classification
        /// </summary>
        [DataMember]
        [DataElement("00766", typeof(HL7_ID_228))]
        [Pos(17)]
        public virtual string DiagnosisClassification_17 { get; set; }
        /// <summary>
        // Confidential Indicator
        /// </summary>
        [DataMember]
        [DataElement("00767", typeof(HL7_ID_136))]
        [Pos(18)]
        public virtual string ConfidentialIndicator_18 { get; set; }
        /// <summary>
        // Attestation Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00768", typeof(HL7_DTM))]
        [Pos(19)]
        public virtual string AttestationDateTime_19 { get; set; }
        /// <summary>
        // Diagnosis Identifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ComprehensiveLocationIdentifier DiagnosisIdentifier_20 { get; set; }
        /// <summary>
        // Diagnosis Action Code
        /// </summary>
        [DataMember]
        [DataElement("01894", typeof(HL7_ID_206))]
        [Pos(21)]
        public virtual string DiagnosisActionCode_21 { get; set; }
        /// <summary>
        // Parent Diagnosis
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual ComprehensiveLocationIdentifier ParentDiagnosis_22 { get; set; }
        /// <summary>
        // DRG CCL Value Code
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual PCCLValueCode DRGCCLValueCode_23 { get; set; }
        /// <summary>
        // DRG Grouping Usage
        /// </summary>
        [DataMember]
        [DataElement("02154", typeof(HL7_ID_136))]
        [Pos(24)]
        public virtual string DRGGroupingUsage_24 { get; set; }
        /// <summary>
        // DRG Diagnosis Determination Status
        /// </summary>
        [DataMember]
        [DataElement("02155", typeof(HL7_ID_731))]
        [Pos(25)]
        public virtual string DRGDiagnosisDeterminationStatus_25 { get; set; }
        /// <summary>
        // Present On Admission (POA) Indicator
        /// </summary>
        [DataMember]
        [DataElement("02288", typeof(HL7_ID_895))]
        [Pos(26)]
        public virtual string PresentOnAdmission_26 { get; set; }
    }
    
    /// <summary>
    // DRG Master File Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMI")]
    public class DMI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Diagnostic Related Group
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DiagnosticRelatedGroup DiagnosticRelatedGroup_01 { get; set; }
        /// <summary>
        // Major Diagnostic Category
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MajorDiagnosticCategory MajorDiagnosticCategory_02 { get; set; }
        /// <summary>
        // Lower and Upper Trim Points
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual GestationalAgeRange LowerAndUpperTrimPoints_03 { get; set; }
        /// <summary>
        // Average Length of Stay
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("02232", typeof(HL7_N))]
        [Pos(4)]
        public virtual string AverageLengthOfStay_04 { get; set; }
        /// <summary>
        // Relative Weight
        /// </summary>
        [DataMember]
        [StringLength(0, 7)]
        [DataElement("02233", typeof(HL7_N))]
        [Pos(5)]
        public virtual string RelativeWeight_05 { get; set; }
    }
    
    /// <summary>
    // Diagnosis Related Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DRG")]
    public class DRG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Diagnostic Related Group
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DiagnosticRelatedGroup DiagnosticRelatedGroup_01 { get; set; }
        /// <summary>
        // DRG Assigned Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00769", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string DRGAssignedDateTime_02 { get; set; }
        /// <summary>
        // DRG Approval Indicator
        /// </summary>
        [DataMember]
        [DataElement("00383", typeof(HL7_ID_136))]
        [Pos(3)]
        public virtual string DRGApprovalIndicator_03 { get; set; }
        /// <summary>
        // DRG Grouper Review Code
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00384", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string DRGGrouperReviewCode_04 { get; set; }
        /// <summary>
        // Outlier Type
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual OutlierType OutlierType_05 { get; set; }
        /// <summary>
        // Outlier Days
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00386", typeof(HL7_N))]
        [Pos(6)]
        public virtual string OutlierDays_06 { get; set; }
        /// <summary>
        // Outlier Cost
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CompositePrice OutlierCost_07 { get; set; }
        /// <summary>
        // DRG Payor
        /// </summary>
        [DataMember]
        [DataElement("00770", typeof(HL7_ID_229))]
        [Pos(8)]
        public virtual string DRGPayor_08 { get; set; }
        /// <summary>
        // Outlier Reimbursement
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual CompositePrice OutlierReimbursement_09 { get; set; }
        /// <summary>
        // Confidential Indicator
        /// </summary>
        [DataMember]
        [DataElement("00767", typeof(HL7_ID_136))]
        [Pos(10)]
        public virtual string ConfidentialIndicator_10 { get; set; }
        /// <summary>
        // DRG Transfer Type
        /// </summary>
        [DataMember]
        [DataElement("01500", typeof(HL7_ID_415))]
        [Pos(11)]
        public virtual string DRGTransferType_11 { get; set; }
        /// <summary>
        // Name of Coder
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ExtendedPersonName NameOfCoder_12 { get; set; }
        /// <summary>
        // Grouper Status
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual GrouperStatus GrouperStatus_13 { get; set; }
        /// <summary>
        // PCCL Value Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual PCCLValueCode PCCLValueCode_14 { get; set; }
        /// <summary>
        // Effective Weight
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("02159", typeof(HL7_N))]
        [Pos(15)]
        public virtual string EffectiveWeight_15 { get; set; }
        /// <summary>
        // Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual ValueAmount MonetaryAmount_16 { get; set; }
        /// <summary>
        // Status Patient
        /// </summary>
        [DataMember]
        [DataElement("02161", typeof(HL7_ID_739))]
        [Pos(17)]
        public virtual string StatusPatient_17 { get; set; }
        /// <summary>
        // Grouper Software Name
        /// </summary>
        [DataMember]
        [StringLength(0, 100)]
        [DataElement("02162", typeof(HL7_AN))]
        [Pos(18)]
        public virtual string GrouperSoftwareName_18 { get; set; }
        /// <summary>
        // Grouper Software Version
        /// </summary>
        [DataMember]
        [StringLength(0, 100)]
        [DataElement("02282", typeof(HL7_AN))]
        [Pos(19)]
        public virtual string GrouperSoftwareVersion_19 { get; set; }
        /// <summary>
        // Status Financial Calculation
        /// </summary>
        [DataMember]
        [DataElement("02163", typeof(HL7_ID_742))]
        [Pos(20)]
        public virtual string StatusFinancialCalculation_20 { get; set; }
        /// <summary>
        // Relative Discount/Surcharge
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual ValueAmount RelativeDiscountSurcharge_21 { get; set; }
        /// <summary>
        // Basic Charge
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual ValueAmount BasicCharge_22 { get; set; }
        /// <summary>
        // Total Charge
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual ValueAmount TotalCharge_23 { get; set; }
        /// <summary>
        // Discount/Surcharge
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual ValueAmount DiscountSurcharge_24 { get; set; }
        /// <summary>
        // Calculated Days
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("02168", typeof(HL7_N))]
        [Pos(25)]
        public virtual string CalculatedDays_25 { get; set; }
        /// <summary>
        // Status Gender
        /// </summary>
        [DataMember]
        [DataElement("02169", typeof(HL7_ID_749))]
        [Pos(26)]
        public virtual string StatusGender_26 { get; set; }
        /// <summary>
        // Status Age
        /// </summary>
        [DataMember]
        [DataElement("02170", typeof(HL7_ID_749))]
        [Pos(27)]
        public virtual string StatusAge_27 { get; set; }
        /// <summary>
        // Status Length of Stay
        /// </summary>
        [DataMember]
        [DataElement("02171", typeof(HL7_ID_749))]
        [Pos(28)]
        public virtual string StatusLengthOfStay_28 { get; set; }
        /// <summary>
        // Status Same Day Flag
        /// </summary>
        [DataMember]
        [DataElement("02172", typeof(HL7_ID_749))]
        [Pos(29)]
        public virtual string StatusSameDayFlag_29 { get; set; }
        /// <summary>
        // Status Separation Mode
        /// </summary>
        [DataMember]
        [DataElement("02173", typeof(HL7_ID_749))]
        [Pos(30)]
        public virtual string StatusSeparationMode_30 { get; set; }
        /// <summary>
        // Status Weight at Birth
        /// </summary>
        [DataMember]
        [DataElement("02174", typeof(HL7_ID_755))]
        [Pos(31)]
        public virtual string StatusWeightAtBirth_31 { get; set; }
        /// <summary>
        // Status Respiration Minutes
        /// </summary>
        [DataMember]
        [DataElement("02175", typeof(HL7_ID_757))]
        [Pos(32)]
        public virtual string StatusRespirationMinutes_32 { get; set; }
        /// <summary>
        // Status Admission
        /// </summary>
        [DataMember]
        [DataElement("02176", typeof(HL7_ID_759))]
        [Pos(33)]
        public virtual string StatusAdmission_33 { get; set; }
    }
    
    /// <summary>
    // Display Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DSP")]
    public class DSP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - DSP
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00061", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDDSP_01 { get; set; }
        /// <summary>
        // Display Level
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00062", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string DisplayLevel_02 { get; set; }
        /// <summary>
        // Data Line
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 300)]
        [DataElement("00063", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string DataLine_03 { get; set; }
        /// <summary>
        // Logical Break Point
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00064", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string LogicalBreakPoint_04 { get; set; }
        /// <summary>
        // Result ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00065", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string ResultID_05 { get; set; }
    }
    
    /// <summary>
    // Equipment Command
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ECD")]
    public class ECD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reference Command Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("01390", typeof(HL7_N))]
        [Pos(1)]
        public virtual string ReferenceCommandNumber_01 { get; set; }
        /// <summary>
        // Remote Control Command
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual RemoteControlCommand RemoteControlCommand_02 { get; set; }
        /// <summary>
        // Response Required
        /// </summary>
        [DataMember]
        [DataElement("01392", typeof(HL7_ID_136))]
        [Pos(3)]
        public virtual string ResponseRequired_03 { get; set; }
        /// <summary>
        // Requested Completion Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Timingquantity RequestedCompletionTime_04 { get; set; }
        /// <summary>
        // Parameters
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01394", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> Parameters_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Equipment Command Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ECR")]
    public class ECR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Command Response
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CommandResponse CommandResponse_01 { get; set; }
        /// <summary>
        // Date/Time Completed
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01396", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string DateTimeCompleted_02 { get; set; }
        /// <summary>
        // Command Response Parameters
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01397", typeof(HL7_AN))]
        [Pos(3)]
        public virtual List<string> CommandResponseParameters_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Educational Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EDU")]
    public class EDU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - EDU
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("01448", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDEDU_01 { get; set; }
        /// <summary>
        // Academic Degree
        /// </summary>
        [DataMember]
        [DataElement("01449", typeof(HL7_ID_360))]
        [Pos(2)]
        public virtual string AcademicDegree_02 { get; set; }
        /// <summary>
        // Academic Degree Program Date Range
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NameValidityRange AcademicDegreeProgramDateRange_03 { get; set; }
        /// <summary>
        // Academic Degree Program Participation Date Range
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual NameValidityRange AcademicDegreeProgramParticipationDateRange_04 { get; set; }
        /// <summary>
        // Academic Degree Granted Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01451", typeof(HL7_DT))]
        [Pos(5)]
        public virtual string AcademicDegreeGrantedDate_05 { get; set; }
        /// <summary>
        // School
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations School_06 { get; set; }
        /// <summary>
        // School Type Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SchoolTypeCode SchoolTypeCode_07 { get; set; }
        /// <summary>
        // School Address
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ExtendedAddress SchoolAddress_08 { get; set; }
        /// <summary>
        // Major Field of Study
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<AssigningAgencyOrDepartment> MajorFieldOfStudy_09 { get; set; }
    }
    
    /// <summary>
    // Equipment/log Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQP")]
    public class EQP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Event type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EventType EventType_01 { get; set; }
        /// <summary>
        // File Name
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01431", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string FileName_02 { get; set; }
        /// <summary>
        // Start Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01202", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string StartDateTime_03 { get; set; }
        /// <summary>
        // End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01432", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string EndDateTime_04 { get; set; }
        /// <summary>
        // Transaction Data
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01433", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string TransactionData_05 { get; set; }
    }
    
    /// <summary>
    // Equipment Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQU")]
    public class EQU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Equipment Instance Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier EquipmentInstanceIdentifier_01 { get; set; }
        /// <summary>
        // Event Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01322", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string EventDateTime_02 { get; set; }
        /// <summary>
        // Equipment State
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual EquipmentState EquipmentState_03 { get; set; }
        /// <summary>
        // Local/Remote Control State
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LocalRemoteControlState LocalRemoteControlState_04 { get; set; }
        /// <summary>
        // Alert Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NotificationAlertSeverity AlertLevel_05 { get; set; }
    }
    
    /// <summary>
    // Event Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EVN")]
    public class EVN
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Event Type Code
        /// </summary>
        [DataMember]
        [DataElement("00099", typeof(HL7_ID_3))]
        [Pos(1)]
        public virtual string EventTypeCode_01 { get; set; }
        /// <summary>
        // Recorded Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00100", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string RecordedDateTime_02 { get; set; }
        /// <summary>
        // Date/Time Planned Event
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00101", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string DateTimePlannedEvent_03 { get; set; }
        /// <summary>
        // Event Reason Code
        /// </summary>
        [DataMember]
        [DataElement("00102", typeof(HL7_ID_62))]
        [Pos(4)]
        public virtual string EventReasonCode_04 { get; set; }
        /// <summary>
        // Operator ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<OperatorID> OperatorID_05 { get; set; }
        /// <summary>
        // Event Occurred
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01278", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string EventOccurred_06 { get; set; }
        /// <summary>
        // Event Facility
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AssigningFacility EventFacility_07 { get; set; }
    }
    
    /// <summary>
    // Facility
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FAC")]
    public class FAC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Facility ID-FAC
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier FacilityIDFAC_01 { get; set; }
        /// <summary>
        // Facility Type
        /// </summary>
        [DataMember]
        [DataElement("01263", typeof(HL7_ID_331))]
        [Pos(2)]
        public virtual string FacilityType_02 { get; set; }
        /// <summary>
        // Facility Address
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedAddress> FacilityAddress_03 { get; set; }
        /// <summary>
        // Facility Telecommunication
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual ExtendedTelecommunicationsNumber FacilityTelecommunication_04 { get; set; }
        /// <summary>
        // Contact Person
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedCompositeIDNumberAndName> ContactPerson_05 { get; set; }
        /// <summary>
        // Contact Title
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 60)]
        [DataElement("01267", typeof(HL7_AN))]
        [Pos(6)]
        public virtual List<string> ContactTitle_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Contact Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedAddress> ContactAddress_07 { get; set; }
        /// <summary>
        // Contact Telecommunication
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<ExtendedTelecommunicationsNumber> ContactTelecommunication_08 { get; set; }
        /// <summary>
        // Signature Authority
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ExtendedCompositeIDNumberAndName> SignatureAuthority_09 { get; set; }
        /// <summary>
        // Signature Authority Title
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("01271", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string SignatureAuthorityTitle_10 { get; set; }
        /// <summary>
        // Signature Authority Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedAddress> SignatureAuthorityAddress_11 { get; set; }
        /// <summary>
        // Signature Authority Telecommunication
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ExtendedTelecommunicationsNumber SignatureAuthorityTelecommunication_12 { get; set; }
    }
    
    /// <summary>
    // Financial Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FT1")]
    public class FT1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - FT1
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00355", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDFT_01 { get; set; }
        /// <summary>
        // Transaction ID
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00356", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string TransactionID_02 { get; set; }
        /// <summary>
        // Transaction Batch ID
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("00357", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string TransactionBatchID_03 { get; set; }
        /// <summary>
        // Transaction Date
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual NameValidityRange TransactionDate_04 { get; set; }
        /// <summary>
        // Transaction Posting Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00359", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string TransactionPostingDate_05 { get; set; }
        /// <summary>
        // Transaction Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00360", typeof(HL7_ID_17))]
        [Pos(6)]
        public virtual string TransactionType_06 { get; set; }
        /// <summary>
        // Transaction Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual PrimaryKeyValueCDM TransactionCode_07 { get; set; }
        [DataMember]
        [DataElement("00362", typeof(ANY))]
        [Pos(8)]
        public virtual string FT108 { get; set; }
        [DataMember]
        [DataElement("00363", typeof(ANY))]
        [Pos(9)]
        public virtual string FT109 { get; set; }
        /// <summary>
        // Transaction Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("00364", typeof(HL7_N))]
        [Pos(10)]
        public virtual string TransactionQuantity_10 { get; set; }
        /// <summary>
        // Transaction Amount - Extended
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CompositePrice TransactionAmountExtended_11 { get; set; }
        /// <summary>
        // Transaction amount - unit
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual CompositePrice TransactionAmountUnit_12 { get; set; }
        /// <summary>
        // Department Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual DepartmentCode DepartmentCode_13 { get; set; }
        /// <summary>
        // Insurance Plan ID
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AuthorizingPayorPlan InsurancePlanID_14 { get; set; }
        /// <summary>
        // Insurance Amount
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual CompositePrice InsuranceAmount_15 { get; set; }
        /// <summary>
        // Assigned Patient Location
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual PersonLocation AssignedPatientLocation_16 { get; set; }
        /// <summary>
        // Fee Schedule
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("00370", typeof(HL7_AN))]
        [Pos(17)]
        public virtual string FeeSchedule_17 { get; set; }
        /// <summary>
        // Patient Type
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00148", typeof(HL7_AN))]
        [Pos(18)]
        public virtual string PatientType_18 { get; set; }
        /// <summary>
        // Diagnosis Code - FT1
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<AssociatedDiagnosisCode> DiagnosisCodeFT_19 { get; set; }
        /// <summary>
        // Performed By Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<PerformedByCode> PerformedByCode_20 { get; set; }
        /// <summary>
        // Ordered By Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedCompositeIDNumberAndName> OrderedByCode_21 { get; set; }
        /// <summary>
        // Unit Cost
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual CompositePrice UnitCost_22 { get; set; }
        /// <summary>
        // Filler Order Number
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual ComprehensiveLocationIdentifier FillerOrderNumber_23 { get; set; }
        /// <summary>
        // Entered By Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<ExtendedCompositeIDNumberAndName> EnteredByCode_24 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual ProcedureCode ProcedureCode_25 { get; set; }
        /// <summary>
        // Procedure Code Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(26)]
        public virtual List<ProcedureCodeModifier> ProcedureCodeModifier_26 { get; set; }
        /// <summary>
        // Advanced Beneficiary Notice Code
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual AdvancedBeneficiaryNoticeCode AdvancedBeneficiaryNoticeCode_27 { get; set; }
        /// <summary>
        // Medically Necessary Duplicate Procedure Reason
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual MedicallyNecessaryDuplicateProcedureReason MedicallyNecessaryDuplicateProcedureReason_28 { get; set; }
        /// <summary>
        // NDC Code
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual NDCCode NDCCode_29 { get; set; }
        /// <summary>
        // Payment Reference ID
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual ExtendedCompositeIDWithCheckDigit PaymentReferenceID_30 { get; set; }
        /// <summary>
        // Transaction Reference Key
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 4)]
        [DataElement("01847", typeof(HL7_AN))]
        [Pos(31)]
        public virtual List<string> TransactionReferenceKey_31 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Goal Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GOL")]
    public class GOL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00816", typeof(HL7_ID_287))]
        [Pos(1)]
        public virtual string ActionCode_01 { get; set; }
        /// <summary>
        // Action Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00817", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string ActionDateTime_02 { get; set; }
        /// <summary>
        // Goal ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment GoalID_03 { get; set; }
        /// <summary>
        // Goal Instance ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier GoalInstanceID_04 { get; set; }
        /// <summary>
        // Episode of Care ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier EpisodeOfCareID_05 { get; set; }
        /// <summary>
        // Goal List Priority
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("00821", typeof(HL7_N))]
        [Pos(6)]
        public virtual string GoalListPriority_06 { get; set; }
        /// <summary>
        // Goal Established Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00822", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string GoalEstablishedDateTime_07 { get; set; }
        /// <summary>
        // Expected Goal Achieve Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00824", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string ExpectedGoalAchieveDateTime_08 { get; set; }
        /// <summary>
        // Goal Classification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment GoalClassification_09 { get; set; }
        /// <summary>
        // Goal Management Discipline
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment GoalManagementDiscipline_10 { get; set; }
        /// <summary>
        // Current Goal Review Status
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AssigningAgencyOrDepartment CurrentGoalReviewStatus_11 { get; set; }
        /// <summary>
        // Current Goal Review Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00828", typeof(HL7_DTM))]
        [Pos(12)]
        public virtual string CurrentGoalReviewDateTime_12 { get; set; }
        /// <summary>
        // Next Goal Review Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00829", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string NextGoalReviewDateTime_13 { get; set; }
        /// <summary>
        // Previous Goal Review Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00830", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string PreviousGoalReviewDateTime_14 { get; set; }
        /// <summary>
        // Goal Review Interval
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual Timingquantity GoalReviewInterval_15 { get; set; }
        /// <summary>
        // Goal Evaluation
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment GoalEvaluation_16 { get; set; }
        /// <summary>
        // Goal Evaluation Comment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 300)]
        [DataElement("00833", typeof(HL7_AN))]
        [Pos(17)]
        public virtual List<string> GoalEvaluationComment_17 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Goal Life Cycle Status
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual AssigningAgencyOrDepartment GoalLifeCycleStatus_18 { get; set; }
        /// <summary>
        // Goal Life Cycle Status Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00835", typeof(HL7_DTM))]
        [Pos(19)]
        public virtual string GoalLifeCycleStatusDateTime_19 { get; set; }
        /// <summary>
        // Goal Target Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<AssigningAgencyOrDepartment> GoalTargetType_20 { get; set; }
        /// <summary>
        // Goal Target Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedPersonName> GoalTargetName_21 { get; set; }
        /// <summary>
        // Mood Code
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual MoodCode MoodCode_22 { get; set; }
    }
    
    /// <summary>
    // Grouping/Reimbursement - Visit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GP1")]
    public class GP1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Type of Bill Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 3)]
        [DataElement("01599", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string TypeOfBillCode_01 { get; set; }
        /// <summary>
        // Revenue Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 3)]
        [DataElement("01600", typeof(HL7_AN))]
        [Pos(2)]
        public virtual List<string> RevenueCode_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Overall Claim Disposition Code
        /// </summary>
        [DataMember]
        [DataElement("01601", typeof(HL7_ID_457))]
        [Pos(3)]
        public virtual string OverallClaimDispositionCode_03 { get; set; }
        /// <summary>
        // OCE Edits per Visit Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01602", typeof(HL7_ID_458))]
        [Pos(4)]
        public virtual List<string> OCEEditsPerVisitCode_04 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Outlier Cost
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CompositePrice OutlierCost_05 { get; set; }
    }
    
    /// <summary>
    // Grouping/Reimbursement - Procedure Line Item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GP2")]
    public class GP2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Revenue Code
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("01600", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string RevenueCode_01 { get; set; }
        /// <summary>
        // Number of Service Units
        /// </summary>
        [DataMember]
        [StringLength(0, 7)]
        [DataElement("01604", typeof(HL7_N))]
        [Pos(2)]
        public virtual string NumberOfServiceUnits_02 { get; set; }
        /// <summary>
        // Charge
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CompositePrice Charge_03 { get; set; }
        /// <summary>
        // Reimbursement Action Code
        /// </summary>
        [DataMember]
        [DataElement("01606", typeof(HL7_ID_459))]
        [Pos(4)]
        public virtual string ReimbursementActionCode_04 { get; set; }
        /// <summary>
        // Denial or Rejection Code
        /// </summary>
        [DataMember]
        [DataElement("01607", typeof(HL7_ID_460))]
        [Pos(5)]
        public virtual string DenialOrRejectionCode_05 { get; set; }
        /// <summary>
        // OCE Edit Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01608", typeof(HL7_ID_458))]
        [Pos(6)]
        public virtual List<string> OCEEditCode_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Ambulatory Payment Classification Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AmbulatoryPaymentClassificationCode AmbulatoryPaymentClassificationCode_07 { get; set; }
        /// <summary>
        // Modifier Edit Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01610", typeof(HL7_ID_467))]
        [Pos(8)]
        public virtual List<string> ModifierEditCode_08 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Payment Adjustment Code
        /// </summary>
        [DataMember]
        [DataElement("01611", typeof(HL7_ID_468))]
        [Pos(9)]
        public virtual string PaymentAdjustmentCode_09 { get; set; }
        /// <summary>
        // Packaging Status Code
        /// </summary>
        [DataMember]
        [DataElement("01617", typeof(HL7_ID_469))]
        [Pos(10)]
        public virtual string PackagingStatusCode_10 { get; set; }
        /// <summary>
        // Expected CMS Payment Amount
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CompositePrice ExpectedCMSPaymentAmount_11 { get; set; }
        /// <summary>
        // Reimbursement Type Code
        /// </summary>
        [DataMember]
        [DataElement("01619", typeof(HL7_ID_470))]
        [Pos(12)]
        public virtual string ReimbursementTypeCode_12 { get; set; }
        /// <summary>
        // Co-Pay Amount
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CompositePrice CoPayAmount_13 { get; set; }
        /// <summary>
        // Pay Rate per Service Unit
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01621", typeof(HL7_N))]
        [Pos(14)]
        public virtual string PayRatePerServiceUnit_14 { get; set; }
    }
    
    /// <summary>
    // Guarantor
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GT1")]
    public class GT1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - GT1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00405", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDGT_01 { get; set; }
        /// <summary>
        // Guarantor Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> GuarantorNumber_02 { get; set; }
        /// <summary>
        // Guarantor Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedPersonName> GuarantorName_03 { get; set; }
        /// <summary>
        // Guarantor Spouse Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedPersonName> GuarantorSpouseName_04 { get; set; }
        /// <summary>
        // Guarantor Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedAddress> GuarantorAddress_05 { get; set; }
        /// <summary>
        // Guarantor Ph Num - Home
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ExtendedTelecommunicationsNumber> GuarantorPhNumHome_06 { get; set; }
        /// <summary>
        // Guarantor Ph Num - Business
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedTelecommunicationsNumber> GuarantorPhNumBusiness_07 { get; set; }
        /// <summary>
        // Guarantor Date/Time Of Birth
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00412", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string GuarantorDateTimeOfBirth_08 { get; set; }
        /// <summary>
        // Guarantor Administrative Sex
        /// </summary>
        [DataMember]
        [DataElement("00413", typeof(HL7_ID_1))]
        [Pos(9)]
        public virtual string GuarantorAdministrativeSex_09 { get; set; }
        /// <summary>
        // Guarantor Type
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00414", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string GuarantorType_10 { get; set; }
        /// <summary>
        // Guarantor Relationship
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual RelationshipToPatientCode GuarantorRelationship_11 { get; set; }
        /// <summary>
        // Guarantor SSN
        /// </summary>
        [DataMember]
        [StringLength(0, 11)]
        [DataElement("00416", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string GuarantorSSN_12 { get; set; }
        /// <summary>
        // Guarantor Date - Begin
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00417", typeof(HL7_DT))]
        [Pos(13)]
        public virtual string GuarantorDateBegin_13 { get; set; }
        /// <summary>
        // Guarantor Date - End
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00418", typeof(HL7_DT))]
        [Pos(14)]
        public virtual string GuarantorDateEnd_14 { get; set; }
        /// <summary>
        // Guarantor Priority
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00419", typeof(HL7_N))]
        [Pos(15)]
        public virtual string GuarantorPriority_15 { get; set; }
        /// <summary>
        // Guarantor Employer Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedPersonName> GuarantorEmployerName_16 { get; set; }
        /// <summary>
        // Guarantor Employer Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<ExtendedAddress> GuarantorEmployerAddress_17 { get; set; }
        /// <summary>
        // Guarantor Employer Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<ExtendedTelecommunicationsNumber> GuarantorEmployerPhoneNumber_18 { get; set; }
        /// <summary>
        // Guarantor Employee ID Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> GuarantorEmployeeIDNumber_19 { get; set; }
        /// <summary>
        // Guarantor Employment Status
        /// </summary>
        [DataMember]
        [DataElement("00424", typeof(HL7_ID_66))]
        [Pos(20)]
        public virtual string GuarantorEmploymentStatus_20 { get; set; }
        /// <summary>
        // Guarantor Organization Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> GuarantorOrganizationName_21 { get; set; }
        /// <summary>
        // Guarantor Billing Hold Flag
        /// </summary>
        [DataMember]
        [DataElement("00773", typeof(HL7_ID_136))]
        [Pos(22)]
        public virtual string GuarantorBillingHoldFlag_22 { get; set; }
        /// <summary>
        // Guarantor Credit Rating Code
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual GuarantorCreditRatingCode GuarantorCreditRatingCode_23 { get; set; }
        /// <summary>
        // Guarantor Death Date And Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00775", typeof(HL7_DTM))]
        [Pos(24)]
        public virtual string GuarantorDeathDateAndTime_24 { get; set; }
        /// <summary>
        // Guarantor Death Flag
        /// </summary>
        [DataMember]
        [DataElement("00776", typeof(HL7_ID_136))]
        [Pos(25)]
        public virtual string GuarantorDeathFlag_25 { get; set; }
        /// <summary>
        // Guarantor Charge Adjustment Code
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual GuarantorChargeAdjustmentCode GuarantorChargeAdjustmentCode_26 { get; set; }
        /// <summary>
        // Guarantor Household Annual Income
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual CompositePrice GuarantorHouseholdAnnualIncome_27 { get; set; }
        /// <summary>
        // Guarantor Household Size
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00779", typeof(HL7_N))]
        [Pos(28)]
        public virtual string GuarantorHouseholdSize_28 { get; set; }
        /// <summary>
        // Guarantor Employer ID Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(29)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> GuarantorEmployerIDNumber_29 { get; set; }
        /// <summary>
        // Guarantor Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual GuarantorMaritalStatusCode GuarantorMaritalStatusCode_30 { get; set; }
        /// <summary>
        // Guarantor Hire Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00782", typeof(HL7_DT))]
        [Pos(31)]
        public virtual string GuarantorHireEffectiveDate_31 { get; set; }
        /// <summary>
        // Employment Stop Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00783", typeof(HL7_DT))]
        [Pos(32)]
        public virtual string EmploymentStopDate_32 { get; set; }
        /// <summary>
        // Living Dependency
        /// </summary>
        [DataMember]
        [DataElement("00755", typeof(HL7_ID_223))]
        [Pos(33)]
        public virtual string LivingDependency_33 { get; set; }
        /// <summary>
        // Ambulatory Status
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00145", typeof(HL7_ID_9))]
        [Pos(34)]
        public virtual List<string> AmbulatoryStatus_34 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Citizenship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(35)]
        public virtual List<TribalCitizenship> Citizenship_35 { get; set; }
        /// <summary>
        // Primary Language
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual LanguageTranslatedTo PrimaryLanguage_36 { get; set; }
        /// <summary>
        // Living Arrangement
        /// </summary>
        [DataMember]
        [DataElement("00742", typeof(HL7_ID_220))]
        [Pos(37)]
        public virtual string LivingArrangement_37 { get; set; }
        /// <summary>
        // Publicity Code
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual PublicityCode PublicityCode_38 { get; set; }
        /// <summary>
        // Protection Indicator
        /// </summary>
        [DataMember]
        [DataElement("00744", typeof(HL7_ID_136))]
        [Pos(39)]
        public virtual string ProtectionIndicator_39 { get; set; }
        /// <summary>
        // Student Indicator
        /// </summary>
        [DataMember]
        [DataElement("00745", typeof(HL7_ID_231))]
        [Pos(40)]
        public virtual string StudentIndicator_40 { get; set; }
        /// <summary>
        // Religion
        /// </summary>
        [DataMember]
        [Pos(41)]
        public virtual Religion Religion_41 { get; set; }
        /// <summary>
        // Mother's Maiden Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(42)]
        public virtual List<ExtendedPersonName> MothersMaidenName_42 { get; set; }
        /// <summary>
        // Nationality
        /// </summary>
        [DataMember]
        [Pos(43)]
        public virtual Nationality Nationality_43 { get; set; }
        /// <summary>
        // Ethnic Group
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(44)]
        public virtual List<EthnicGroup> EthnicGroup_44 { get; set; }
        /// <summary>
        // Contact Person's Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(45)]
        public virtual List<ExtendedPersonName> ContactPersonsName_45 { get; set; }
        /// <summary>
        // Contact Person's Telephone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(46)]
        public virtual List<ExtendedTelecommunicationsNumber> ContactPersonsTelephoneNumber_46 { get; set; }
        /// <summary>
        // Contact Reason
        /// </summary>
        [DataMember]
        [Pos(47)]
        public virtual ContactReason ContactReason_47 { get; set; }
        /// <summary>
        // Contact Relationship
        /// </summary>
        [DataMember]
        [DataElement("00784", typeof(HL7_ID_63))]
        [Pos(48)]
        public virtual string ContactRelationship_48 { get; set; }
        /// <summary>
        // Job Title
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00785", typeof(HL7_AN))]
        [Pos(49)]
        public virtual string JobTitle_49 { get; set; }
        /// <summary>
        // Job Code/Class
        /// </summary>
        [DataMember]
        [Pos(50)]
        public virtual JobCodeclass JobCodeClass_50 { get; set; }
        /// <summary>
        // Guarantor Employer's Organization Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(51)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> GuarantorEmployersOrganizationName_51 { get; set; }
        /// <summary>
        // Handicap
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00753", typeof(HL7_AN))]
        [Pos(52)]
        public virtual string Handicap_52 { get; set; }
        /// <summary>
        // Job Status
        /// </summary>
        [DataMember]
        [DataElement("00752", typeof(HL7_ID_311))]
        [Pos(53)]
        public virtual string JobStatus_53 { get; set; }
        /// <summary>
        // Guarantor Financial Class
        /// </summary>
        [DataMember]
        [Pos(54)]
        public virtual FinancialClass GuarantorFinancialClass_54 { get; set; }
        /// <summary>
        // Guarantor Race
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(55)]
        public virtual List<GuarantorRace> GuarantorRace_55 { get; set; }
        /// <summary>
        // Guarantor Birth Place
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01851", typeof(HL7_AN))]
        [Pos(56)]
        public virtual string GuarantorBirthPlace_56 { get; set; }
        /// <summary>
        // VIP Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00146", typeof(HL7_AN))]
        [Pos(57)]
        public virtual string VIPIndicator_57 { get; set; }
    }
    
    /// <summary>
    // Patient Adverse Reaction Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IAM")]
    public class IAM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - IAM
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01612", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDIAM_01 { get; set; }
        /// <summary>
        // Allergen Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AllergenTypeCode AllergenTypeCode_02 { get; set; }
        /// <summary>
        // Allergen Code/Mnemonic/Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment AllergenCodeMnemonicDescription_03 { get; set; }
        /// <summary>
        // Allergy Severity Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AllergySeverityCode AllergySeverityCode_04 { get; set; }
        /// <summary>
        // Allergy Reaction Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 15)]
        [DataElement("00207", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> AllergyReactionCode_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Allergy Action Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual AccessRestrictionActionCode AllergyActionCode_06 { get; set; }
        /// <summary>
        // Allergy Unique Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ComprehensiveLocationIdentifier AllergyUniqueIdentifier_07 { get; set; }
        /// <summary>
        // Action Reason
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01553", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string ActionReason_08 { get; set; }
        /// <summary>
        // Sensitivity to Causative Agent Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SensitivityToCausativeAgentCode SensitivityToCausativeAgentCode_09 { get; set; }
        /// <summary>
        // Allergen Group Code/Mnemonic/Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment AllergenGroupCodeMnemonicDescription_10 { get; set; }
        /// <summary>
        // Onset Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01556", typeof(HL7_DT))]
        [Pos(11)]
        public virtual string OnsetDate_11 { get; set; }
        /// <summary>
        // Onset Date Text
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01557", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string OnsetDateText_12 { get; set; }
        /// <summary>
        // Reported Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01558", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string ReportedDateTime_13 { get; set; }
        /// <summary>
        // Reported By
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ExtendedPersonName ReportedBy_14 { get; set; }
        /// <summary>
        // Relationship to Patient Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual RelationshipToPatientCode RelationshipToPatientCode_15 { get; set; }
        /// <summary>
        // Alert Device Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AlertDeviceCode AlertDeviceCode_16 { get; set; }
        /// <summary>
        // Allergy Clinical Status Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual AllergyClinicalStatusCode AllergyClinicalStatusCode_17 { get; set; }
        /// <summary>
        // Statused by Person
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual ExtendedCompositeIDNumberAndName StatusedByPerson_18 { get; set; }
        /// <summary>
        // Statused by Organization
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations StatusedByOrganization_19 { get; set; }
        /// <summary>
        // Statused at Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01565", typeof(HL7_DTM))]
        [Pos(20)]
        public virtual string StatusedAtDateTime_20 { get; set; }
    }
    
    /// <summary>
    // Inventory Item Master
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IIM")]
    public class IIM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - IIM
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment PrimaryKeyValueIIM_01 { get; set; }
        /// <summary>
        // Service Item Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment ServiceItemCode_02 { get; set; }
        /// <summary>
        // Inventory Lot Number
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01800", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string InventoryLotNumber_03 { get; set; }
        /// <summary>
        // Inventory Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01801", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string InventoryExpirationDate_04 { get; set; }
        /// <summary>
        // Inventory Manufacturer Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment InventoryManufacturerName_05 { get; set; }
        /// <summary>
        // Inventory Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment InventoryLocation_06 { get; set; }
        /// <summary>
        // Inventory Received Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01804", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string InventoryReceivedDate_07 { get; set; }
        /// <summary>
        // Inventory Received Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("01805", typeof(HL7_N))]
        [Pos(8)]
        public virtual string InventoryReceivedQuantity_08 { get; set; }
        /// <summary>
        // Inventory Received Quantity Unit
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment InventoryReceivedQuantityUnit_09 { get; set; }
        /// <summary>
        // Inventory Received Item Cost
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ValueAmount InventoryReceivedItemCost_10 { get; set; }
        /// <summary>
        // Inventory On Hand Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01808", typeof(HL7_DTM))]
        [Pos(11)]
        public virtual string InventoryOnHandDate_11 { get; set; }
        /// <summary>
        // Inventory On Hand Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("01809", typeof(HL7_N))]
        [Pos(12)]
        public virtual string InventoryOnHandQuantity_12 { get; set; }
        /// <summary>
        // Inventory On Hand Quantity Unit
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual AssigningAgencyOrDepartment InventoryOnHandQuantityUnit_13 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ProcedureCode ProcedureCode_14 { get; set; }
        /// <summary>
        // Procedure Code Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<ProcedureCodeModifier> ProcedureCodeModifier_15 { get; set; }
    }
    
    /// <summary>
    // Material Lot
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ILT")]
    public class ILT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - ILT
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("02086", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDILT_01 { get; set; }
        /// <summary>
        // Inventory Lot Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 250)]
        [DataElement("01800", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string InventoryLotNumber_02 { get; set; }
        /// <summary>
        // Inventory Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01801", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string InventoryExpirationDate_03 { get; set; }
        /// <summary>
        // Inventory Received Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01804", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string InventoryReceivedDate_04 { get; set; }
        /// <summary>
        // Inventory Received Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("01805", typeof(HL7_N))]
        [Pos(5)]
        public virtual string InventoryReceivedQuantity_05 { get; set; }
        /// <summary>
        // Inventory Received Quantity Unit
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment InventoryReceivedQuantityUnit_06 { get; set; }
        /// <summary>
        // Inventory Received Item Cost
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ValueAmount InventoryReceivedItemCost_07 { get; set; }
        /// <summary>
        // Inventory On Hand Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01808", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string InventoryOnHandDate_08 { get; set; }
        /// <summary>
        // Inventory On Hand Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("01809", typeof(HL7_N))]
        [Pos(9)]
        public virtual string InventoryOnHandQuantity_09 { get; set; }
        /// <summary>
        // Inventory On Hand Quantity Unit
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment InventoryOnHandQuantityUnit_10 { get; set; }
    }
    
    /// <summary>
    // Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IN1")]
    public class IN1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - IN1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00426", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDIN_01 { get; set; }
        /// <summary>
        // Insurance Plan ID
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AuthorizingPayorPlan> InsurancePlanID_02 { get; set; }
        /// <summary>
        // Insurance Company ID
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> InsuranceCompanyID_03 { get; set; }
        /// <summary>
        // Insurance Company Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> InsuranceCompanyName_04 { get; set; }
        /// <summary>
        // Insurance Company Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedAddress> InsuranceCompanyAddress_05 { get; set; }
        /// <summary>
        // Insurance Co Contact Person
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ExtendedPersonName> InsuranceCoContactPerson_06 { get; set; }
        /// <summary>
        // Insurance Co Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedTelecommunicationsNumber> InsuranceCoPhoneNumber_07 { get; set; }
        /// <summary>
        // Group Number
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00433", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string GroupNumber_08 { get; set; }
        /// <summary>
        // Group Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> GroupName_09 { get; set; }
        /// <summary>
        // Insured's Group Emp ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> InsuredsGroupEmpID_10 { get; set; }
        /// <summary>
        // Insured's Group Emp Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> InsuredsGroupEmpName_11 { get; set; }
        /// <summary>
        // Plan Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00437", typeof(HL7_DT))]
        [Pos(12)]
        public virtual string PlanEffectiveDate_12 { get; set; }
        /// <summary>
        // Plan Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00438", typeof(HL7_DT))]
        [Pos(13)]
        public virtual string PlanExpirationDate_13 { get; set; }
        /// <summary>
        // Authorization Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AuthorizationInformation AuthorizationInformation_14 { get; set; }
        /// <summary>
        // Plan Type
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00440", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string PlanType_15 { get; set; }
        /// <summary>
        // Name Of Insured
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedPersonName> NameOfInsured_16 { get; set; }
        /// <summary>
        // Insured's Relationship To Patient
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual RelationshipToPatientCode InsuredsRelationshipToPatient_17 { get; set; }
        /// <summary>
        // Insured's Date Of Birth
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00443", typeof(HL7_DTM))]
        [Pos(18)]
        public virtual string InsuredsDateOfBirth_18 { get; set; }
        /// <summary>
        // Insured's Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ExtendedAddress> InsuredsAddress_19 { get; set; }
        /// <summary>
        // Assignment Of Benefits
        /// </summary>
        [DataMember]
        [DataElement("00445", typeof(HL7_ID_135))]
        [Pos(20)]
        public virtual string AssignmentOfBenefits_20 { get; set; }
        /// <summary>
        // Coordination Of Benefits
        /// </summary>
        [DataMember]
        [DataElement("00446", typeof(HL7_ID_173))]
        [Pos(21)]
        public virtual string CoordinationOfBenefits_21 { get; set; }
        /// <summary>
        // Coord Of Ben. Priority
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00447", typeof(HL7_AN))]
        [Pos(22)]
        public virtual string CoordOfBenPriority_22 { get; set; }
        /// <summary>
        // Notice Of Admission Flag
        /// </summary>
        [DataMember]
        [DataElement("00448", typeof(HL7_ID_136))]
        [Pos(23)]
        public virtual string NoticeOfAdmissionFlag_23 { get; set; }
        /// <summary>
        // Notice Of Admission Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00449", typeof(HL7_DT))]
        [Pos(24)]
        public virtual string NoticeOfAdmissionDate_24 { get; set; }
        /// <summary>
        // Report Of Eligibility Flag
        /// </summary>
        [DataMember]
        [DataElement("00450", typeof(HL7_ID_136))]
        [Pos(25)]
        public virtual string ReportOfEligibilityFlag_25 { get; set; }
        /// <summary>
        // Report Of Eligibility Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00451", typeof(HL7_DT))]
        [Pos(26)]
        public virtual string ReportOfEligibilityDate_26 { get; set; }
        /// <summary>
        // Release Information Code
        /// </summary>
        [DataMember]
        [DataElement("00452", typeof(HL7_ID_93))]
        [Pos(27)]
        public virtual string ReleaseInformationCode_27 { get; set; }
        /// <summary>
        // Pre-Admit Cert (PAC)
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("00453", typeof(HL7_AN))]
        [Pos(28)]
        public virtual string PreAdmitCert_28 { get; set; }
        /// <summary>
        // Verification Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00454", typeof(HL7_DTM))]
        [Pos(29)]
        public virtual string VerificationDateTime_29 { get; set; }
        /// <summary>
        // Verification By
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(30)]
        public virtual List<ExtendedCompositeIDNumberAndName> VerificationBy_30 { get; set; }
        /// <summary>
        // Type Of Agreement Code
        /// </summary>
        [DataMember]
        [DataElement("00456", typeof(HL7_ID_98))]
        [Pos(31)]
        public virtual string TypeOfAgreementCode_31 { get; set; }
        /// <summary>
        // Billing Status
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00457", typeof(HL7_AN))]
        [Pos(32)]
        public virtual string BillingStatus_32 { get; set; }
        /// <summary>
        // Lifetime Reserve Days
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00458", typeof(HL7_N))]
        [Pos(33)]
        public virtual string LifetimeReserveDays_33 { get; set; }
        /// <summary>
        // Delay Before L.R. Day
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00459", typeof(HL7_N))]
        [Pos(34)]
        public virtual string DelayBeforeLRDay_34 { get; set; }
        /// <summary>
        // Company Plan Code
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00460", typeof(HL7_AN))]
        [Pos(35)]
        public virtual string CompanyPlanCode_35 { get; set; }
        /// <summary>
        // Policy Number
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("00461", typeof(HL7_AN))]
        [Pos(36)]
        public virtual string PolicyNumber_36 { get; set; }
        /// <summary>
        // Policy Deductible
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual CompositePrice PolicyDeductible_37 { get; set; }
        [DataMember]
        [DataElement("00463", typeof(ANY))]
        [Pos(38)]
        public virtual string IN138 { get; set; }
        /// <summary>
        // Policy Limit - Days
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00464", typeof(HL7_N))]
        [Pos(39)]
        public virtual string PolicyLimitDays_39 { get; set; }
        [DataMember]
        [DataElement("00465", typeof(ANY))]
        [Pos(40)]
        public virtual string IN140 { get; set; }
        [DataMember]
        [DataElement("00466", typeof(ANY))]
        [Pos(41)]
        public virtual string IN141 { get; set; }
        /// <summary>
        // Insured's Employment Status
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual EmploymentStatusCode InsuredsEmploymentStatus_42 { get; set; }
        /// <summary>
        // Insured's Administrative Sex
        /// </summary>
        [DataMember]
        [DataElement("00468", typeof(HL7_ID_1))]
        [Pos(43)]
        public virtual string InsuredsAdministrativeSex_43 { get; set; }
        /// <summary>
        // Insured's Employer's Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(44)]
        public virtual List<ExtendedAddress> InsuredsEmployersAddress_44 { get; set; }
        /// <summary>
        // Verification Status
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00470", typeof(HL7_AN))]
        [Pos(45)]
        public virtual string VerificationStatus_45 { get; set; }
        /// <summary>
        // Prior Insurance Plan ID
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00471", typeof(HL7_AN))]
        [Pos(46)]
        public virtual string PriorInsurancePlanID_46 { get; set; }
        /// <summary>
        // Coverage Type
        /// </summary>
        [DataMember]
        [DataElement("01227", typeof(HL7_ID_309))]
        [Pos(47)]
        public virtual string CoverageType_47 { get; set; }
        /// <summary>
        // Handicap
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00753", typeof(HL7_AN))]
        [Pos(48)]
        public virtual string Handicap_48 { get; set; }
        /// <summary>
        // Insured's ID Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(49)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> InsuredsIDNumber_49 { get; set; }
        /// <summary>
        // Signature Code
        /// </summary>
        [DataMember]
        [DataElement("01854", typeof(HL7_ID_535))]
        [Pos(50)]
        public virtual string SignatureCode_50 { get; set; }
        /// <summary>
        // Signature Code Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01855", typeof(HL7_DT))]
        [Pos(51)]
        public virtual string SignatureCodeDate_51 { get; set; }
        /// <summary>
        // Insured's Birth Place
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01899", typeof(HL7_AN))]
        [Pos(52)]
        public virtual string InsuredsBirthPlace_52 { get; set; }
        /// <summary>
        // VIP Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("01852", typeof(HL7_AN))]
        [Pos(53)]
        public virtual string VIPIndicator_53 { get; set; }
    }
    
    /// <summary>
    // Insurance Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IN2")]
    public class IN2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Insured's Employee ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> InsuredsEmployeeID_01 { get; set; }
        /// <summary>
        // Insured's Social Security Number
        /// </summary>
        [DataMember]
        [StringLength(0, 11)]
        [DataElement("00473", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string InsuredsSocialSecurityNumber_02 { get; set; }
        /// <summary>
        // Insured's Employer's Name and ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDNumberAndName> InsuredsEmployersNameAndID_03 { get; set; }
        /// <summary>
        // Employer Information Data
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("00475", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string EmployerInformationData_04 { get; set; }
        /// <summary>
        // Mail Claim Party
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00476", typeof(HL7_ID_137))]
        [Pos(5)]
        public virtual List<string> MailClaimParty_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Medicare Health Ins Card Number
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("00477", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string MedicareHealthInsCardNumber_06 { get; set; }
        /// <summary>
        // Medicaid Case Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedPersonName> MedicaidCaseName_07 { get; set; }
        /// <summary>
        // Medicaid Case Number
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("00479", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string MedicaidCaseNumber_08 { get; set; }
        /// <summary>
        // Military Sponsor Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ExtendedPersonName> MilitarySponsorName_09 { get; set; }
        /// <summary>
        // Military ID Number
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00481", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string MilitaryIDNumber_10 { get; set; }
        /// <summary>
        // Dependent Of Military Recipient
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual DependentOfMilitaryRecipient DependentOfMilitaryRecipient_11 { get; set; }
        /// <summary>
        // Military Organization
        /// </summary>
        [DataMember]
        [StringLength(0, 25)]
        [DataElement("00483", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string MilitaryOrganization_12 { get; set; }
        /// <summary>
        // Military Station
        /// </summary>
        [DataMember]
        [StringLength(0, 25)]
        [DataElement("00484", typeof(HL7_AN))]
        [Pos(13)]
        public virtual string MilitaryStation_13 { get; set; }
        /// <summary>
        // Military Service
        /// </summary>
        [DataMember]
        [DataElement("00485", typeof(HL7_ID_140))]
        [Pos(14)]
        public virtual string MilitaryService_14 { get; set; }
        /// <summary>
        // Military Rank/Grade
        /// </summary>
        [DataMember]
        [DataElement("00486", typeof(HL7_ID_141))]
        [Pos(15)]
        public virtual string MilitaryRankGrade_15 { get; set; }
        /// <summary>
        // Military Status
        /// </summary>
        [DataMember]
        [DataElement("00487", typeof(HL7_ID_142))]
        [Pos(16)]
        public virtual string MilitaryStatus_16 { get; set; }
        /// <summary>
        // Military Retire Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00488", typeof(HL7_DT))]
        [Pos(17)]
        public virtual string MilitaryRetireDate_17 { get; set; }
        /// <summary>
        // Military Non-Avail Cert On File
        /// </summary>
        [DataMember]
        [DataElement("00489", typeof(HL7_ID_136))]
        [Pos(18)]
        public virtual string MilitaryNonAvailCertOnFile_18 { get; set; }
        /// <summary>
        // Baby Coverage
        /// </summary>
        [DataMember]
        [DataElement("00490", typeof(HL7_ID_136))]
        [Pos(19)]
        public virtual string BabyCoverage_19 { get; set; }
        /// <summary>
        // Combine Baby Bill
        /// </summary>
        [DataMember]
        [DataElement("00491", typeof(HL7_ID_136))]
        [Pos(20)]
        public virtual string CombineBabyBill_20 { get; set; }
        /// <summary>
        // Blood Deductible
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("00492", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string BloodDeductible_21 { get; set; }
        /// <summary>
        // Special Coverage Approval Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<ExtendedPersonName> SpecialCoverageApprovalName_22 { get; set; }
        /// <summary>
        // Special Coverage Approval Title
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00494", typeof(HL7_AN))]
        [Pos(23)]
        public virtual string SpecialCoverageApprovalTitle_23 { get; set; }
        /// <summary>
        // Non-Covered Insurance Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 8)]
        [DataElement("00495", typeof(HL7_AN))]
        [Pos(24)]
        public virtual List<string> NonCoveredInsuranceCode_24 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Payor ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(25)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> PayorID_25 { get; set; }
        /// <summary>
        // Payor Subscriber ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(26)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> PayorSubscriberID_26 { get; set; }
        /// <summary>
        // Eligibility Source
        /// </summary>
        [DataMember]
        [DataElement("00498", typeof(HL7_ID_144))]
        [Pos(27)]
        public virtual string EligibilitySource_27 { get; set; }
        /// <summary>
        // Room Coverage Type/Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(28)]
        public virtual List<RoomCoverage> RoomCoverageTypeAmount_28 { get; set; }
        /// <summary>
        // Policy Type/Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(29)]
        public virtual List<PolicyTypeAndAmount> PolicyTypeAmount_29 { get; set; }
        /// <summary>
        // Daily Deductible
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual DailyDeductibleInformation DailyDeductible_30 { get; set; }
        /// <summary>
        // Living Dependency
        /// </summary>
        [DataMember]
        [DataElement("00755", typeof(HL7_ID_223))]
        [Pos(31)]
        public virtual string LivingDependency_31 { get; set; }
        /// <summary>
        // Ambulatory Status
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00145", typeof(HL7_ID_9))]
        [Pos(32)]
        public virtual List<string> AmbulatoryStatus_32 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Citizenship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(33)]
        public virtual List<TribalCitizenship> Citizenship_33 { get; set; }
        /// <summary>
        // Primary Language
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual LanguageTranslatedTo PrimaryLanguage_34 { get; set; }
        /// <summary>
        // Living Arrangement
        /// </summary>
        [DataMember]
        [DataElement("00742", typeof(HL7_ID_220))]
        [Pos(35)]
        public virtual string LivingArrangement_35 { get; set; }
        /// <summary>
        // Publicity Code
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual PublicityCode PublicityCode_36 { get; set; }
        /// <summary>
        // Protection Indicator
        /// </summary>
        [DataMember]
        [DataElement("00744", typeof(HL7_ID_136))]
        [Pos(37)]
        public virtual string ProtectionIndicator_37 { get; set; }
        /// <summary>
        // Student Indicator
        /// </summary>
        [DataMember]
        [DataElement("00745", typeof(HL7_ID_231))]
        [Pos(38)]
        public virtual string StudentIndicator_38 { get; set; }
        /// <summary>
        // Religion
        /// </summary>
        [DataMember]
        [Pos(39)]
        public virtual Religion Religion_39 { get; set; }
        /// <summary>
        // Mother's Maiden Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(40)]
        public virtual List<ExtendedPersonName> MothersMaidenName_40 { get; set; }
        /// <summary>
        // Nationality
        /// </summary>
        [DataMember]
        [Pos(41)]
        public virtual Nationality Nationality_41 { get; set; }
        /// <summary>
        // Ethnic Group
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(42)]
        public virtual List<EthnicGroup> EthnicGroup_42 { get; set; }
        /// <summary>
        // Marital Status
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(43)]
        public virtual List<GuarantorMaritalStatusCode> MaritalStatus_43 { get; set; }
        /// <summary>
        // Insured's Employment Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00787", typeof(HL7_DT))]
        [Pos(44)]
        public virtual string InsuredsEmploymentStartDate_44 { get; set; }
        /// <summary>
        // Employment Stop Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00783", typeof(HL7_DT))]
        [Pos(45)]
        public virtual string EmploymentStopDate_45 { get; set; }
        /// <summary>
        // Job Title
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00785", typeof(HL7_AN))]
        [Pos(46)]
        public virtual string JobTitle_46 { get; set; }
        /// <summary>
        // Job Code/Class
        /// </summary>
        [DataMember]
        [Pos(47)]
        public virtual JobCodeclass JobCodeClass_47 { get; set; }
        /// <summary>
        // Job Status
        /// </summary>
        [DataMember]
        [DataElement("00752", typeof(HL7_ID_311))]
        [Pos(48)]
        public virtual string JobStatus_48 { get; set; }
        /// <summary>
        // Employer Contact Person Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(49)]
        public virtual List<ExtendedPersonName> EmployerContactPersonName_49 { get; set; }
        /// <summary>
        // Employer Contact Person Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(50)]
        public virtual List<ExtendedTelecommunicationsNumber> EmployerContactPersonPhoneNumber_50 { get; set; }
        /// <summary>
        // Employer Contact Reason
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00791", typeof(HL7_AN))]
        [Pos(51)]
        public virtual string EmployerContactReason_51 { get; set; }
        /// <summary>
        // Insured's Contact Person's Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(52)]
        public virtual List<ExtendedPersonName> InsuredsContactPersonsName_52 { get; set; }
        /// <summary>
        // Insured's Contact Person Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(53)]
        public virtual List<ExtendedTelecommunicationsNumber> InsuredsContactPersonPhoneNumber_53 { get; set; }
        /// <summary>
        // Insured's Contact Person Reason
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 2)]
        [DataElement("00794", typeof(HL7_AN))]
        [Pos(54)]
        public virtual List<string> InsuredsContactPersonReason_54 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Relationship to the Patient Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00795", typeof(HL7_DT))]
        [Pos(55)]
        public virtual string RelationshipToThePatientStartDate_55 { get; set; }
        /// <summary>
        // Relationship to the Patient Stop Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 8)]
        [DataElement("00796", typeof(HL7_DT))]
        [Pos(56)]
        public virtual List<string> RelationshipToThePatientStopDate_56 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Insurance Co Contact Reason
        /// </summary>
        [DataMember]
        [DataElement("00797", typeof(HL7_ID_232))]
        [Pos(57)]
        public virtual string InsuranceCoContactReason_57 { get; set; }
        /// <summary>
        // Insurance Co Contact Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(58)]
        public virtual List<ExtendedTelecommunicationsNumber> InsuranceCoContactPhoneNumber_58 { get; set; }
        /// <summary>
        // Policy Scope
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00799", typeof(HL7_AN))]
        [Pos(59)]
        public virtual string PolicyScope_59 { get; set; }
        /// <summary>
        // Policy Source
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00800", typeof(HL7_AN))]
        [Pos(60)]
        public virtual string PolicySource_60 { get; set; }
        /// <summary>
        // Patient Member Number
        /// </summary>
        [DataMember]
        [Pos(61)]
        public virtual ExtendedCompositeIDWithCheckDigit PatientMemberNumber_61 { get; set; }
        /// <summary>
        // Guarantor's Relationship to Insured
        /// </summary>
        [DataMember]
        [Pos(62)]
        public virtual RelationshipToPatientCode GuarantorsRelationshipToInsured_62 { get; set; }
        /// <summary>
        // Insured's Phone Number - Home
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(63)]
        public virtual List<ExtendedTelecommunicationsNumber> InsuredsPhoneNumberHome_63 { get; set; }
        /// <summary>
        // Insured's Employer Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(64)]
        public virtual List<ExtendedTelecommunicationsNumber> InsuredsEmployerPhoneNumber_64 { get; set; }
        /// <summary>
        // Military Handicapped Program
        /// </summary>
        [DataMember]
        [Pos(65)]
        public virtual MilitaryHandicappedProgram MilitaryHandicappedProgram_65 { get; set; }
        /// <summary>
        // Suspend Flag
        /// </summary>
        [DataMember]
        [DataElement("00806", typeof(HL7_ID_136))]
        [Pos(66)]
        public virtual string SuspendFlag_66 { get; set; }
        /// <summary>
        // Copay Limit Flag
        /// </summary>
        [DataMember]
        [DataElement("00807", typeof(HL7_ID_136))]
        [Pos(67)]
        public virtual string CopayLimitFlag_67 { get; set; }
        /// <summary>
        // Stoploss Limit Flag
        /// </summary>
        [DataMember]
        [DataElement("00808", typeof(HL7_ID_136))]
        [Pos(68)]
        public virtual string StoplossLimitFlag_68 { get; set; }
        /// <summary>
        // Insured Organization Name and ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(69)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> InsuredOrganizationNameAndID_69 { get; set; }
        /// <summary>
        // Insured Employer Organization Name and ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(70)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> InsuredEmployerOrganizationNameAndID_70 { get; set; }
        /// <summary>
        // Race
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(71)]
        public virtual List<GuarantorRace> Race_71 { get; set; }
        /// <summary>
        // Patient's Relationship to Insured
        /// </summary>
        [DataMember]
        [Pos(72)]
        public virtual PatientsRelationshipToInsured PatientsRelationshipToInsured_72 { get; set; }
    }
    
    /// <summary>
    // Insurance Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IN3")]
    public class IN3
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - IN3
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00502", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDIN_01 { get; set; }
        /// <summary>
        // Certification Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExtendedCompositeIDWithCheckDigit CertificationNumber_02 { get; set; }
        /// <summary>
        // Certified By
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDNumberAndName> CertifiedBy_03 { get; set; }
        /// <summary>
        // Certification Required
        /// </summary>
        [DataMember]
        [DataElement("00505", typeof(HL7_ID_136))]
        [Pos(4)]
        public virtual string CertificationRequired_04 { get; set; }
        /// <summary>
        // Penalty
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MoneyOrPercentage Penalty_05 { get; set; }
        /// <summary>
        // Certification Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00507", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string CertificationDateTime_06 { get; set; }
        /// <summary>
        // Certification Modify Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00508", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string CertificationModifyDateTime_07 { get; set; }
        /// <summary>
        // Operator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<ExtendedCompositeIDNumberAndName> Operator_08 { get; set; }
        /// <summary>
        // Certification Begin Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00510", typeof(HL7_DT))]
        [Pos(9)]
        public virtual string CertificationBeginDate_09 { get; set; }
        /// <summary>
        // Certification End Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00511", typeof(HL7_DT))]
        [Pos(10)]
        public virtual string CertificationEndDate_10 { get; set; }
        /// <summary>
        // Days
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual DayTypeAndNumber Days_11 { get; set; }
        /// <summary>
        // Non-Concur Code/Description
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual NonConcurCodeDescription NonConcurCodeDescription_12 { get; set; }
        /// <summary>
        // Non-Concur Effective Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00514", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string NonConcurEffectiveDateTime_13 { get; set; }
        /// <summary>
        // Physician Reviewer
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<DischargeCareProvider> PhysicianReviewer_14 { get; set; }
        /// <summary>
        // Certification Contact
        /// </summary>
        [DataMember]
        [StringLength(0, 48)]
        [DataElement("00516", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string CertificationContact_15 { get; set; }
        /// <summary>
        // Certification Contact Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedTelecommunicationsNumber> CertificationContactPhoneNumber_16 { get; set; }
        /// <summary>
        // Appeal Reason
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual AppealReason AppealReason_17 { get; set; }
        /// <summary>
        // Certification Agency
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual CertificationAgency CertificationAgency_18 { get; set; }
        /// <summary>
        // Certification Agency Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ExtendedTelecommunicationsNumber> CertificationAgencyPhoneNumber_19 { get; set; }
        /// <summary>
        // Pre-Certification Requirement
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<InsuranceCertificationDefinition> PreCertificationRequirement_20 { get; set; }
        /// <summary>
        // Case Manager
        /// </summary>
        [DataMember]
        [StringLength(0, 48)]
        [DataElement("00522", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string CaseManager_21 { get; set; }
        /// <summary>
        // Second Opinion Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00523", typeof(HL7_DT))]
        [Pos(22)]
        public virtual string SecondOpinionDate_22 { get; set; }
        /// <summary>
        // Second Opinion Status
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("00524", typeof(HL7_AN))]
        [Pos(23)]
        public virtual string SecondOpinionStatus_23 { get; set; }
        /// <summary>
        // Second Opinion Documentation Received
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 1)]
        [DataElement("00525", typeof(HL7_AN))]
        [Pos(24)]
        public virtual List<string> SecondOpinionDocumentationReceived_24 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Second Opinion Physician
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(25)]
        public virtual List<DischargeCareProvider> SecondOpinionPhysician_25 { get; set; }
    }
    
    /// <summary>
    // Inventory Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INV")]
    public class INV
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Substance Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SubstanceIdentifier SubstanceIdentifier_01 { get; set; }
        /// <summary>
        // Substance Status
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<SubstanceStatus> SubstanceStatus_02 { get; set; }
        /// <summary>
        // Substance Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SubstanceType SubstanceType_03 { get; set; }
        /// <summary>
        // Inventory Container Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment InventoryContainerIdentifier_04 { get; set; }
        /// <summary>
        // Container Carrier Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ContainerCarrierIdentifier_05 { get; set; }
        /// <summary>
        // Position on Carrier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment PositionOnCarrier_06 { get; set; }
        /// <summary>
        // Initial Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01378", typeof(HL7_N))]
        [Pos(7)]
        public virtual string InitialQuantity_07 { get; set; }
        /// <summary>
        // Current Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01379", typeof(HL7_N))]
        [Pos(8)]
        public virtual string CurrentQuantity_08 { get; set; }
        /// <summary>
        // Available Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01380", typeof(HL7_N))]
        [Pos(9)]
        public virtual string AvailableQuantity_09 { get; set; }
        /// <summary>
        // Consumption Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01381", typeof(HL7_N))]
        [Pos(10)]
        public virtual string ConsumptionQuantity_10 { get; set; }
        /// <summary>
        // Quantity Units
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AssigningAgencyOrDepartment QuantityUnits_11 { get; set; }
        /// <summary>
        // Expiration Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01383", typeof(HL7_DTM))]
        [Pos(12)]
        public virtual string ExpirationDateTime_12 { get; set; }
        /// <summary>
        // First Used Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01384", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string FirstUsedDateTime_13 { get; set; }
        /// <summary>
        // On Board Stability Duration
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual Timingquantity OnBoardStabilityDuration_14 { get; set; }
        /// <summary>
        // Test/Fluid Identifier(s)
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<AssigningAgencyOrDepartment> TestFluidIdentifier_15 { get; set; }
        /// <summary>
        // Manufacturer Lot Number
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("01387", typeof(HL7_AN))]
        [Pos(16)]
        public virtual string ManufacturerLotNumber_16 { get; set; }
        /// <summary>
        // Manufacturer Identifier
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual SubstanceManufacturerIdentifier ManufacturerIdentifier_17 { get; set; }
        /// <summary>
        // Supplier Identifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual SupplierIdentifier SupplierIdentifier_18 { get; set; }
        /// <summary>
        // On Board Stability Time
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual Quantity OnBoardStabilityTime_19 { get; set; }
        /// <summary>
        // Target Value
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual Quantity TargetValue_20 { get; set; }
    }
    
    /// <summary>
    // Imaging Procedure Control Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IPC")]
    public class IPC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Accession Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier AccessionIdentifier_01 { get; set; }
        /// <summary>
        // Requested Procedure ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier RequestedProcedureID_02 { get; set; }
        /// <summary>
        // Study Instance UID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier StudyInstanceUID_03 { get; set; }
        /// <summary>
        // Scheduled Procedure Step ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier ScheduledProcedureStepID_04 { get; set; }
        /// <summary>
        // Modality
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment Modality_05 { get; set; }
        /// <summary>
        // Protocol Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<AssigningAgencyOrDepartment> ProtocolCode_06 { get; set; }
        /// <summary>
        // Scheduled Station Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ComprehensiveLocationIdentifier ScheduledStationName_07 { get; set; }
        /// <summary>
        // Scheduled Procedure Step Location
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<AssigningAgencyOrDepartment> ScheduledProcedureStepLocation_08 { get; set; }
        /// <summary>
        // Scheduled Station AE Title
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("01665", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string ScheduledStationAETitle_09 { get; set; }
    }
    
    /// <summary>
    // Invoice Processing Results
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IPR")]
    public class IPR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // IPR Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier IPRIdentifier_01 { get; set; }
        /// <summary>
        // Provider Cross Reference Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier ProviderCrossReferenceIdentifier_02 { get; set; }
        /// <summary>
        // Payer Cross Reference Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier PayerCrossReferenceIdentifier_03 { get; set; }
        /// <summary>
        // IPR Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual IPRStatus IPRStatus_04 { get; set; }
        /// <summary>
        // IPR Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 26)]
        [DataElement("02034", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string IPRDateTime_05 { get; set; }
        /// <summary>
        // Adjudicated/Paid Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CompositePrice AdjudicatedPaidAmount_06 { get; set; }
        /// <summary>
        // Expected Payment Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 26)]
        [DataElement("02036", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string ExpectedPaymentDateTime_07 { get; set; }
        /// <summary>
        // IPR Checksum
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 10)]
        [DataElement("02037", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string IPRChecksum_08 { get; set; }
    }
    
    /// <summary>
    // Interaction Status Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ISD")]
    public class ISD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reference Interaction Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("01326", typeof(HL7_N))]
        [Pos(1)]
        public virtual string ReferenceInteractionNumber_01 { get; set; }
        /// <summary>
        // Interaction Type Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RemoteControlCommand InteractionTypeIdentifier_02 { get; set; }
        /// <summary>
        // Interaction Active State
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual CommandResponse InteractionActiveState_03 { get; set; }
    }
    
    /// <summary>
    // Material Item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITM")]
    public class ITM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ItemIdentifier_01 { get; set; }
        /// <summary>
        // Item Description
        /// </summary>
        [DataMember]
        [StringLength(0, 999)]
        [DataElement("02274", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string ItemDescription_02 { get; set; }
        /// <summary>
        // Status of item
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual StatusOfItem StatusOfItem_03 { get; set; }
        /// <summary>
        // Item Type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ItemType ItemType_04 { get; set; }
        /// <summary>
        // Item Category
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ItemCategory_05 { get; set; }
        /// <summary>
        // Subject to Expiration Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DefaultOrderUnitOfMeasureIndicator SubjectToExpirationIndicator_06 { get; set; }
        /// <summary>
        // Manufacturer Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ComprehensiveLocationIdentifier ManufacturerIdentifier_07 { get; set; }
        /// <summary>
        // Manufacturer Name
        /// </summary>
        [DataMember]
        [StringLength(0, 999)]
        [DataElement("02275", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string ManufacturerName_08 { get; set; }
        /// <summary>
        // Manufacturer Catalog Number
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("02192", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string ManufacturerCatalogNumber_09 { get; set; }
        /// <summary>
        // Manufacturer Labeler Identification Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment ManufacturerLabelerIdentificationCode_10 { get; set; }
        /// <summary>
        // Patient Chargeable Indicator
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual DefaultOrderUnitOfMeasureIndicator PatientChargeableIndicator_11 { get; set; }
        /// <summary>
        // Transaction Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual PrimaryKeyValueCDM TransactionCode_12 { get; set; }
        /// <summary>
        // Transaction amount - unit
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CompositePrice TransactionAmountUnit_13 { get; set; }
        /// <summary>
        // Stocked Item Indicator
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual DefaultOrderUnitOfMeasureIndicator StockedItemIndicator_14 { get; set; }
        /// <summary>
        // Supply Risk Codes
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual SupplyRiskCodes SupplyRiskCodes_15 { get; set; }
        /// <summary>
        // Approving Regulatory Agency
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> ApprovingRegulatoryAgency_16 { get; set; }
        /// <summary>
        // Latex Indicator
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual DefaultOrderUnitOfMeasureIndicator LatexIndicator_17 { get; set; }
        /// <summary>
        // Ruling Act
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<RulingAct> RulingAct_18 { get; set; }
        /// <summary>
        // Item Natural Account Code
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00282", typeof(HL7_AN))]
        [Pos(19)]
        public virtual string ItemNaturalAccountCode_19 { get; set; }
        /// <summary>
        // Approved To Buy Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("02203", typeof(HL7_N))]
        [Pos(20)]
        public virtual string ApprovedToBuyQuantity_20 { get; set; }
        /// <summary>
        // Approved To Buy Price
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual ValueAmount ApprovedToBuyPrice_21 { get; set; }
        /// <summary>
        // Taxable Item Indicator
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual DefaultOrderUnitOfMeasureIndicator TaxableItemIndicator_22 { get; set; }
        /// <summary>
        // Freight Charge Indicator
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual DefaultOrderUnitOfMeasureIndicator FreightChargeIndicator_23 { get; set; }
        /// <summary>
        // Item Set Indicator
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual DefaultOrderUnitOfMeasureIndicator ItemSetIndicator_24 { get; set; }
        /// <summary>
        // Item Set Identifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual ComprehensiveLocationIdentifier ItemSetIdentifier_25 { get; set; }
        /// <summary>
        // Track Department Usage Indicator
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual DefaultOrderUnitOfMeasureIndicator TrackDepartmentUsageIndicator_26 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual ProcedureCode ProcedureCode_27 { get; set; }
        /// <summary>
        // Procedure Code Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(28)]
        public virtual List<ProcedureCodeModifier> ProcedureCodeModifier_28 { get; set; }
        /// <summary>
        // Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual SpecimenHandlingCode SpecialHandlingCode_29 { get; set; }
    }
    
    /// <summary>
    // Invoice Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IVC")]
    public class IVC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Provider Invoice Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ProviderInvoiceNumber_01 { get; set; }
        /// <summary>
        // Payer Invoice Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PayerInvoiceNumber_02 { get; set; }
        /// <summary>
        // Contract/Agreement Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier ContractAgreementNumber_03 { get; set; }
        /// <summary>
        // Invoice Control
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01917", typeof(HL7_ID_553))]
        [Pos(4)]
        public virtual string InvoiceControl_04 { get; set; }
        /// <summary>
        // Invoice Reason
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01918", typeof(HL7_ID_554))]
        [Pos(5)]
        public virtual string InvoiceReason_05 { get; set; }
        /// <summary>
        // Invoice Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01919", typeof(HL7_ID_555))]
        [Pos(6)]
        public virtual string InvoiceType_06 { get; set; }
        /// <summary>
        // Invoice Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01920", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string InvoiceDateTime_07 { get; set; }
        /// <summary>
        // Invoice Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual CompositePrice InvoiceAmount_08 { get; set; }
        /// <summary>
        // Payment Terms
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("01922", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string PaymentTerms_09 { get; set; }
        /// <summary>
        // Provider Organization
        /// </summary>
        [DataMember]
        [Required]
        [Pos(10)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations ProviderOrganization_10 { get; set; }
        /// <summary>
        // Payer Organization
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations PayerOrganization_11 { get; set; }
        /// <summary>
        // Attention
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ExtendedCompositeIDNumberAndName Attention_12 { get; set; }
        /// <summary>
        // Last Invoice Indicator
        /// </summary>
        [DataMember]
        [DataElement("01926", typeof(HL7_ID_136))]
        [Pos(13)]
        public virtual string LastInvoiceIndicator_13 { get; set; }
        /// <summary>
        // Invoice Booking Period
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01927", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string InvoiceBookingPeriod_14 { get; set; }
        /// <summary>
        // Origin
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01928", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string Origin_15 { get; set; }
        /// <summary>
        // Invoice Fixed Amount
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual CompositePrice InvoiceFixedAmount_16 { get; set; }
        /// <summary>
        // Special Costs
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual CompositePrice SpecialCosts_17 { get; set; }
        /// <summary>
        // Amount for Doctors Treatment
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual CompositePrice AmountForDoctorsTreatment_18 { get; set; }
        /// <summary>
        // Responsible Physician
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExtendedCompositeIDNumberAndName ResponsiblePhysician_19 { get; set; }
        /// <summary>
        // Cost Center
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExtendedCompositeIDWithCheckDigit CostCenter_20 { get; set; }
        /// <summary>
        // Invoice Prepaid Amount
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual CompositePrice InvoicePrepaidAmount_21 { get; set; }
        /// <summary>
        // Total Invoice Amount without Prepaid Amount
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual CompositePrice TotalInvoiceAmountWithoutPrepaidAmount_22 { get; set; }
        /// <summary>
        // Total-Amount of VAT
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual CompositePrice TotalAmountOfVAT_23 { get; set; }
        /// <summary>
        // VAT-Rates applied
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 1024)]
        [DataElement("01937", typeof(HL7_N))]
        [Pos(24)]
        public virtual List<string> VATRatesApplied_24 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Benefit Group
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01938", typeof(HL7_ID_556))]
        [Pos(25)]
        public virtual string BenefitGroup_25 { get; set; }
        /// <summary>
        // Provider Tax ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("02038", typeof(HL7_AN))]
        [Pos(26)]
        public virtual string ProviderTaxID_26 { get; set; }
        /// <summary>
        // Payer Tax ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("02039", typeof(HL7_AN))]
        [Pos(27)]
        public virtual string PayerTaxID_27 { get; set; }
        /// <summary>
        // Provider Tax status
        /// </summary>
        [DataMember]
        [DataElement("02040", typeof(HL7_ID_572))]
        [Pos(28)]
        public virtual string ProviderTaxStatus_28 { get; set; }
        /// <summary>
        // Payer Tax status
        /// </summary>
        [DataMember]
        [DataElement("02041", typeof(HL7_ID_572))]
        [Pos(29)]
        public virtual string PayerTaxStatus_29 { get; set; }
        /// <summary>
        // Sales Tax ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("02042", typeof(HL7_AN))]
        [Pos(30)]
        public virtual string SalesTaxID_30 { get; set; }
    }
    
    /// <summary>
    // Material Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IVT")]
    public class IVT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - IVT
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("02062", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDIVT_01 { get; set; }
        /// <summary>
        // Inventory Location Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier InventoryLocationIdentifier_02 { get; set; }
        /// <summary>
        // Inventory Location Name
        /// </summary>
        [DataMember]
        [StringLength(0, 999)]
        [DataElement("02277", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string InventoryLocationName_03 { get; set; }
        /// <summary>
        // Source Location Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier SourceLocationIdentifier_04 { get; set; }
        /// <summary>
        // Source Location Name
        /// </summary>
        [DataMember]
        [StringLength(0, 999)]
        [DataElement("02278", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string SourceLocationName_05 { get; set; }
        /// <summary>
        // Item Status
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ItemStatus ItemStatus_06 { get; set; }
        /// <summary>
        // Bin Location Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ComprehensiveLocationIdentifier> BinLocationIdentifier_07 { get; set; }
        /// <summary>
        // Order Packaging
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningAgencyOrDepartment OrderPackaging_08 { get; set; }
        /// <summary>
        // Issue Packaging
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment IssuePackaging_09 { get; set; }
        /// <summary>
        // Default Inventory Asset Account
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ComprehensiveLocationIdentifier DefaultInventoryAssetAccount_10 { get; set; }
        /// <summary>
        // Patient Chargeable Indicator
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual DefaultOrderUnitOfMeasureIndicator PatientChargeableIndicator_11 { get; set; }
        /// <summary>
        // Transaction Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual PrimaryKeyValueCDM TransactionCode_12 { get; set; }
        /// <summary>
        // Transaction amount - unit
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CompositePrice TransactionAmountUnit_13 { get; set; }
        /// <summary>
        // Item Importance Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ItemImportanceCode ItemImportanceCode_14 { get; set; }
        /// <summary>
        // Stocked Item Indicator
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual DefaultOrderUnitOfMeasureIndicator StockedItemIndicator_15 { get; set; }
        /// <summary>
        // Consignment Item Indicator
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual DefaultOrderUnitOfMeasureIndicator ConsignmentItemIndicator_16 { get; set; }
        /// <summary>
        // Reusable Item Indicator
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual DefaultOrderUnitOfMeasureIndicator ReusableItemIndicator_17 { get; set; }
        /// <summary>
        // Reusable Cost
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual CompositePrice ReusableCost_18 { get; set; }
        /// <summary>
        // Substitute Item Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ComprehensiveLocationIdentifier> SubstituteItemIdentifier_19 { get; set; }
        /// <summary>
        // Latex-Free Substitute Item Identifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ComprehensiveLocationIdentifier LatexFreeSubstituteItemIdentifier_20 { get; set; }
        /// <summary>
        // Recommended Reorder Theory
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual RecommendedReorderTheory RecommendedReorderTheory_21 { get; set; }
        /// <summary>
        // Recommended Safety Stock Days
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("02081", typeof(HL7_N))]
        [Pos(22)]
        public virtual string RecommendedSafetyStockDays_22 { get; set; }
        /// <summary>
        // Recommended Maximum Days Inventory
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("02082", typeof(HL7_N))]
        [Pos(23)]
        public virtual string RecommendedMaximumDaysInventory_23 { get; set; }
        /// <summary>
        // Recommended Order Point
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("02083", typeof(HL7_N))]
        [Pos(24)]
        public virtual string RecommendedOrderPoint_24 { get; set; }
        /// <summary>
        // Recommended Order Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("02084", typeof(HL7_N))]
        [Pos(25)]
        public virtual string RecommendedOrderAmount_25 { get; set; }
        /// <summary>
        // Operating Room Par Level Indicator
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual DefaultOrderUnitOfMeasureIndicator OperatingRoomParLevelIndicator_26 { get; set; }
    }
    
    /// <summary>
    // Language Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LAN")]
    public class LAN
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - LAN
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("01455", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDLAN_01 { get; set; }
        /// <summary>
        // Language Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual LanguageTranslatedTo LanguageCode_02 { get; set; }
        /// <summary>
        // Language Ability Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<LanguageAbilityCode> LanguageAbilityCode_03 { get; set; }
        /// <summary>
        // Language Proficiency Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LanguageProficiencyCode LanguageProficiencyCode_04 { get; set; }
    }
    
    /// <summary>
    // Location Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - LOC
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PersonLocation PrimaryKeyValueLOC_01 { get; set; }
        /// <summary>
        // Location Description
        /// </summary>
        [DataMember]
        [StringLength(0, 48)]
        [DataElement("00944", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string LocationDescription_02 { get; set; }
        /// <summary>
        // Location Type - LOC
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [DataElement("00945", typeof(HL7_ID_260))]
        [Pos(3)]
        public virtual List<string> LocationTypeLOC_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Organization Name - LOC
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> OrganizationNameLOC_04 { get; set; }
        /// <summary>
        // Location Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedAddress> LocationAddress_05 { get; set; }
        /// <summary>
        // Location Phone
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ExtendedTelecommunicationsNumber> LocationPhone_06 { get; set; }
        /// <summary>
        // License Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<LicenseNumber> LicenseNumber_07 { get; set; }
        /// <summary>
        // Location Equipment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00953", typeof(HL7_ID_261))]
        [Pos(8)]
        public virtual List<string> LocationEquipment_08 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Location Service Code
        /// </summary>
        [DataMember]
        [DataElement("01583", typeof(HL7_ID_442))]
        [Pos(9)]
        public virtual string LocationServiceCode_09 { get; set; }
    }
    
    /// <summary>
    // Location Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LCC")]
    public class LCC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - LCC
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PersonLocation PrimaryKeyValueLCC_01 { get; set; }
        /// <summary>
        // Location Department
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual LocationDepartment LocationDepartment_02 { get; set; }
        /// <summary>
        // Accommodation Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<AccommodationType> AccommodationType_03 { get; set; }
        /// <summary>
        // Charge Code
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<PrimaryKeyValueCDM> ChargeCode_04 { get; set; }
    }
    
    /// <summary>
    // Location Characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LCH")]
    public class LCH
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - LCH
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PersonLocation PrimaryKeyValueLCH_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Segment Unique Key
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier SegmentUniqueKey_03 { get; set; }
        /// <summary>
        // Location Characteristic ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual LocationCharacteristicID LocationCharacteristicID_04 { get; set; }
        /// <summary>
        // Location Characteristic Value - LCH
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual LocationCharacteristicValueLCH LocationCharacteristicValueLCH_05 { get; set; }
    }
    
    /// <summary>
    // Location Department
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LDP")]
    public class LDP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - LDP
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PersonLocation PrimaryKeyValueLDP_01 { get; set; }
        /// <summary>
        // Location Department
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual LocationDepartment LocationDepartment_02 { get; set; }
        /// <summary>
        // Location Service
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00965", typeof(HL7_ID_69))]
        [Pos(3)]
        public virtual List<string> LocationService_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Specialty Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<SpecialtyType> SpecialtyType_04 { get; set; }
        /// <summary>
        // Valid Patient Classes
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00967", typeof(HL7_ID_4))]
        [Pos(5)]
        public virtual List<string> ValidPatientClasses_05 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Active/Inactive Flag
        /// </summary>
        [DataMember]
        [DataElement("00675", typeof(HL7_ID_183))]
        [Pos(6)]
        public virtual string ActiveInactiveFlag_06 { get; set; }
        /// <summary>
        // Activation Date - LDP
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00969", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string ActivationDateLDP_07 { get; set; }
        /// <summary>
        // Inactivation Date - LDP
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00970", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string InactivationDateLDP_08 { get; set; }
        /// <summary>
        // Inactivated Reason
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("00971", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string InactivatedReason_09 { get; set; }
        /// <summary>
        // Visiting Hours
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<VisitingHours> VisitingHours_10 { get; set; }
        /// <summary>
        // Contact Phone
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual ExtendedTelecommunicationsNumber ContactPhone_11 { get; set; }
        /// <summary>
        // Location Cost Center
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual LocationCostCenter LocationCostCenter_12 { get; set; }
    }
    
    /// <summary>
    // Location Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LRL")]
    public class LRL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - LRL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PersonLocation PrimaryKeyValueLRL_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Segment Unique Key
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier SegmentUniqueKey_03 { get; set; }
        /// <summary>
        // Location Relationship ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual LocationRelationshipID LocationRelationshipID_04 { get; set; }
        /// <summary>
        // Organizational Location Relationship Value
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> OrganizationalLocationRelationshipValue_05 { get; set; }
        /// <summary>
        // Patient Location Relationship Value
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PersonLocation PatientLocationRelationshipValue_06 { get; set; }
    }
    
    /// <summary>
    // Master File Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MFA")]
    public class MFA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Record-Level Event Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00664", typeof(HL7_ID_180))]
        [Pos(1)]
        public virtual string RecordLevelEventCode_01 { get; set; }
        /// <summary>
        // MFN Control ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00665", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string MFNControlID_02 { get; set; }
        /// <summary>
        // Event Completion Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00668", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string EventCompletionDateTime_03 { get; set; }
        /// <summary>
        // MFN Record Level Error Return
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual MFNRecordLevelErrorReturn MFNRecordLevelErrorReturn_04 { get; set; }
        [DataMember]
        [Required]
        [DataElement("01308", typeof(ANY))]
        [Pos(5)]
        public virtual string MFA05 { get; set; }
        /// <summary>
        // Primary Key Value Type - MFA
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [DataElement("01320", typeof(HL7_ID_355))]
        [Pos(6)]
        public virtual List<string> PrimaryKeyValueType_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Master File Entry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MFE")]
    public class MFE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Record-Level Event Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00664", typeof(HL7_ID_180))]
        [Pos(1)]
        public virtual string RecordLevelEventCode_01 { get; set; }
        /// <summary>
        // MFN Control ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00665", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string MFNControlID_02 { get; set; }
        /// <summary>
        // Effective Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00662", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string EffectiveDateTime_03 { get; set; }
        [DataMember]
        [Required]
        [DataElement("00667", typeof(ANY))]
        [Pos(4)]
        public virtual string MFE04 { get; set; }
        /// <summary>
        // Primary Key Value Type
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [DataElement("01319", typeof(HL7_ID_355))]
        [Pos(5)]
        public virtual List<string> PrimaryKeyValueType_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Master File Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MFI")]
    public class MFI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Master File Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MasterFileIdentifier MasterFileIdentifier_01 { get; set; }
        /// <summary>
        // Master File Application Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<MasterFileApplicationIdentifier> MasterFileApplicationIdentifier_02 { get; set; }
        /// <summary>
        // File-Level Event Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00660", typeof(HL7_ID_178))]
        [Pos(3)]
        public virtual string FileLevelEventCode_03 { get; set; }
        /// <summary>
        // Entered Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00661", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string EnteredDateTime_04 { get; set; }
        /// <summary>
        // Effective Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00662", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string EffectiveDateTime_05 { get; set; }
        /// <summary>
        // Response Level Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00663", typeof(HL7_ID_179))]
        [Pos(6)]
        public virtual string ResponseLevelCode_06 { get; set; }
    }
    
    /// <summary>
    // Merge Patient Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MRG")]
    public class MRG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Prior Patient Identifier List
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> PriorPatientIdentifierList_01 { get; set; }
        /// <summary>
        // Prior Alternate Patient ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> PriorAlternatePatientID_02 { get; set; }
        /// <summary>
        // Prior Patient Account Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ExtendedCompositeIDWithCheckDigit PriorPatientAccountNumber_03 { get; set; }
        /// <summary>
        // Prior Patient ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedCompositeIDWithCheckDigit PriorPatientID_04 { get; set; }
        /// <summary>
        // Prior Visit Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDWithCheckDigit PriorVisitNumber_05 { get; set; }
        /// <summary>
        // Prior Alternate Visit ID
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ExtendedCompositeIDWithCheckDigit PriorAlternateVisitID_06 { get; set; }
        /// <summary>
        // Prior Patient Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedPersonName> PriorPatientName_07 { get; set; }
    }
    
    /// <summary>
    // System Clock
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NCK")]
    public class NCK
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // System Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01172", typeof(HL7_DTM))]
        [Pos(1)]
        public virtual string SystemDateTime_01 { get; set; }
    }
    
    /// <summary>
    // Notification Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NDS")]
    public class NDS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Notification Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("01398", typeof(HL7_N))]
        [Pos(1)]
        public virtual string NotificationReferenceNumber_01 { get; set; }
        /// <summary>
        // Notification Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01399", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string NotificationDateTime_02 { get; set; }
        /// <summary>
        // Notification Alert Severity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual NotificationAlertSeverity NotificationAlertSeverity_03 { get; set; }
        /// <summary>
        // Notification Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment NotificationCode_04 { get; set; }
    }
    
    /// <summary>
    // Next of Kin / Associated Parties
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NK1")]
    public class NK1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - NK1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00190", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDNK_01 { get; set; }
        /// <summary>
        // Extended Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ExtendedPersonName> ExtendedName_02 { get; set; }
        /// <summary>
        // Relationship
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RelationshipToPatientCode Relationship_03 { get; set; }
        /// <summary>
        // Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedAddress> Address_04 { get; set; }
        /// <summary>
        // Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedTelecommunicationsNumber> PhoneNumber_05 { get; set; }
        /// <summary>
        // Business Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ExtendedTelecommunicationsNumber> BusinessPhoneNumber_06 { get; set; }
        /// <summary>
        // Contact Role
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ContactRole ContactRole_07 { get; set; }
        /// <summary>
        // Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00197", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string StartDate_08 { get; set; }
        /// <summary>
        // End Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00198", typeof(HL7_DT))]
        [Pos(9)]
        public virtual string EndDate_09 { get; set; }
        /// <summary>
        // Next of Kin / Associated Parties Job Title
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("00199", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string NextOfKinAssociatedPartiesJobTitle_10 { get; set; }
        /// <summary>
        // Next of Kin / Associated Parties Job Code/Class
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual JobCodeclass NextOfKinAssociatedPartiesJobCodeClass_11 { get; set; }
        /// <summary>
        // Next of Kin / Associated Parties Employee Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ExtendedCompositeIDWithCheckDigit NextOfKinAssociatedPartiesEmployeeNumber_12 { get; set; }
        /// <summary>
        // Organization Name - NK1
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> OrganizationNameNK_13 { get; set; }
        /// <summary>
        // Marital Status
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual GuarantorMaritalStatusCode MaritalStatus_14 { get; set; }
        /// <summary>
        // Administrative Sex
        /// </summary>
        [DataMember]
        [DataElement("00111", typeof(HL7_ID_1))]
        [Pos(15)]
        public virtual string AdministrativeSex_15 { get; set; }
        /// <summary>
        // Date/Time of Birth
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00110", typeof(HL7_DTM))]
        [Pos(16)]
        public virtual string DateTimeOfBirth_16 { get; set; }
        /// <summary>
        // Living Dependency
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00755", typeof(HL7_ID_223))]
        [Pos(17)]
        public virtual List<string> LivingDependency_17 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Ambulatory Status
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00145", typeof(HL7_ID_9))]
        [Pos(18)]
        public virtual List<string> AmbulatoryStatus_18 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Citizenship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<TribalCitizenship> Citizenship_19 { get; set; }
        /// <summary>
        // Primary Language
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual LanguageTranslatedTo PrimaryLanguage_20 { get; set; }
        /// <summary>
        // Living Arrangement
        /// </summary>
        [DataMember]
        [DataElement("00742", typeof(HL7_ID_220))]
        [Pos(21)]
        public virtual string LivingArrangement_21 { get; set; }
        /// <summary>
        // Publicity Code
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual PublicityCode PublicityCode_22 { get; set; }
        /// <summary>
        // Protection Indicator
        /// </summary>
        [DataMember]
        [DataElement("00744", typeof(HL7_ID_136))]
        [Pos(23)]
        public virtual string ProtectionIndicator_23 { get; set; }
        /// <summary>
        // Student Indicator
        /// </summary>
        [DataMember]
        [DataElement("00745", typeof(HL7_ID_231))]
        [Pos(24)]
        public virtual string StudentIndicator_24 { get; set; }
        /// <summary>
        // Religion
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual Religion Religion_25 { get; set; }
        /// <summary>
        // Mother's Maiden Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(26)]
        public virtual List<ExtendedPersonName> MothersMaidenName_26 { get; set; }
        /// <summary>
        // Nationality
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual Nationality Nationality_27 { get; set; }
        /// <summary>
        // Ethnic Group
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(28)]
        public virtual List<EthnicGroup> EthnicGroup_28 { get; set; }
        /// <summary>
        // Contact Reason
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(29)]
        public virtual List<ContactReason> ContactReason_29 { get; set; }
        /// <summary>
        // Contact Person's Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(30)]
        public virtual List<ExtendedPersonName> ContactPersonsName_30 { get; set; }
        /// <summary>
        // Contact Person's Telephone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(31)]
        public virtual List<ExtendedTelecommunicationsNumber> ContactPersonsTelephoneNumber_31 { get; set; }
        /// <summary>
        // Contact Person's Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(32)]
        public virtual List<ExtendedAddress> ContactPersonsAddress_32 { get; set; }
        /// <summary>
        // Next of Kin/Associated Party's Identifiers
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(33)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> NextOfKinAssociatedPartysIdentifiers_33 { get; set; }
        /// <summary>
        // Job Status
        /// </summary>
        [DataMember]
        [DataElement("00752", typeof(HL7_ID_311))]
        [Pos(34)]
        public virtual string JobStatus_34 { get; set; }
        /// <summary>
        // Race
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(35)]
        public virtual List<GuarantorRace> Race_35 { get; set; }
        /// <summary>
        // Handicap
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00753", typeof(HL7_AN))]
        [Pos(36)]
        public virtual string Handicap_36 { get; set; }
        /// <summary>
        // Contact Person Social Security Number
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("00754", typeof(HL7_AN))]
        [Pos(37)]
        public virtual string ContactPersonSocialSecurityNumber_37 { get; set; }
        /// <summary>
        // Next of Kin Birth Place
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01905", typeof(HL7_AN))]
        [Pos(38)]
        public virtual string NextOfKinBirthPlace_38 { get; set; }
        /// <summary>
        // VIP Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00146", typeof(HL7_AN))]
        [Pos(39)]
        public virtual string VIPIndicator_39 { get; set; }
    }
    
    /// <summary>
    // Bed Status Update
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NPU")]
    public class NPU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Bed Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PersonLocation BedLocation_01 { get; set; }
        /// <summary>
        // Bed Status
        /// </summary>
        [DataMember]
        [DataElement("00170", typeof(HL7_ID_116))]
        [Pos(2)]
        public virtual string BedStatus_02 { get; set; }
    }
    
    /// <summary>
    // Application Status Change
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NSC")]
    public class NSC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Application Change Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01188", typeof(HL7_ID_409))]
        [Pos(1)]
        public virtual string ApplicationChangeType_01 { get; set; }
        /// <summary>
        // Current CPU
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("01189", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CurrentCPU_02 { get; set; }
        /// <summary>
        // Current Fileserver
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("01190", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string CurrentFileserver_03 { get; set; }
        /// <summary>
        // Current Application
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningFacility CurrentApplication_04 { get; set; }
        /// <summary>
        // Current Facility
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningFacility CurrentFacility_05 { get; set; }
        /// <summary>
        // New CPU
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("01193", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string NewCPU_06 { get; set; }
        /// <summary>
        // New Fileserver
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("01194", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string NewFileserver_07 { get; set; }
        /// <summary>
        // New Application
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningFacility NewApplication_08 { get; set; }
        /// <summary>
        // New Facility
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningFacility NewFacility_09 { get; set; }
    }
    
    /// <summary>
    // Application control level statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NST")]
    public class NST
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Statistics Available
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01173", typeof(HL7_ID_136))]
        [Pos(1)]
        public virtual string StatisticsAvailable_01 { get; set; }
        /// <summary>
        // Source Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("01174", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string SourceIdentifier_02 { get; set; }
        /// <summary>
        // Source Type
        /// </summary>
        [DataMember]
        [DataElement("01175", typeof(HL7_ID_332))]
        [Pos(3)]
        public virtual string SourceType_03 { get; set; }
        /// <summary>
        // Statistics Start
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01176", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string StatisticsStart_04 { get; set; }
        /// <summary>
        // Statistics End
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01177", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string StatisticsEnd_05 { get; set; }
        /// <summary>
        // Receive Character Count
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01178", typeof(HL7_N))]
        [Pos(6)]
        public virtual string ReceiveCharacterCount_06 { get; set; }
        /// <summary>
        // Send Character Count
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01179", typeof(HL7_N))]
        [Pos(7)]
        public virtual string SendCharacterCount_07 { get; set; }
        /// <summary>
        // Messages Received
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01180", typeof(HL7_N))]
        [Pos(8)]
        public virtual string MessagesReceived_08 { get; set; }
        /// <summary>
        // Messages Sent
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01181", typeof(HL7_N))]
        [Pos(9)]
        public virtual string MessagesSent_09 { get; set; }
        /// <summary>
        // Checksum Errors Received
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01182", typeof(HL7_N))]
        [Pos(10)]
        public virtual string ChecksumErrorsReceived_10 { get; set; }
        /// <summary>
        // Length Errors Received
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01183", typeof(HL7_N))]
        [Pos(11)]
        public virtual string LengthErrorsReceived_11 { get; set; }
        /// <summary>
        // Other Errors Received
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01184", typeof(HL7_N))]
        [Pos(12)]
        public virtual string OtherErrorsReceived_12 { get; set; }
        /// <summary>
        // Connect Timeouts
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01185", typeof(HL7_N))]
        [Pos(13)]
        public virtual string ConnectTimeouts_13 { get; set; }
        /// <summary>
        // Receive Timeouts
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01186", typeof(HL7_N))]
        [Pos(14)]
        public virtual string ReceiveTimeouts_14 { get; set; }
        /// <summary>
        // Application control-level Errors
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01187", typeof(HL7_N))]
        [Pos(15)]
        public virtual string ApplicationControllevelErrors_15 { get; set; }
    }
    
    /// <summary>
    // Notes and Comments
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE")]
    public class NTE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - NTE
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00096", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDNTE_01 { get; set; }
        /// <summary>
        // Source of Comment
        /// </summary>
        [DataMember]
        [DataElement("00097", typeof(HL7_ID_105))]
        [Pos(2)]
        public virtual string SourceOfComment_02 { get; set; }
        /// <summary>
        // Comment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00098", typeof(HL7_AN))]
        [Pos(3)]
        public virtual List<string> Comment_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Comment Type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CommentType CommentType_04 { get; set; }
        /// <summary>
        // Entered By
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDNumberAndName EnteredBy_05 { get; set; }
        /// <summary>
        // Entered Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00661", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string EnteredDateTime_06 { get; set; }
        /// <summary>
        // Effective Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01004", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string EffectiveStartDate_07 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("02185", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string ExpirationDate_08 { get; set; }
    }
    
    /// <summary>
    // Observation Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OBR")]
    public class OBR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - OBR
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00237", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDOBR_01 { get; set; }
        /// <summary>
        // Placer Order Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PlacerOrderNumber_02 { get; set; }
        /// <summary>
        // Filler Order Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier FillerOrderNumber_03 { get; set; }
        /// <summary>
        // Universal Service Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment UniversalServiceIdentifier_04 { get; set; }
        /// <summary>
        // Priority
        /// </summary>
        [DataMember]
        [DataElement("00239", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string Priority_05 { get; set; }
        /// <summary>
        // Requested Date/Time
        /// </summary>
        [DataMember]
        [DataElement("00240", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string RequestedDateTime_06 { get; set; }
        /// <summary>
        // Observation Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00241", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string ObservationDateTime_07 { get; set; }
        /// <summary>
        // Observation End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00242", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string ObservationEndDateTime_08 { get; set; }
        /// <summary>
        // Collection Volume
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Quantity CollectionVolume_09 { get; set; }
        /// <summary>
        // Collector Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDNumberAndName> CollectorIdentifier_10 { get; set; }
        /// <summary>
        // Specimen Action Code
        /// </summary>
        [DataMember]
        [DataElement("00245", typeof(HL7_ID_65))]
        [Pos(11)]
        public virtual string SpecimenActionCode_11 { get; set; }
        /// <summary>
        // Danger Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual AssigningAgencyOrDepartment DangerCode_12 { get; set; }
        /// <summary>
        // Relevant Clinical Information
        /// </summary>
        [DataMember]
        [StringLength(0, 300)]
        [DataElement("00247", typeof(HL7_AN))]
        [Pos(13)]
        public virtual string RelevantClinicalInformation_13 { get; set; }
        /// <summary>
        // Specimen Received Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00248", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string SpecimenReceivedDateTime_14 { get; set; }
        /// <summary>
        // Specimen Source
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual SpecimenSource SpecimenSource_15 { get; set; }
        /// <summary>
        // Ordering Provider
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedCompositeIDNumberAndName> OrderingProvider_16 { get; set; }
        /// <summary>
        // Order Callback Phone Number
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(17)]
        public virtual List<ExtendedTelecommunicationsNumber> OrderCallbackPhoneNumber_17 { get; set; }
        /// <summary>
        // Placer Field 1
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("00251", typeof(HL7_AN))]
        [Pos(18)]
        public virtual string PlacerField_18 { get; set; }
        /// <summary>
        // Placer Field 2
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("00252", typeof(HL7_AN))]
        [Pos(19)]
        public virtual string PlacerField_19 { get; set; }
        /// <summary>
        // Filler Field 1
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("00253", typeof(HL7_AN))]
        [Pos(20)]
        public virtual string FillerField_20 { get; set; }
        /// <summary>
        // Filler Field 2
        /// </summary>
        [DataMember]
        [StringLength(0, 199)]
        [DataElement("00254", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string FillerField_21 { get; set; }
        /// <summary>
        // Results Rpt/Status Chng - Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00255", typeof(HL7_DTM))]
        [Pos(22)]
        public virtual string ResultsRptStatusChngDateTime_22 { get; set; }
        /// <summary>
        // Charge to Practice
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual MoneyAndChargeCode ChargeToPractice_23 { get; set; }
        /// <summary>
        // Diagnostic Serv Sect ID
        /// </summary>
        [DataMember]
        [DataElement("00257", typeof(HL7_ID_74))]
        [Pos(24)]
        public virtual string DiagnosticServSectID_24 { get; set; }
        /// <summary>
        // Result Status
        /// </summary>
        [DataMember]
        [DataElement("00258", typeof(HL7_ID_123))]
        [Pos(25)]
        public virtual string ResultStatus_25 { get; set; }
        /// <summary>
        // Parent Result
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual ParentResultLink ParentResult_26 { get; set; }
        /// <summary>
        // Quantity/Timing
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(27)]
        public virtual List<Timingquantity> QuantityTiming_27 { get; set; }
        /// <summary>
        // Result Copies To
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(28)]
        public virtual List<ExtendedCompositeIDNumberAndName> ResultCopiesTo_28 { get; set; }
        /// <summary>
        // Parent
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual EntityIdentifierPair Parent_29 { get; set; }
        /// <summary>
        // Transportation Mode
        /// </summary>
        [DataMember]
        [DataElement("00262", typeof(HL7_ID_124))]
        [Pos(30)]
        public virtual string TransportationMode_30 { get; set; }
        /// <summary>
        // Reason for Study
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(31)]
        public virtual List<AssigningAgencyOrDepartment> ReasonForStudy_31 { get; set; }
        /// <summary>
        // Principal Result Interpreter
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual NameWithLocationAndDate PrincipalResultInterpreter_32 { get; set; }
        /// <summary>
        // Assistant Result Interpreter
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(33)]
        public virtual List<NameWithLocationAndDate> AssistantResultInterpreter_33 { get; set; }
        /// <summary>
        // Technician
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(34)]
        public virtual List<NameWithLocationAndDate> Technician_34 { get; set; }
        /// <summary>
        // Transcriptionist
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(35)]
        public virtual List<NameWithLocationAndDate> Transcriptionist_35 { get; set; }
        /// <summary>
        // Scheduled Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00268", typeof(HL7_DTM))]
        [Pos(36)]
        public virtual string ScheduledDateTime_36 { get; set; }
        /// <summary>
        // Number of Sample Containers *
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("01028", typeof(HL7_N))]
        [Pos(37)]
        public virtual string NumberOfSampleContainers_37 { get; set; }
        /// <summary>
        // Transport Logistics of Collected Sample *
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(38)]
        public virtual List<AssigningAgencyOrDepartment> TransportLogisticsOfCollectedSample_38 { get; set; }
        /// <summary>
        // Collector's Comment *
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(39)]
        public virtual List<AssigningAgencyOrDepartment> CollectorsComment_39 { get; set; }
        /// <summary>
        // Transport Arrangement Responsibility
        /// </summary>
        [DataMember]
        [Pos(40)]
        public virtual AssigningAgencyOrDepartment TransportArrangementResponsibility_40 { get; set; }
        /// <summary>
        // Transport Arranged
        /// </summary>
        [DataMember]
        [DataElement("01032", typeof(HL7_ID_224))]
        [Pos(41)]
        public virtual string TransportArranged_41 { get; set; }
        /// <summary>
        // Escort Required
        /// </summary>
        [DataMember]
        [DataElement("01033", typeof(HL7_ID_225))]
        [Pos(42)]
        public virtual string EscortRequired_42 { get; set; }
        /// <summary>
        // Planned Patient Transport Comment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(43)]
        public virtual List<AssigningAgencyOrDepartment> PlannedPatientTransportComment_43 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [Pos(44)]
        public virtual ProcedureCode ProcedureCode_44 { get; set; }
        /// <summary>
        // Procedure Code Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(45)]
        public virtual List<ProcedureCodeModifier> ProcedureCodeModifier_45 { get; set; }
        /// <summary>
        // Placer Supplemental Service Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(46)]
        public virtual List<FillerSupplementalServiceInformation> PlacerSupplementalServiceInformation_46 { get; set; }
        /// <summary>
        // Filler Supplemental Service Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(47)]
        public virtual List<FillerSupplementalServiceInformation> FillerSupplementalServiceInformation_47 { get; set; }
        /// <summary>
        // Medically Necessary Duplicate Procedure Reason
        /// </summary>
        [DataMember]
        [Pos(48)]
        public virtual MedicallyNecessaryDuplicateProcedureReason MedicallyNecessaryDuplicateProcedureReason_48 { get; set; }
        /// <summary>
        // Result Handling
        /// </summary>
        [DataMember]
        [DataElement("01647", typeof(HL7_ID_507))]
        [Pos(49)]
        public virtual string ResultHandling_49 { get; set; }
        /// <summary>
        // Parent Universal Service Identifier
        /// </summary>
        [DataMember]
        [Pos(50)]
        public virtual AssigningAgencyOrDepartment ParentUniversalServiceIdentifier_50 { get; set; }
    }
    
    /// <summary>
    // Observation/Result
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OBX")]
    public class OBX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - OBX
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00569", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDOBX_01 { get; set; }
        /// <summary>
        // Value Type
        /// </summary>
        [DataMember]
        [DataElement("00570", typeof(HL7_ID_125))]
        [Pos(2)]
        public virtual string ValueType_02 { get; set; }
        /// <summary>
        // Observation Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment ObservationIdentifier_03 { get; set; }
        /// <summary>
        // Observation Sub-ID
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00572", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string ObservationSubID_04 { get; set; }
        /// <summary>
        // Observation Value
        /// </summary>
        [DataMember]
        [DataElement("OBX3", typeof(ANY))]
        [Pos(5)]
        public virtual string ObservationValue_05 { get; set; }
        /// <summary>
        // Units
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment Units_06 { get; set; }
        /// <summary>
        // References Range
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("00575", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string ReferencesRange_07 { get; set; }
        /// <summary>
        // Abnormal Flags
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("00576", typeof(HL7_ID_78))]
        [Pos(8)]
        public virtual List<string> AbnormalFlags_08 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Probability
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00577", typeof(HL7_N))]
        [Pos(9)]
        public virtual string Probability_09 { get; set; }
        /// <summary>
        // Nature of Abnormal Test
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [DataElement("00578", typeof(HL7_ID_80))]
        [Pos(10)]
        public virtual List<string> NatureOfAbnormalTest_10 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Observation Result Status
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00579", typeof(HL7_ID_85))]
        [Pos(11)]
        public virtual string ObservationResultStatus_11 { get; set; }
        /// <summary>
        // Effective Date of Reference Range
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00580", typeof(HL7_DTM))]
        [Pos(12)]
        public virtual string EffectiveDateOfReferenceRange_12 { get; set; }
        /// <summary>
        // User Defined Access Checks
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00581", typeof(HL7_AN))]
        [Pos(13)]
        public virtual string UserDefinedAccessChecks_13 { get; set; }
        /// <summary>
        // Date/Time of the Observation
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00582", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string DateTimeOfTheObservation_14 { get; set; }
        /// <summary>
        // Producer's ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual AssigningAgencyOrDepartment ProducersID_15 { get; set; }
        /// <summary>
        // Responsible Observer
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedCompositeIDNumberAndName> ResponsibleObserver_16 { get; set; }
        /// <summary>
        // Observation Method
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<AssigningAgencyOrDepartment> ObservationMethod_17 { get; set; }
        /// <summary>
        // Equipment Instance Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<ComprehensiveLocationIdentifier> EquipmentInstanceIdentifier_18 { get; set; }
        /// <summary>
        // Date/Time of the Analysis
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01480", typeof(HL7_DTM))]
        [Pos(19)]
        public virtual string DateTimeOfTheAnalysis_19 { get; set; }
        /// <summary>
        // Observation Site
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<ObservationSite> ObservationSite_20 { get; set; }
        /// <summary>
        // Observation Instance Identifier
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual ComprehensiveLocationIdentifier ObservationInstanceIdentifier_21 { get; set; }
        /// <summary>
        // Mood Code
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual MoodCode MoodCode_22 { get; set; }
        /// <summary>
        // Performing Organization Name
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations PerformingOrganizationName_23 { get; set; }
        /// <summary>
        // Performing Organization Address
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual ExtendedAddress PerformingOrganizationAddress_24 { get; set; }
        /// <summary>
        // Performing Organization Medical Director
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual ExtendedCompositeIDNumberAndName PerformingOrganizationMedicalDirector_25 { get; set; }
    }
    
    /// <summary>
    // Dietary Orders
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ODS")]
    public class ODS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00269", typeof(HL7_ID_159))]
        [Pos(1)]
        public virtual string Type_01 { get; set; }
        /// <summary>
        // Service Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AssigningAgencyOrDepartment> ServicePeriod_02 { get; set; }
        /// <summary>
        // Diet
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<AssigningAgencyOrDepartment> Diet_03 { get; set; }
        /// <summary>
        // Text Instruction
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(0, 80)]
        [DataElement("00272", typeof(HL7_AN))]
        [Pos(4)]
        public virtual List<string> TextInstruction_04 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Diet Tray Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ODT")]
    public class ODT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Tray Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TrayType TrayType_01 { get; set; }
        /// <summary>
        // Service Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AssigningAgencyOrDepartment> ServicePeriod_02 { get; set; }
        /// <summary>
        // Text Instruction
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("00272", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string TextInstruction_03 { get; set; }
    }
    
    /// <summary>
    // General Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM1")]
    public class OM1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Producer's Service/Test/Observation ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment ProducersServiceTestObservationID_02 { get; set; }
        /// <summary>
        // Permitted Data Types
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00588", typeof(HL7_ID_125))]
        [Pos(3)]
        public virtual List<string> PermittedDataTypes_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Specimen Required
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00589", typeof(HL7_ID_136))]
        [Pos(4)]
        public virtual string SpecimenRequired_04 { get; set; }
        /// <summary>
        // Producer ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ProducerID_05 { get; set; }
        /// <summary>
        // Observation Description
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("00591", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string ObservationDescription_06 { get; set; }
        /// <summary>
        // Other Service/Test/Observation IDs for the Observation
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AssigningAgencyOrDepartment OtherServiceTestObservationIDsForTheObservation_07 { get; set; }
        /// <summary>
        // Other Names
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [StringLength(0, 200)]
        [DataElement("00593", typeof(HL7_AN))]
        [Pos(8)]
        public virtual List<string> OtherNames_08 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Preferred Report Name for the Observation
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00594", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string PreferredReportNameForTheObservation_09 { get; set; }
        /// <summary>
        // Preferred Short Name or Mnemonic for Observation
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00595", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string PreferredShortNameOrMnemonicForObservation_10 { get; set; }
        /// <summary>
        // Preferred Long Name for the Observation
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("00596", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string PreferredLongNameForTheObservation_11 { get; set; }
        /// <summary>
        // Orderability
        /// </summary>
        [DataMember]
        [DataElement("00597", typeof(HL7_ID_136))]
        [Pos(12)]
        public virtual string Orderability_12 { get; set; }
        /// <summary>
        // Identity of Instrument Used to Perform this Study
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<AssigningAgencyOrDepartment> IdentityOfInstrumentUsedToPerformThisStudy_13 { get; set; }
        /// <summary>
        // Coded Representation of Method
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<AssigningAgencyOrDepartment> CodedRepresentationOfMethod_14 { get; set; }
        /// <summary>
        // Portable Device Indicator
        /// </summary>
        [DataMember]
        [DataElement("00600", typeof(HL7_ID_136))]
        [Pos(15)]
        public virtual string PortableDeviceIndicator_15 { get; set; }
        /// <summary>
        // Observation Producing Department/Section
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<AssigningAgencyOrDepartment> ObservationProducingDepartmentSection_16 { get; set; }
        /// <summary>
        // Telephone Number of Section
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual ExtendedTelecommunicationsNumber TelephoneNumberOfSection_17 { get; set; }
        /// <summary>
        // Nature of Service/Test/Observation
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00603", typeof(HL7_ID_174))]
        [Pos(18)]
        public virtual string NatureOfServiceTestObservation_18 { get; set; }
        /// <summary>
        // Report Subheader
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual AssigningAgencyOrDepartment ReportSubheader_19 { get; set; }
        /// <summary>
        // Report Display Order
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00605", typeof(HL7_AN))]
        [Pos(20)]
        public virtual string ReportDisplayOrder_20 { get; set; }
        /// <summary>
        // Date/Time Stamp for any change in Definition for the Observation
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00606", typeof(HL7_DTM))]
        [Pos(21)]
        public virtual string DateTimeStampForAnyChangeInDefinitionForTheObservation_21 { get; set; }
        /// <summary>
        // Effective Date/Time of Change
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00607", typeof(HL7_DTM))]
        [Pos(22)]
        public virtual string EffectiveDateTimeOfChange_22 { get; set; }
        /// <summary>
        // Typical Turn-Around Time
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00608", typeof(HL7_N))]
        [Pos(23)]
        public virtual string TypicalTurnAroundTime_23 { get; set; }
        /// <summary>
        // Processing Time
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00609", typeof(HL7_N))]
        [Pos(24)]
        public virtual string ProcessingTime_24 { get; set; }
        /// <summary>
        // Processing Priority
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00610", typeof(HL7_ID_168))]
        [Pos(25)]
        public virtual List<string> ProcessingPriority_25 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Reporting Priority
        /// </summary>
        [DataMember]
        [DataElement("00611", typeof(HL7_ID_169))]
        [Pos(26)]
        public virtual string ReportingPriority_26 { get; set; }
        /// <summary>
        // Outside Site(s) Where Observation may be Performed
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(27)]
        public virtual List<AssigningAgencyOrDepartment> OutsideSite_27 { get; set; }
        /// <summary>
        // Address of Outside Site(s)
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(28)]
        public virtual List<ExtendedAddress> AddressOfOutsideSite_28 { get; set; }
        /// <summary>
        // Phone Number of Outside Site
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual ExtendedTelecommunicationsNumber PhoneNumberOfOutsideSite_29 { get; set; }
        /// <summary>
        // Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual ConfidentialityCode ConfidentialityCode_30 { get; set; }
        /// <summary>
        // Observations Required to Interpret the Observation
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual AssigningAgencyOrDepartment ObservationsRequiredToInterpretTheObservation_31 { get; set; }
        /// <summary>
        // Interpretation of Observations
        /// </summary>
        [DataMember]
        [DataElement("00617", typeof(HL7_AN))]
        [Pos(32)]
        public virtual string InterpretationOfObservations_32 { get; set; }
        /// <summary>
        // Contraindications to Observations
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual AssigningAgencyOrDepartment ContraindicationsToObservations_33 { get; set; }
        /// <summary>
        // Reflex Tests/Observations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(34)]
        public virtual List<AssigningAgencyOrDepartment> ReflexTestsObservations_34 { get; set; }
        /// <summary>
        // Rules that Trigger Reflex Testing
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("00620", typeof(HL7_AN))]
        [Pos(35)]
        public virtual string RulesThatTriggerReflexTesting_35 { get; set; }
        /// <summary>
        // Fixed Canned Message
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual AssigningAgencyOrDepartment FixedCannedMessage_36 { get; set; }
        /// <summary>
        // Patient Preparation
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("00622", typeof(HL7_AN))]
        [Pos(37)]
        public virtual string PatientPreparation_37 { get; set; }
        /// <summary>
        // Procedure Medication
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual AssigningAgencyOrDepartment ProcedureMedication_38 { get; set; }
        /// <summary>
        // Factors that may Affect the Observation
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("00624", typeof(HL7_AN))]
        [Pos(39)]
        public virtual string FactorsThatMayAffectTheObservation_39 { get; set; }
        /// <summary>
        // Service/Test/Observation Performance Schedule
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 60)]
        [DataElement("00625", typeof(HL7_AN))]
        [Pos(40)]
        public virtual List<string> ServiceTestObservationPerformanceSchedule_40 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Description of Test Methods
        /// </summary>
        [DataMember]
        [StringLength(0, 41)]
        [DataElement("00626", typeof(HL7_AN))]
        [Pos(41)]
        public virtual string DescriptionOfTestMethods_41 { get; set; }
        /// <summary>
        // Kind of Quantity Observed
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual KindOfQuantityObserved KindOfQuantityObserved_42 { get; set; }
        /// <summary>
        // Point Versus Interval
        /// </summary>
        [DataMember]
        [Pos(43)]
        public virtual PointVersusInterval PointVersusInterval_43 { get; set; }
        /// <summary>
        // Challenge Information
        /// </summary>
        [DataMember]
        [DataElement("00939", typeof(HL7_ID_256))]
        [Pos(44)]
        public virtual string ChallengeInformation_44 { get; set; }
        /// <summary>
        // Relationship Modifier
        /// </summary>
        [DataMember]
        [Pos(45)]
        public virtual RelationshipModifier RelationshipModifier_45 { get; set; }
        /// <summary>
        // Target Anatomic Site Of Test
        /// </summary>
        [DataMember]
        [Pos(46)]
        public virtual AssigningAgencyOrDepartment TargetAnatomicSiteOfTest_46 { get; set; }
        /// <summary>
        // Modality Of Imaging Measurement
        /// </summary>
        [DataMember]
        [Pos(47)]
        public virtual ModalityOfImagingMeasurement ModalityOfImagingMeasurement_47 { get; set; }
    }
    
    /// <summary>
    // Numeric Observation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM2")]
    public class OM2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Units of Measure
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment UnitsOfMeasure_02 { get; set; }
        /// <summary>
        // Range of Decimal Precision
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 10)]
        [DataElement("00628", typeof(HL7_N))]
        [Pos(3)]
        public virtual List<string> RangeOfDecimalPrecision_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Corresponding SI Units of Measure
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment CorrespondingSIUnitsOfMeasure_04 { get; set; }
        /// <summary>
        // SI Conversion Factor
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("00630", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string SIConversionFactor_05 { get; set; }
        /// <summary>
        // Reference (Normal) Range for Ordinal and Continuous Observations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ReferenceRange> Reference_06 { get; set; }
        /// <summary>
        // Critical Range for Ordinal and Continuous Observations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ReferenceRange> CriticalRangeForOrdinalAndContinuousObservations_07 { get; set; }
        /// <summary>
        // Absolute Range for Ordinal and Continuous Observations
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ReferenceRange AbsoluteRangeForOrdinalAndContinuousObservations_08 { get; set; }
        /// <summary>
        // Delta Check Criteria
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Delta> DeltaCheckCriteria_09 { get; set; }
        /// <summary>
        // Minimum Meaningful Increments
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00635", typeof(HL7_N))]
        [Pos(10)]
        public virtual string MinimumMeaningfulIncrements_10 { get; set; }
    }
    
    /// <summary>
    // Categorical Service/Test/Observation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM3")]
    public class OM3
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Preferred Coding System
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment PreferredCodingSystem_02 { get; set; }
        /// <summary>
        // Valid Coded "Answers"
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<AssigningAgencyOrDepartment> ValidCodedAnswers_03 { get; set; }
        /// <summary>
        // Normal Text/Codes for Categorical Observations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<AssigningAgencyOrDepartment> NormalTextCodesForCategoricalObservations_04 { get; set; }
        /// <summary>
        // Abnormal Text/Codes for Categorical Observations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AssigningAgencyOrDepartment> AbnormalTextCodesForCategoricalObservations_05 { get; set; }
        /// <summary>
        // Critical Text/Codes for Categorical Observations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<AssigningAgencyOrDepartment> CriticalTextCodesForCategoricalObservations_06 { get; set; }
        /// <summary>
        // Value Type
        /// </summary>
        [DataMember]
        [DataElement("00570", typeof(HL7_ID_125))]
        [Pos(7)]
        public virtual string ValueType_07 { get; set; }
    }
    
    /// <summary>
    // Observations that Require Specimens
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM4")]
    public class OM4
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Derived Specimen
        /// </summary>
        [DataMember]
        [DataElement("00642", typeof(HL7_ID_170))]
        [Pos(2)]
        public virtual string DerivedSpecimen_02 { get; set; }
        /// <summary>
        // Container Description
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("00643", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ContainerDescription_03 { get; set; }
        /// <summary>
        // Container Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00644", typeof(HL7_N))]
        [Pos(4)]
        public virtual string ContainerVolume_04 { get; set; }
        /// <summary>
        // Container Units
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ContainerUnits_05 { get; set; }
        /// <summary>
        // Specimen
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment Specimen_06 { get; set; }
        /// <summary>
        // Additive
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SpecimenAdditives Additive_07 { get; set; }
        /// <summary>
        // Preparation
        /// </summary>
        [DataMember]
        [StringLength(0, 10240)]
        [DataElement("00648", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string Preparation_08 { get; set; }
        /// <summary>
        // Special Handling Requirements
        /// </summary>
        [DataMember]
        [StringLength(0, 10240)]
        [DataElement("00649", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string SpecialHandlingRequirements_09 { get; set; }
        /// <summary>
        // Normal Collection Volume
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual Quantity NormalCollectionVolume_10 { get; set; }
        /// <summary>
        // Minimum Collection Volume
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual Quantity MinimumCollectionVolume_11 { get; set; }
        /// <summary>
        // Specimen Requirements
        /// </summary>
        [DataMember]
        [StringLength(0, 10240)]
        [DataElement("00652", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string SpecimenRequirements_12 { get; set; }
        /// <summary>
        // Specimen Priorities
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00653", typeof(HL7_ID_27))]
        [Pos(13)]
        public virtual List<string> SpecimenPriorities_13 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Specimen Retention Time
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual Quantity SpecimenRetentionTime_14 { get; set; }
    }
    
    /// <summary>
    // Observation Batteries (Sets)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM5")]
    public class OM5
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Test/Observations Included Within an Ordered Test Battery
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AssigningAgencyOrDepartment> TestObservationsIncludedWithinAnOrderedTestBattery_02 { get; set; }
        /// <summary>
        // Observation ID Suffixes
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("00656", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ObservationIDSuffixes_03 { get; set; }
    }
    
    /// <summary>
    // Observations that are Calculated from Other Observations
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM6")]
    public class OM6
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Derivation Rule
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00657", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string DerivationRule_02 { get; set; }
    }
    
    /// <summary>
    // Additional Basic Attributes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OM7")]
    public class OM7
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence Number - Test/Observation Master File
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00586", typeof(HL7_N))]
        [Pos(1)]
        public virtual string SequenceNumberTestObservationMasterFile_01 { get; set; }
        /// <summary>
        // Universal Service Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment UniversalServiceIdentifier_02 { get; set; }
        /// <summary>
        // Category Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<CategoryIdentifier> CategoryIdentifier_03 { get; set; }
        /// <summary>
        // Category Description
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("01482", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string CategoryDescription_04 { get; set; }
        /// <summary>
        // Category Synonym
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 200)]
        [DataElement("01483", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> CategorySynonym_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Effective Test/Service Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01484", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string EffectiveTestServiceStartDateTime_06 { get; set; }
        /// <summary>
        // Effective Test/Service End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01485", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string EffectiveTestServiceEndDateTime_07 { get; set; }
        /// <summary>
        // Test/Service Default Duration Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01486", typeof(HL7_N))]
        [Pos(8)]
        public virtual string TestServiceDefaultDurationQuantity_08 { get; set; }
        /// <summary>
        // Test/Service Default Duration Units
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment TestServiceDefaultDurationUnits_09 { get; set; }
        /// <summary>
        // Test/Service Default Frequency
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01488", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string TestServiceDefaultFrequency_10 { get; set; }
        /// <summary>
        // Consent Indicator
        /// </summary>
        [DataMember]
        [DataElement("01489", typeof(HL7_ID_136))]
        [Pos(11)]
        public virtual string ConsentIndicator_11 { get; set; }
        /// <summary>
        // Consent Identifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ConsentIdentifier ConsentIdentifier_12 { get; set; }
        /// <summary>
        // Consent Effective Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01491", typeof(HL7_DTM))]
        [Pos(13)]
        public virtual string ConsentEffectiveStartDateTime_13 { get; set; }
        /// <summary>
        // Consent Effective End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01492", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string ConsentEffectiveEndDateTime_14 { get; set; }
        /// <summary>
        // Consent Interval Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01493", typeof(HL7_N))]
        [Pos(15)]
        public virtual string ConsentIntervalQuantity_15 { get; set; }
        /// <summary>
        // Consent Interval Units
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual ConsentWaitingPeriodUnits ConsentIntervalUnits_16 { get; set; }
        /// <summary>
        // Consent Waiting Period Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01495", typeof(HL7_N))]
        [Pos(17)]
        public virtual string ConsentWaitingPeriodQuantity_17 { get; set; }
        /// <summary>
        // Consent Waiting Period Units
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual ConsentWaitingPeriodUnits ConsentWaitingPeriodUnits_18 { get; set; }
        /// <summary>
        // Effective Date/Time of Change
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00607", typeof(HL7_DTM))]
        [Pos(19)]
        public virtual string EffectiveDateTimeOfChange_19 { get; set; }
        /// <summary>
        // Entered By
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ExtendedCompositeIDNumberAndName EnteredBy_20 { get; set; }
        /// <summary>
        // Orderable-at Location
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<PersonLocation> OrderableatLocation_21 { get; set; }
        /// <summary>
        // Formulary Status
        /// </summary>
        [DataMember]
        [DataElement("01498", typeof(HL7_ID_473))]
        [Pos(22)]
        public virtual string FormularyStatus_22 { get; set; }
        /// <summary>
        // Special Order Indicator
        /// </summary>
        [DataMember]
        [DataElement("01499", typeof(HL7_ID_136))]
        [Pos(23)]
        public virtual string SpecialOrderIndicator_23 { get; set; }
        /// <summary>
        // Primary Key Value - CDM
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<PrimaryKeyValueCDM> PrimaryKeyValueCDM_24 { get; set; }
    }
    
    /// <summary>
    // Common Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ORC")]
    public class ORC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Order Control
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00215", typeof(HL7_ID_119))]
        [Pos(1)]
        public virtual string OrderControl_01 { get; set; }
        /// <summary>
        // Placer Order Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PlacerOrderNumber_02 { get; set; }
        /// <summary>
        // Filler Order Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier FillerOrderNumber_03 { get; set; }
        /// <summary>
        // Placer Group Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier PlacerGroupNumber_04 { get; set; }
        /// <summary>
        // Order Status
        /// </summary>
        [DataMember]
        [DataElement("00219", typeof(HL7_ID_38))]
        [Pos(5)]
        public virtual string OrderStatus_05 { get; set; }
        /// <summary>
        // Response Flag
        /// </summary>
        [DataMember]
        [DataElement("00220", typeof(HL7_ID_121))]
        [Pos(6)]
        public virtual string ResponseFlag_06 { get; set; }
        /// <summary>
        // Quantity/Timing
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Timingquantity> QuantityTiming_07 { get; set; }
        /// <summary>
        // Parent
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual EntityIdentifierPair Parent_08 { get; set; }
        /// <summary>
        // Date/Time of Transaction
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00223", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual string DateTimeOfTransaction_09 { get; set; }
        /// <summary>
        // Entered By
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDNumberAndName> EnteredBy_10 { get; set; }
        /// <summary>
        // Verified By
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedCompositeIDNumberAndName> VerifiedBy_11 { get; set; }
        /// <summary>
        // Ordering Provider
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<ExtendedCompositeIDNumberAndName> OrderingProvider_12 { get; set; }
        /// <summary>
        // Enterer's Location
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual PersonLocation EnterersLocation_13 { get; set; }
        /// <summary>
        // Call Back Phone Number
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<ExtendedTelecommunicationsNumber> CallBackPhoneNumber_14 { get; set; }
        /// <summary>
        // Order Effective Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00229", typeof(HL7_DTM))]
        [Pos(15)]
        public virtual string OrderEffectiveDateTime_15 { get; set; }
        /// <summary>
        // Order Control Code Reason
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment OrderControlCodeReason_16 { get; set; }
        /// <summary>
        // Entering Organization
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual AssigningAgencyOrDepartment EnteringOrganization_17 { get; set; }
        /// <summary>
        // Entering Device
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual AssigningAgencyOrDepartment EnteringDevice_18 { get; set; }
        /// <summary>
        // Action By
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ExtendedCompositeIDNumberAndName> ActionBy_19 { get; set; }
        /// <summary>
        // Advanced Beneficiary Notice Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual AdvancedBeneficiaryNoticeCode AdvancedBeneficiaryNoticeCode_20 { get; set; }
        /// <summary>
        // Ordering Facility Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> OrderingFacilityName_21 { get; set; }
        /// <summary>
        // Ordering Facility Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<ExtendedAddress> OrderingFacilityAddress_22 { get; set; }
        /// <summary>
        // Ordering Facility Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(23)]
        public virtual List<ExtendedTelecommunicationsNumber> OrderingFacilityPhoneNumber_23 { get; set; }
        /// <summary>
        // Ordering Provider Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<ExtendedAddress> OrderingProviderAddress_24 { get; set; }
        /// <summary>
        // Order Status Modifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual AssigningAgencyOrDepartment OrderStatusModifier_25 { get; set; }
        /// <summary>
        // Advanced Beneficiary Notice Override Reason
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual AdvancedBeneficiaryNoticeOverrideReason AdvancedBeneficiaryNoticeOverrideReason_26 { get; set; }
        /// <summary>
        // Filler's Expected Availability Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01642", typeof(HL7_DTM))]
        [Pos(27)]
        public virtual string FillersExpectedAvailabilityDateTime_27 { get; set; }
        /// <summary>
        // Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual ConfidentialityCode ConfidentialityCode_28 { get; set; }
        /// <summary>
        // Order Type
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual OrderType OrderType_29 { get; set; }
        /// <summary>
        // Enterer Authorization Mode
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual EntererAuthorizationMode EntererAuthorizationMode_30 { get; set; }
        /// <summary>
        // Parent Universal Service Identifier
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual AssigningAgencyOrDepartment ParentUniversalServiceIdentifier_31 { get; set; }
    }
    
    /// <summary>
    // Practitioner Organization Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ORG")]
    public class ORG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - ORG
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("01459", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDORG_01 { get; set; }
        /// <summary>
        // Organization Unit Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual OrganizationUnitCode OrganizationUnitCode_02 { get; set; }
        /// <summary>
        // Organization Unit Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual OrganizationUnitTypeCode OrganizationUnitTypeCode_03 { get; set; }
        /// <summary>
        // Primary Org Unit Indicator
        /// </summary>
        [DataMember]
        [DataElement("01462", typeof(HL7_ID_136))]
        [Pos(4)]
        public virtual string PrimaryOrgUnitIndicator_04 { get; set; }
        /// <summary>
        // Practitioner Org Unit Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDWithCheckDigit PractitionerOrgUnitIdentifier_05 { get; set; }
        /// <summary>
        // Health Care Provider Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual HealthCareProviderTypeCode HealthCareProviderTypeCode_06 { get; set; }
        /// <summary>
        // Health Care Provider Classification Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual HealthCareProviderClassificationCode HealthCareProviderClassificationCode_07 { get; set; }
        /// <summary>
        // Health Care Provider Area of Specialization Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HealthCareProviderAreaOfSpecializationCode HealthCareProviderAreaOfSpecializationCode_08 { get; set; }
        /// <summary>
        // Effective Date Range
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual NameValidityRange EffectiveDateRange_09 { get; set; }
        /// <summary>
        // Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual EmploymentStatusCode EmploymentStatusCode_10 { get; set; }
        /// <summary>
        // Board Approval Indicator
        /// </summary>
        [DataMember]
        [DataElement("01467", typeof(HL7_ID_136))]
        [Pos(11)]
        public virtual string BoardApprovalIndicator_11 { get; set; }
        /// <summary>
        // Primary Care Physician Indicator
        /// </summary>
        [DataMember]
        [DataElement("01468", typeof(HL7_ID_136))]
        [Pos(12)]
        public virtual string PrimaryCarePhysicianIndicator_12 { get; set; }
    }
    
    /// <summary>
    // Override Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OVR")]
    public class OVR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Business Rule Override Type
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual BusinessRuleOverrideType BusinessRuleOverrideType_01 { get; set; }
        /// <summary>
        // Business Rule Override Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual BusinessRuleOverrideCode BusinessRuleOverrideCode_02 { get; set; }
        /// <summary>
        // Override Comments
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("01831", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string OverrideComments_03 { get; set; }
        /// <summary>
        // Override Entered By
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ExtendedCompositeIDNumberAndName OverrideEnteredBy_04 { get; set; }
        /// <summary>
        // Override Authorized By
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDNumberAndName OverrideAuthorizedBy_05 { get; set; }
    }
    
    /// <summary>
    // Patient Charge Cost Center Exceptions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCE")]
    public class PCE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - PCE
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 2)]
        [DataElement("02228", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDPCE_01 { get; set; }
        /// <summary>
        // Cost Center Account Number
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00281", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CostCenterAccountNumber_02 { get; set; }
        /// <summary>
        // Transaction Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PrimaryKeyValueCDM TransactionCode_03 { get; set; }
        /// <summary>
        // Transaction amount - unit
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CompositePrice TransactionAmountUnit_04 { get; set; }
    }
    
    /// <summary>
    // Possible Causal Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCR")]
    public class PCR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Implicated Product
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment ImplicatedProduct_01 { get; set; }
        /// <summary>
        // Generic Product
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("01099", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string GenericProduct_02 { get; set; }
        /// <summary>
        // Product Class
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment ProductClass_03 { get; set; }
        /// <summary>
        // Total Duration Of Therapy
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Quantity TotalDurationOfTherapy_04 { get; set; }
        /// <summary>
        // Product Manufacture Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01102", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string ProductManufactureDate_05 { get; set; }
        /// <summary>
        // Product Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01103", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string ProductExpirationDate_06 { get; set; }
        /// <summary>
        // Product Implantation Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01104", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string ProductImplantationDate_07 { get; set; }
        /// <summary>
        // Product Explantation Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01105", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string ProductExplantationDate_08 { get; set; }
        /// <summary>
        // Single Use Device
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01106", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string SingleUseDevice_09 { get; set; }
        /// <summary>
        // Indication For Product Use
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment IndicationForProductUse_10 { get; set; }
        /// <summary>
        // Product Problem
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01108", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string ProductProblem_11 { get; set; }
        /// <summary>
        // Product Serial/Lot Number
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [StringLength(0, 199)]
        [DataElement("01109", typeof(HL7_AN))]
        [Pos(12)]
        public virtual List<string> ProductSerialLotNumber_12 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Product Available For Inspection
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("01110", typeof(HL7_AN))]
        [Pos(13)]
        public virtual string ProductAvailableForInspection_13 { get; set; }
        /// <summary>
        // Product Evaluation Performed
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningAgencyOrDepartment ProductEvaluationPerformed_14 { get; set; }
        /// <summary>
        // Product Evaluation Status
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual ProductEvaluationStatus ProductEvaluationStatus_15 { get; set; }
        /// <summary>
        // Product Evaluation Results
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment ProductEvaluationResults_16 { get; set; }
        /// <summary>
        // Evaluated Product Source
        /// </summary>
        [DataMember]
        [DataElement("01114", typeof(HL7_ID_248))]
        [Pos(17)]
        public virtual string EvaluatedProductSource_17 { get; set; }
        /// <summary>
        // Date Product Returned To Manufacturer
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01115", typeof(HL7_DTM))]
        [Pos(18)]
        public virtual string DateProductReturnedToManufacturer_18 { get; set; }
        /// <summary>
        // Device Operator Qualifications
        /// </summary>
        [DataMember]
        [DataElement("01116", typeof(HL7_ID_242))]
        [Pos(19)]
        public virtual string DeviceOperatorQualifications_19 { get; set; }
        /// <summary>
        // Relatedness Assessment
        /// </summary>
        [DataMember]
        [DataElement("01117", typeof(HL7_ID_250))]
        [Pos(20)]
        public virtual string RelatednessAssessment_20 { get; set; }
        /// <summary>
        // Action Taken In Response To The Event
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [DataElement("01118", typeof(HL7_ID_251))]
        [Pos(21)]
        public virtual List<string> ActionTakenInResponseToTheEvent_21 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Causality Observations
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [DataElement("01119", typeof(HL7_ID_252))]
        [Pos(22)]
        public virtual List<string> EventCausalityObservations_22 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Indirect Exposure Mechanism
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [DataElement("01120", typeof(HL7_ID_253))]
        [Pos(23)]
        public virtual List<string> IndirectExposureMechanism_23 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Patient Additional Demographic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PD1")]
    public class PD1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Living Dependency
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00755", typeof(HL7_ID_223))]
        [Pos(1)]
        public virtual List<string> LivingDependency_01 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Living Arrangement
        /// </summary>
        [DataMember]
        [DataElement("00742", typeof(HL7_ID_220))]
        [Pos(2)]
        public virtual string LivingArrangement_02 { get; set; }
        /// <summary>
        // Patient Primary Facility
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> PatientPrimaryFacility_03 { get; set; }
        /// <summary>
        // Patient Primary Care Provider Name & ID No.
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedCompositeIDNumberAndName> PatientPrimaryCareProviderNameIDNo_04 { get; set; }
        /// <summary>
        // Student Indicator
        /// </summary>
        [DataMember]
        [DataElement("00745", typeof(HL7_ID_231))]
        [Pos(5)]
        public virtual string StudentIndicator_05 { get; set; }
        /// <summary>
        // Handicap
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00753", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string Handicap_06 { get; set; }
        /// <summary>
        // Living Will Code
        /// </summary>
        [DataMember]
        [DataElement("00759", typeof(HL7_ID_315))]
        [Pos(7)]
        public virtual string LivingWillCode_07 { get; set; }
        /// <summary>
        // Organ Donor Code
        /// </summary>
        [DataMember]
        [DataElement("00760", typeof(HL7_ID_316))]
        [Pos(8)]
        public virtual string OrganDonorCode_08 { get; set; }
        /// <summary>
        // Separate Bill
        /// </summary>
        [DataMember]
        [DataElement("00761", typeof(HL7_ID_136))]
        [Pos(9)]
        public virtual string SeparateBill_09 { get; set; }
        /// <summary>
        // Duplicate Patient
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> DuplicatePatient_10 { get; set; }
        /// <summary>
        // Publicity Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual PublicityCode PublicityCode_11 { get; set; }
        /// <summary>
        // Protection Indicator
        /// </summary>
        [DataMember]
        [DataElement("00744", typeof(HL7_ID_136))]
        [Pos(12)]
        public virtual string ProtectionIndicator_12 { get; set; }
        /// <summary>
        // Protection Indicator Effective Date
        /// </summary>
        [DataMember]
        [DataElement("01566", typeof(HL7_DT))]
        [Pos(13)]
        public virtual string ProtectionIndicatorEffectiveDate_13 { get; set; }
        /// <summary>
        // Place of Worship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> PlaceOfWorship_14 { get; set; }
        /// <summary>
        // Advance Directive Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<AdvanceDirectiveCode> AdvanceDirectiveCode_15 { get; set; }
        /// <summary>
        // Immunization Registry Status
        /// </summary>
        [DataMember]
        [DataElement("01569", typeof(HL7_ID_441))]
        [Pos(16)]
        public virtual string ImmunizationRegistryStatus_16 { get; set; }
        /// <summary>
        // Immunization Registry Status Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01570", typeof(HL7_DT))]
        [Pos(17)]
        public virtual string ImmunizationRegistryStatusEffectiveDate_17 { get; set; }
        /// <summary>
        // Publicity Code Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01571", typeof(HL7_DT))]
        [Pos(18)]
        public virtual string PublicityCodeEffectiveDate_18 { get; set; }
        /// <summary>
        // Military Branch
        /// </summary>
        [DataMember]
        [DataElement("01572", typeof(HL7_ID_140))]
        [Pos(19)]
        public virtual string MilitaryBranch_19 { get; set; }
        /// <summary>
        // Military Rank/Grade
        /// </summary>
        [DataMember]
        [DataElement("00486", typeof(HL7_ID_141))]
        [Pos(20)]
        public virtual string MilitaryRankGrade_20 { get; set; }
        /// <summary>
        // Military Status
        /// </summary>
        [DataMember]
        [DataElement("01573", typeof(HL7_ID_142))]
        [Pos(21)]
        public virtual string MilitaryStatus_21 { get; set; }
        /// <summary>
        // Advance Directive Last Verified Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("02141", typeof(HL7_DT))]
        [Pos(22)]
        public virtual string AdvanceDirectiveLastVerifiedDate_22 { get; set; }
    }
    
    /// <summary>
    // Patient Death and Autopsy
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PDA")]
    public class PDA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Death Cause Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<AssigningAgencyOrDepartment> DeathCauseCode_01 { get; set; }
        /// <summary>
        // Death Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PersonLocation DeathLocation_02 { get; set; }
        /// <summary>
        // Death Certified Indicator
        /// </summary>
        [DataMember]
        [DataElement("01576", typeof(HL7_ID_136))]
        [Pos(3)]
        public virtual string DeathCertifiedIndicator_03 { get; set; }
        /// <summary>
        // Death Certificate Signed Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01577", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string DeathCertificateSignedDateTime_04 { get; set; }
        /// <summary>
        // Death Certified By
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDNumberAndName DeathCertifiedBy_05 { get; set; }
        /// <summary>
        // Autopsy Indicator
        /// </summary>
        [DataMember]
        [DataElement("01579", typeof(HL7_ID_136))]
        [Pos(6)]
        public virtual string AutopsyIndicator_06 { get; set; }
        /// <summary>
        // Autopsy Start and End Date/Time
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual NameValidityRange AutopsyStartAndEndDateTime_07 { get; set; }
        /// <summary>
        // Autopsy Performed By
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ExtendedCompositeIDNumberAndName AutopsyPerformedBy_08 { get; set; }
        /// <summary>
        // Coroner Indicator
        /// </summary>
        [DataMember]
        [DataElement("01582", typeof(HL7_ID_136))]
        [Pos(9)]
        public virtual string CoronerIndicator_09 { get; set; }
    }
    
    /// <summary>
    // Product Detail Country
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PDC")]
    public class PDC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Manufacturer/Distributor
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> ManufacturerDistributor_01 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment Country_02 { get; set; }
        /// <summary>
        // Brand Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("01249", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string BrandName_03 { get; set; }
        /// <summary>
        // Device Family Name
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01250", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string DeviceFamilyName_04 { get; set; }
        /// <summary>
        // Generic Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment GenericName_05 { get; set; }
        /// <summary>
        // Model Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 60)]
        [DataElement("01252", typeof(HL7_AN))]
        [Pos(6)]
        public virtual List<string> ModelIdentifier_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Catalogue Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01253", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CatalogueIdentifier_07 { get; set; }
        /// <summary>
        // Other Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 60)]
        [DataElement("01254", typeof(HL7_AN))]
        [Pos(8)]
        public virtual List<string> OtherIdentifier_08 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Product Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment ProductCode_09 { get; set; }
        /// <summary>
        // Marketing Basis
        /// </summary>
        [DataMember]
        [DataElement("01256", typeof(HL7_ID_330))]
        [Pos(10)]
        public virtual string MarketingBasis_10 { get; set; }
        /// <summary>
        // Marketing Approval ID
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01257", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string MarketingApprovalID_11 { get; set; }
        /// <summary>
        // Labeled Shelf Life
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Quantity LabeledShelfLife_12 { get; set; }
        /// <summary>
        // Expected Shelf Life
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual Quantity ExpectedShelfLife_13 { get; set; }
        /// <summary>
        // Date First Marketed
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01260", typeof(HL7_DTM))]
        [Pos(14)]
        public virtual string DateFirstMarketed_14 { get; set; }
        /// <summary>
        // Date Last Marketed
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01261", typeof(HL7_DTM))]
        [Pos(15)]
        public virtual string DateLastMarketed_15 { get; set; }
    }
    
    /// <summary>
    // Product Experience Sender
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PES")]
    public class PES
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sender Organization Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> SenderOrganizationName_01 { get; set; }
        /// <summary>
        // Sender Individual Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ExtendedCompositeIDNumberAndName> SenderIndividualName_02 { get; set; }
        /// <summary>
        // Sender Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedAddress> SenderAddress_03 { get; set; }
        /// <summary>
        // Sender Telephone
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedTelecommunicationsNumber> SenderTelephone_04 { get; set; }
        /// <summary>
        // Sender Event Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier SenderEventIdentifier_05 { get; set; }
        /// <summary>
        // Sender Sequence Number
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("01065", typeof(HL7_N))]
        [Pos(6)]
        public virtual string SenderSequenceNumber_06 { get; set; }
        /// <summary>
        // Sender Event Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 600)]
        [DataElement("01066", typeof(HL7_AN))]
        [Pos(7)]
        public virtual List<string> SenderEventDescription_07 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Sender Comment
        /// </summary>
        [DataMember]
        [StringLength(0, 600)]
        [DataElement("01067", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string SenderComment_08 { get; set; }
        /// <summary>
        // Sender Aware Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01068", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual string SenderAwareDateTime_09 { get; set; }
        /// <summary>
        // Event Report Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01069", typeof(HL7_DTM))]
        [Pos(10)]
        public virtual string EventReportDate_10 { get; set; }
        /// <summary>
        // Event Report Timing/Type
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("01070", typeof(HL7_ID_234))]
        [Pos(11)]
        public virtual List<string> EventReportTimingType_11 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Report Source
        /// </summary>
        [DataMember]
        [DataElement("01071", typeof(HL7_ID_235))]
        [Pos(12)]
        public virtual string EventReportSource_12 { get; set; }
        /// <summary>
        // Event Reported To
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01072", typeof(HL7_ID_236))]
        [Pos(13)]
        public virtual List<string> EventReportedTo_13 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Patient Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PID")]
    public class PID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - PID
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00104", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDPID_01 { get; set; }
        /// <summary>
        // Patient ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ExtendedCompositeIDWithCheckDigit PatientID_02 { get; set; }
        /// <summary>
        // Patient Identifier List
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> PatientIdentifierList_03 { get; set; }
        /// <summary>
        // Alternate Patient ID - PID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> AlternatePatientIDPID_04 { get; set; }
        /// <summary>
        // Patient Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedPersonName> PatientName_05 { get; set; }
        /// <summary>
        // Mother's Maiden Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ExtendedPersonName> MothersMaidenName_06 { get; set; }
        /// <summary>
        // Date/Time of Birth
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00110", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string DateTimeOfBirth_07 { get; set; }
        /// <summary>
        // Administrative Sex
        /// </summary>
        [DataMember]
        [DataElement("00111", typeof(HL7_ID_1))]
        [Pos(8)]
        public virtual string AdministrativeSex_08 { get; set; }
        /// <summary>
        // Patient Alias
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ExtendedPersonName> PatientAlias_09 { get; set; }
        /// <summary>
        // Race
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<GuarantorRace> Race_10 { get; set; }
        /// <summary>
        // Patient Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedAddress> PatientAddress_11 { get; set; }
        /// <summary>
        // County Code
        /// </summary>
        [DataMember]
        [DataElement("00115", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string CountyCode_12 { get; set; }
        /// <summary>
        // Phone Number - Home
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<ExtendedTelecommunicationsNumber> PhoneNumberHome_13 { get; set; }
        /// <summary>
        // Phone Number - Business
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<ExtendedTelecommunicationsNumber> PhoneNumberBusiness_14 { get; set; }
        /// <summary>
        // Primary Language
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual LanguageTranslatedTo PrimaryLanguage_15 { get; set; }
        /// <summary>
        // Marital Status
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual GuarantorMaritalStatusCode MaritalStatus_16 { get; set; }
        /// <summary>
        // Religion
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual Religion Religion_17 { get; set; }
        /// <summary>
        // Patient Account Number
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual ExtendedCompositeIDWithCheckDigit PatientAccountNumber_18 { get; set; }
        /// <summary>
        // SSN Number - Patient
        /// </summary>
        [DataMember]
        [DataElement("00122", typeof(HL7_AN))]
        [Pos(19)]
        public virtual string SSNNumberPatient_19 { get; set; }
        /// <summary>
        // Driver's License Number - Patient
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual DriversLicenseNumber DriversLicenseNumberPatient_20 { get; set; }
        /// <summary>
        // Mother's Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> MothersIdentifier_21 { get; set; }
        /// <summary>
        // Ethnic Group
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<EthnicGroup> EthnicGroup_22 { get; set; }
        /// <summary>
        // Birth Place
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("00126", typeof(HL7_AN))]
        [Pos(23)]
        public virtual string BirthPlace_23 { get; set; }
        /// <summary>
        // Multiple Birth Indicator
        /// </summary>
        [DataMember]
        [DataElement("00127", typeof(HL7_ID_136))]
        [Pos(24)]
        public virtual string MultipleBirthIndicator_24 { get; set; }
        /// <summary>
        // Birth Order
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00128", typeof(HL7_N))]
        [Pos(25)]
        public virtual string BirthOrder_25 { get; set; }
        /// <summary>
        // Citizenship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(26)]
        public virtual List<TribalCitizenship> Citizenship_26 { get; set; }
        /// <summary>
        // Veterans Military Status
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual VeteransMilitaryStatus VeteransMilitaryStatus_27 { get; set; }
        /// <summary>
        // Nationality
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual Nationality Nationality_28 { get; set; }
        /// <summary>
        // Patient Death Date and Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00740", typeof(HL7_DTM))]
        [Pos(29)]
        public virtual string PatientDeathDateAndTime_29 { get; set; }
        /// <summary>
        // Patient Death Indicator
        /// </summary>
        [DataMember]
        [DataElement("00741", typeof(HL7_ID_136))]
        [Pos(30)]
        public virtual string PatientDeathIndicator_30 { get; set; }
        /// <summary>
        // Identity Unknown Indicator
        /// </summary>
        [DataMember]
        [DataElement("01535", typeof(HL7_ID_136))]
        [Pos(31)]
        public virtual string IdentityUnknownIndicator_31 { get; set; }
        /// <summary>
        // Identity Reliability Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01536", typeof(HL7_ID_445))]
        [Pos(32)]
        public virtual List<string> IdentityReliabilityCode_32 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Last Update Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01537", typeof(HL7_DTM))]
        [Pos(33)]
        public virtual string LastUpdateDateTime_33 { get; set; }
        /// <summary>
        // Last Update Facility
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual AssigningFacility LastUpdateFacility_34 { get; set; }
        /// <summary>
        // Species Code
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual SpeciesCode SpeciesCode_35 { get; set; }
        /// <summary>
        // Breed Code
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual BreedCode BreedCode_36 { get; set; }
        /// <summary>
        // Strain
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("01541", typeof(HL7_AN))]
        [Pos(37)]
        public virtual string Strain_37 { get; set; }
        /// <summary>
        // Production Class Code
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(38)]
        public virtual List<ProductionClassCode> ProductionClassCode_38 { get; set; }
        /// <summary>
        // Tribal Citizenship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(39)]
        public virtual List<TribalCitizenship> TribalCitizenship_39 { get; set; }
    }
    
    /// <summary>
    // Item Packaging
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PKG")]
    public class PKG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - PKG
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 2)]
        [DataElement("02221", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDPKG_01 { get; set; }
        /// <summary>
        // Packaging Units
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PackagingUnits PackagingUnits_02 { get; set; }
        /// <summary>
        // Default Order Unit Of Measure Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DefaultOrderUnitOfMeasureIndicator DefaultOrderUnitOfMeasureIndicator_03 { get; set; }
        /// <summary>
        // Package Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("02224", typeof(HL7_N))]
        [Pos(4)]
        public virtual string PackageQuantity_04 { get; set; }
        /// <summary>
        // Price
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CompositePrice Price_05 { get; set; }
        /// <summary>
        // Future Item Price
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CompositePrice FutureItemPrice_06 { get; set; }
        /// <summary>
        // Future Item Price Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("02227", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string FutureItemPriceEffectiveDate_07 { get; set; }
    }
    
    /// <summary>
    // Product Experience Observation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PEO")]
    public class PEO
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Event Identifiers Used
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<AssigningAgencyOrDepartment> EventIdentifiersUsed_01 { get; set; }
        /// <summary>
        // Event Symptom/Diagnosis Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AssigningAgencyOrDepartment> EventSymptomDiagnosisCode_02 { get; set; }
        /// <summary>
        // Event Onset Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01075", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string EventOnsetDateTime_03 { get; set; }
        /// <summary>
        // Event Exacerbation Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01076", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string EventExacerbationDateTime_04 { get; set; }
        /// <summary>
        // Event Improved Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01077", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string EventImprovedDateTime_05 { get; set; }
        /// <summary>
        // Event Ended Data/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01078", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string EventEndedDataTime_06 { get; set; }
        /// <summary>
        // Event Location Occurred Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<ExtendedAddress> EventLocationOccurredAddress_07 { get; set; }
        /// <summary>
        // Event Qualification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01080", typeof(HL7_ID_237))]
        [Pos(8)]
        public virtual List<string> EventQualification_08 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Serious
        /// </summary>
        [DataMember]
        [DataElement("01081", typeof(HL7_ID_238))]
        [Pos(9)]
        public virtual string EventSerious_09 { get; set; }
        /// <summary>
        // Event Expected
        /// </summary>
        [DataMember]
        [DataElement("01082", typeof(HL7_ID_239))]
        [Pos(10)]
        public virtual string EventExpected_10 { get; set; }
        /// <summary>
        // Event Outcome
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01083", typeof(HL7_ID_240))]
        [Pos(11)]
        public virtual List<string> EventOutcome_11 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Patient Outcome
        /// </summary>
        [DataMember]
        [DataElement("01084", typeof(HL7_ID_241))]
        [Pos(12)]
        public virtual string PatientOutcome_12 { get; set; }
        /// <summary>
        // Event Description from Others
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 600)]
        [DataElement("01085", typeof(HL7_AN))]
        [Pos(13)]
        public virtual List<string> EventDescriptionFromOthers_13 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Description from Original Reporter
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 600)]
        [DataElement("01086", typeof(HL7_AN))]
        [Pos(14)]
        public virtual List<string> EventDescriptionFromOriginalReporter_14 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Description from Patient
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 600)]
        [DataElement("01087", typeof(HL7_AN))]
        [Pos(15)]
        public virtual List<string> EventDescriptionFromPatient_15 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Description from Practitioner
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 600)]
        [DataElement("01088", typeof(HL7_AN))]
        [Pos(16)]
        public virtual List<string> EventDescriptionFromPractitioner_16 
        {
            get { return _stringList6; }
            set { _stringList6 = value; }
        }

        private List<string> _stringList6 { get; set; }
        public virtual string StringList6
        {
            get
            {
                if (_stringList6 != null)
                    return string.Join("^", _stringList6);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList6 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Event Description from Autopsy
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 600)]
        [DataElement("01089", typeof(HL7_AN))]
        [Pos(17)]
        public virtual List<string> EventDescriptionFromAutopsy_17 
        {
            get { return _stringList7; }
            set { _stringList7 = value; }
        }

        private List<string> _stringList7 { get; set; }
        public virtual string StringList7
        {
            get
            {
                if (_stringList7 != null)
                    return string.Join("^", _stringList7);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList7 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Cause Of Death
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<AssigningAgencyOrDepartment> CauseOfDeath_18 { get; set; }
        /// <summary>
        // Primary Observer Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<ExtendedPersonName> PrimaryObserverName_19 { get; set; }
        /// <summary>
        // Primary Observer Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<ExtendedAddress> PrimaryObserverAddress_20 { get; set; }
        /// <summary>
        // Primary Observer Telephone
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedTelecommunicationsNumber> PrimaryObserverTelephone_21 { get; set; }
        /// <summary>
        // Primary Observer's Qualification
        /// </summary>
        [DataMember]
        [DataElement("01094", typeof(HL7_ID_242))]
        [Pos(22)]
        public virtual string PrimaryObserversQualification_22 { get; set; }
        /// <summary>
        // Confirmation Provided By
        /// </summary>
        [DataMember]
        [DataElement("01095", typeof(HL7_ID_242))]
        [Pos(23)]
        public virtual string ConfirmationProvidedBy_23 { get; set; }
        /// <summary>
        // Primary Observer Aware Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01096", typeof(HL7_DTM))]
        [Pos(24)]
        public virtual string PrimaryObserverAwareDateTime_24 { get; set; }
        /// <summary>
        // Primary Observer's identity May Be Divulged
        /// </summary>
        [DataMember]
        [DataElement("01097", typeof(HL7_ID_243))]
        [Pos(25)]
        public virtual string PrimaryObserversIdentityMayBeDivulged_25 { get; set; }
    }
    
    /// <summary>
    // Payment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PMT")]
    public class PMT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Payment/Remittance Advice Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier PaymentRemittanceAdviceNumber_01 { get; set; }
        /// <summary>
        // Payment/Remittance Effective Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 26)]
        [DataElement("02019", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string PaymentRemittanceEffectiveDateTime_02 { get; set; }
        /// <summary>
        // Payment/Remittance Expiration Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 26)]
        [DataElement("02020", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string PaymentRemittanceExpirationDateTime_03 { get; set; }
        /// <summary>
        // Payment Method
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual PaymentMethod PaymentMethod_04 { get; set; }
        /// <summary>
        // Payment/Remittance Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 26)]
        [DataElement("02022", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string PaymentRemittanceDateTime_05 { get; set; }
        /// <summary>
        // Payment/Remittance Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual CompositePrice PaymentRemittanceAmount_06 { get; set; }
        /// <summary>
        // Check Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ComprehensiveLocationIdentifier CheckNumber_07 { get; set; }
        /// <summary>
        // Payee Bank Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations PayeeBankIdentification_08 { get; set; }
        /// <summary>
        // Payee Transit Number
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("02026", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string PayeeTransitNumber_09 { get; set; }
        /// <summary>
        // Payee Bank Account ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ExtendedCompositeIDWithCheckDigit PayeeBankAccountID_10 { get; set; }
        /// <summary>
        // Payment Organization
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations PaymentOrganization_11 { get; set; }
        /// <summary>
        // ESR-Code-Line
        /// </summary>
        [DataMember]
        [StringLength(0, 100)]
        [DataElement("02029", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string ESRCodeLine_12 { get; set; }
    }
    
    /// <summary>
    // Procedures
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PR1")]
    public class PR1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - PR1
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00391", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDPR_01 { get; set; }
        [DataMember]
        [DataElement("00392", typeof(ANY))]
        [Pos(2)]
        public virtual string PR102 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ProcedureCode ProcedureCode_03 { get; set; }
        [DataMember]
        [DataElement("00394", typeof(ANY))]
        [Pos(4)]
        public virtual string PR104 { get; set; }
        /// <summary>
        // Procedure Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00395", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string ProcedureDateTime_05 { get; set; }
        /// <summary>
        // Procedure Functional Type
        /// </summary>
        [DataMember]
        [DataElement("00396", typeof(HL7_ID_230))]
        [Pos(6)]
        public virtual string ProcedureFunctionalType_06 { get; set; }
        /// <summary>
        // Procedure Minutes
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00397", typeof(HL7_N))]
        [Pos(7)]
        public virtual string ProcedureMinutes_07 { get; set; }
        [DataMember]
        [DataElement("00398", typeof(ANY))]
        [Pos(8)]
        public virtual string PR108 { get; set; }
        /// <summary>
        // Anesthesia Code
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00399", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string AnesthesiaCode_09 { get; set; }
        /// <summary>
        // Anesthesia Minutes
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00400", typeof(HL7_N))]
        [Pos(10)]
        public virtual string AnesthesiaMinutes_10 { get; set; }
        [DataMember]
        [DataElement("00401", typeof(ANY))]
        [Pos(11)]
        public virtual string PR111 { get; set; }
        [DataMember]
        [DataElement("00402", typeof(ANY))]
        [Pos(12)]
        public virtual string PR112 { get; set; }
        /// <summary>
        // Consent Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ConsentCode ConsentCode_13 { get; set; }
        /// <summary>
        // Procedure Priority
        /// </summary>
        [DataMember]
        [DataElement("00404", typeof(HL7_ID_418))]
        [Pos(14)]
        public virtual string ProcedurePriority_14 { get; set; }
        /// <summary>
        // Associated Diagnosis Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual AssociatedDiagnosisCode AssociatedDiagnosisCode_15 { get; set; }
        /// <summary>
        // Procedure Code Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ProcedureCodeModifier> ProcedureCodeModifier_16 { get; set; }
        /// <summary>
        // Procedure DRG Type
        /// </summary>
        [DataMember]
        [DataElement("01501", typeof(HL7_ID_416))]
        [Pos(17)]
        public virtual string ProcedureDRGType_17 { get; set; }
        /// <summary>
        // Tissue Type Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<TissueTypeCode> TissueTypeCode_18 { get; set; }
        /// <summary>
        // Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ComprehensiveLocationIdentifier ProcedureIdentifier_19 { get; set; }
        /// <summary>
        // Procedure Action Code
        /// </summary>
        [DataMember]
        [DataElement("01849", typeof(HL7_ID_206))]
        [Pos(20)]
        public virtual string ProcedureActionCode_20 { get; set; }
        /// <summary>
        // DRG Procedure Determination Status
        /// </summary>
        [DataMember]
        [DataElement("02177", typeof(HL7_ID_761))]
        [Pos(21)]
        public virtual string DRGProcedureDeterminationStatus_21 { get; set; }
        /// <summary>
        // DRG Procedure Relevance
        /// </summary>
        [DataMember]
        [DataElement("02178", typeof(HL7_ID_763))]
        [Pos(22)]
        public virtual string DRGProcedureRelevance_22 { get; set; }
    }
    
    /// <summary>
    // Practitioner Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRA")]
    public class PRA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - PRA
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment PrimaryKeyValuePRA_01 { get; set; }
        /// <summary>
        // Practitioner Group
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<PractitionerGroup> PractitionerGroup_02 { get; set; }
        /// <summary>
        // Practitioner Category
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 3)]
        [DataElement("00687", typeof(HL7_AN))]
        [Pos(3)]
        public virtual List<string> PractitionerCategory_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Provider Billing
        /// </summary>
        [DataMember]
        [DataElement("00688", typeof(HL7_ID_187))]
        [Pos(4)]
        public virtual string ProviderBilling_04 { get; set; }
        /// <summary>
        // Specialty
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<SpecialtyDescription> Specialty_05 { get; set; }
        /// <summary>
        // Practitioner ID Numbers
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PractitionerLicenseOrOtherIDNumber> PractitionerIDNumbers_06 { get; set; }
        /// <summary>
        // Privileges
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<PractitionerInstitutionalPrivileges> Privileges_07 { get; set; }
        /// <summary>
        // Date Entered Practice
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01296", typeof(HL7_DT))]
        [Pos(8)]
        public virtual string DateEnteredPractice_08 { get; set; }
        /// <summary>
        // Institution
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Institution Institution_09 { get; set; }
        /// <summary>
        // Date Left Practice
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01348", typeof(HL7_DT))]
        [Pos(10)]
        public virtual string DateLeftPractice_10 { get; set; }
        /// <summary>
        // Government Reimbursement Billing Eligibility
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<GovernmentReimbursementBillingEligibility> GovernmentReimbursementBillingEligibility_11 { get; set; }
        /// <summary>
        // Set ID - PRA
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01616", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string SetIDPRA_12 { get; set; }
    }
    
    /// <summary>
    // Problem Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRB")]
    public class PRB
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00816", typeof(HL7_ID_287))]
        [Pos(1)]
        public virtual string ActionCode_01 { get; set; }
        /// <summary>
        // Action Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00817", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string ActionDateTime_02 { get; set; }
        /// <summary>
        // Problem ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment ProblemID_03 { get; set; }
        /// <summary>
        // Problem Instance ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier ProblemInstanceID_04 { get; set; }
        /// <summary>
        // Episode of Care ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier EpisodeOfCareID_05 { get; set; }
        /// <summary>
        // Problem List Priority
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("00841", typeof(HL7_N))]
        [Pos(6)]
        public virtual string ProblemListPriority_06 { get; set; }
        /// <summary>
        // Problem Established Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00842", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string ProblemEstablishedDateTime_07 { get; set; }
        /// <summary>
        // Anticipated Problem Resolution Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00843", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string AnticipatedProblemResolutionDateTime_08 { get; set; }
        /// <summary>
        // Actual Problem Resolution Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00844", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual string ActualProblemResolutionDateTime_09 { get; set; }
        /// <summary>
        // Problem Classification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment ProblemClassification_10 { get; set; }
        /// <summary>
        // Problem Management Discipline
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<AssigningAgencyOrDepartment> ProblemManagementDiscipline_11 { get; set; }
        /// <summary>
        // Problem Persistence
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual AssigningAgencyOrDepartment ProblemPersistence_12 { get; set; }
        /// <summary>
        // Problem Confirmation Status
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual AssigningAgencyOrDepartment ProblemConfirmationStatus_13 { get; set; }
        /// <summary>
        // Problem Life Cycle Status
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningAgencyOrDepartment ProblemLifeCycleStatus_14 { get; set; }
        /// <summary>
        // Problem Life Cycle Status Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00850", typeof(HL7_DTM))]
        [Pos(15)]
        public virtual string ProblemLifeCycleStatusDateTime_15 { get; set; }
        /// <summary>
        // Problem Date of Onset
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00851", typeof(HL7_DTM))]
        [Pos(16)]
        public virtual string ProblemDateOfOnset_16 { get; set; }
        /// <summary>
        // Problem Onset Text
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("00852", typeof(HL7_AN))]
        [Pos(17)]
        public virtual string ProblemOnsetText_17 { get; set; }
        /// <summary>
        // Problem Ranking
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual AssigningAgencyOrDepartment ProblemRanking_18 { get; set; }
        /// <summary>
        // Certainty of Problem
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual AssigningAgencyOrDepartment CertaintyOfProblem_19 { get; set; }
        /// <summary>
        // Probability of Problem (0-1)
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00855", typeof(HL7_N))]
        [Pos(20)]
        public virtual string ProbabilityOfProblem_20 { get; set; }
        /// <summary>
        // Individual Awareness of Problem
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual AssigningAgencyOrDepartment IndividualAwarenessOfProblem_21 { get; set; }
        /// <summary>
        // Problem Prognosis
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual AssigningAgencyOrDepartment ProblemPrognosis_22 { get; set; }
        /// <summary>
        // Individual Awareness of Prognosis
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment IndividualAwarenessOfPrognosis_23 { get; set; }
        /// <summary>
        // Family/Significant Other Awareness of Problem/Prognosis
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("00859", typeof(HL7_AN))]
        [Pos(24)]
        public virtual string FamilySignificantOtherAwarenessOfProblemPrognosis_24 { get; set; }
        /// <summary>
        // Security/Sensitivity
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual AssigningAgencyOrDepartment SecuritySensitivity_25 { get; set; }
        /// <summary>
        // Problem Severity
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual ProblemSeverity ProblemSeverity_26 { get; set; }
        /// <summary>
        // Problem Perspective
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual ProblemPerspective ProblemPerspective_27 { get; set; }
        /// <summary>
        // Mood Code
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual MoodCode MoodCode_28 { get; set; }
    }
    
    /// <summary>
    // Pricing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRC")]
    public class PRC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value-PRC
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PrimaryKeyValueCDM PrimaryKeyValuePRC_01 { get; set; }
        /// <summary>
        // Facility ID-PRC
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<FacilityIDPRC> FacilityIDPRC_02 { get; set; }
        /// <summary>
        // Department
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Department> Department_03 { get; set; }
        /// <summary>
        // Valid Patient Classes
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00967", typeof(HL7_ID_4))]
        [Pos(4)]
        public virtual List<string> ValidPatientClasses_04 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Price
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<CompositePrice> Price_05 { get; set; }
        /// <summary>
        // Formula
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 200)]
        [DataElement("00999", typeof(HL7_AN))]
        [Pos(6)]
        public virtual List<string> Formula_06 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Minimum Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01000", typeof(HL7_N))]
        [Pos(7)]
        public virtual string MinimumQuantity_07 { get; set; }
        /// <summary>
        // Maximum Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01001", typeof(HL7_N))]
        [Pos(8)]
        public virtual string MaximumQuantity_08 { get; set; }
        /// <summary>
        // Minimum Price
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ValueAmount MinimumPrice_09 { get; set; }
        /// <summary>
        // Maximum Price
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ValueAmount MaximumPrice_10 { get; set; }
        /// <summary>
        // Effective Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01004", typeof(HL7_DTM))]
        [Pos(11)]
        public virtual string EffectiveStartDate_11 { get; set; }
        /// <summary>
        // Effective End Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01005", typeof(HL7_DTM))]
        [Pos(12)]
        public virtual string EffectiveEndDate_12 { get; set; }
        /// <summary>
        // Price Override Flag
        /// </summary>
        [DataMember]
        [DataElement("01006", typeof(HL7_ID_268))]
        [Pos(13)]
        public virtual string PriceOverrideFlag_13 { get; set; }
        /// <summary>
        // Billing Category
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<BillingCategory> BillingCategory_14 { get; set; }
        /// <summary>
        // Chargeable Flag
        /// </summary>
        [DataMember]
        [DataElement("01008", typeof(HL7_ID_136))]
        [Pos(15)]
        public virtual string ChargeableFlag_15 { get; set; }
        /// <summary>
        // Active/Inactive Flag
        /// </summary>
        [DataMember]
        [DataElement("00675", typeof(HL7_ID_183))]
        [Pos(16)]
        public virtual string ActiveInactiveFlag_16 { get; set; }
        /// <summary>
        // Cost
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual ValueAmount Cost_17 { get; set; }
        /// <summary>
        // Charge on Indicator
        /// </summary>
        [DataMember]
        [DataElement("01009", typeof(HL7_ID_269))]
        [Pos(18)]
        public virtual string ChargeOnIndicator_18 { get; set; }
    }
    
    /// <summary>
    // Provider Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRD")]
    public class PRD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Provider Role
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(1)]
        public virtual List<ProviderRole> ProviderRole_01 { get; set; }
        /// <summary>
        // Provider Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ExtendedPersonName> ProviderName_02 { get; set; }
        /// <summary>
        // Provider Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedAddress> ProviderAddress_03 { get; set; }
        /// <summary>
        // Provider Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PersonLocation ProviderLocation_04 { get; set; }
        /// <summary>
        // Provider Communication Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedTelecommunicationsNumber> ProviderCommunicationInformation_05 { get; set; }
        /// <summary>
        // Preferred Method of Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ProviderOrganizationMethodOfContact PreferredMethodOfContact_06 { get; set; }
        /// <summary>
        // Provider Identifiers
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<PractitionerLicenseOrOtherIDNumber> ProviderIdentifiers_07 { get; set; }
        /// <summary>
        // Effective Start Date of Provider Role
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01163", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string EffectiveStartDateOfProviderRole_08 { get; set; }
        /// <summary>
        // Effective End Date of Provider Role
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 24)]
        [DataElement("01164", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual List<string> EffectiveEndDateOfProviderRole_09 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Provider Organization Name and Identifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations ProviderOrganizationNameAndIdentifier_10 { get; set; }
        /// <summary>
        // Provider Organization Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedAddress> ProviderOrganizationAddress_11 { get; set; }
        /// <summary>
        // Provider Organization Location Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<PersonLocation> ProviderOrganizationLocationInformation_12 { get; set; }
        /// <summary>
        // Provider Organization Communication Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<ExtendedTelecommunicationsNumber> ProviderOrganizationCommunicationInformation_13 { get; set; }
        /// <summary>
        // Provider Organization Method of Contact
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ProviderOrganizationMethodOfContact ProviderOrganizationMethodOfContact_14 { get; set; }
    }
    
    /// <summary>
    // Product/Service Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSG")]
    public class PSG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Provider Product/Service Group Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ProviderProductServiceGroupNumber_01 { get; set; }
        /// <summary>
        // Payer Product/Service Group Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PayerProductServiceGroupNumber_02 { get; set; }
        /// <summary>
        // Product/Service Group Sequence Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01952", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ProductServiceGroupSequenceNumber_03 { get; set; }
        /// <summary>
        // Adjudicate as Group
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01953", typeof(HL7_ID_136))]
        [Pos(4)]
        public virtual string AdjudicateAsGroup_04 { get; set; }
        /// <summary>
        // Product/Service Group Billed Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual CompositePrice ProductServiceGroupBilledAmount_05 { get; set; }
        /// <summary>
        // Product/Service Group Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 254)]
        [DataElement("02044", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string ProductServiceGroupDescription_06 { get; set; }
    }
    
    /// <summary>
    // Product Summary Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSH")]
    public class PSH
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Report Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 60)]
        [DataElement("01233", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string ReportType_01 { get; set; }
        /// <summary>
        // Report Form Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 60)]
        [DataElement("01297", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string ReportFormIdentifier_02 { get; set; }
        /// <summary>
        // Report Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01235", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string ReportDate_03 { get; set; }
        /// <summary>
        // Report Interval Start Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01236", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string ReportIntervalStartDate_04 { get; set; }
        /// <summary>
        // Report Interval End Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01237", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string ReportIntervalEndDate_05 { get; set; }
        /// <summary>
        // Quantity Manufactured
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Quantity QuantityManufactured_06 { get; set; }
        /// <summary>
        // Quantity Distributed
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Quantity QuantityDistributed_07 { get; set; }
        /// <summary>
        // Quantity Distributed Method
        /// </summary>
        [DataMember]
        [DataElement("01240", typeof(HL7_ID_329))]
        [Pos(8)]
        public virtual string QuantityDistributedMethod_08 { get; set; }
        /// <summary>
        // Quantity Distributed Comment
        /// </summary>
        [DataMember]
        [StringLength(0, 600)]
        [DataElement("01241", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string QuantityDistributedComment_09 { get; set; }
        /// <summary>
        // Quantity in Use
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual Quantity QuantityInUse_10 { get; set; }
        /// <summary>
        // Quantity in Use Method
        /// </summary>
        [DataMember]
        [DataElement("01243", typeof(HL7_ID_329))]
        [Pos(11)]
        public virtual string QuantityInUseMethod_11 { get; set; }
        /// <summary>
        // Quantity in Use Comment
        /// </summary>
        [DataMember]
        [StringLength(0, 600)]
        [DataElement("01244", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string QuantityInUseComment_12 { get; set; }
        /// <summary>
        // Number of Product Experience Reports Filed by Facility
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [StringLength(0, 16)]
        [DataElement("01245", typeof(HL7_N))]
        [Pos(13)]
        public virtual List<string> NumberOfProductExperienceReportsFiledByFacility_13 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Number of Product Experience Reports Filed by Distributor
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [StringLength(0, 16)]
        [DataElement("01246", typeof(HL7_N))]
        [Pos(14)]
        public virtual List<string> NumberOfProductExperienceReportsFiledByDistributor_14 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Product/Service Line Item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSL")]
    public class PSL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Provider Product/Service Line Item Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ProviderProductServiceLineItemNumber_01 { get; set; }
        /// <summary>
        // Payer Product/Service Line Item Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PayerProductServiceLineItemNumber_02 { get; set; }
        /// <summary>
        // Product/Service Line Item Sequence Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01957", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ProductServiceLineItemSequenceNumber_03 { get; set; }
        /// <summary>
        // Provider Tracking ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier ProviderTrackingID_04 { get; set; }
        /// <summary>
        // Payer Tracking ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier PayerTrackingID_05 { get; set; }
        /// <summary>
        // Product/Service Line Item Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual ProductServiceLineItemStatus ProductServiceLineItemStatus_06 { get; set; }
        /// <summary>
        // Product/Service Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual RelatedProductServiceCodeIndicator ProductServiceCode_07 { get; set; }
        /// <summary>
        // Product/Service Code Modifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<ProductServiceCodeModifier> ProductServiceCodeModifier_08 { get; set; }
        /// <summary>
        // Product/Service Code Description
        /// </summary>
        [DataMember]
        [StringLength(0, 80)]
        [DataElement("01963", typeof(HL7_AN))]
        [Pos(9)]
        public virtual string ProductServiceCodeDescription_09 { get; set; }
        /// <summary>
        // Product/Service Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01964", typeof(HL7_DTM))]
        [Pos(10)]
        public virtual string ProductServiceEffectiveDate_10 { get; set; }
        /// <summary>
        // Product/Service Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01965", typeof(HL7_DTM))]
        [Pos(11)]
        public virtual string ProductServiceExpirationDate_11 { get; set; }
        /// <summary>
        // Product/Service Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual AdjustmentQuantity ProductServiceQuantity_12 { get; set; }
        /// <summary>
        // Product/Service Unit Cost
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CompositePrice ProductServiceUnitCost_13 { get; set; }
        /// <summary>
        // Number of Items per Unit
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01968", typeof(HL7_N))]
        [Pos(14)]
        public virtual string NumberOfItemsPerUnit_14 { get; set; }
        /// <summary>
        // Product/Service Gross Amount
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual CompositePrice ProductServiceGrossAmount_15 { get; set; }
        /// <summary>
        // Product/Service Billed Amount
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual CompositePrice ProductServiceBilledAmount_16 { get; set; }
        /// <summary>
        // Product/Service Clarification Code Type
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [DataElement("01971", typeof(HL7_ID_561))]
        [Pos(17)]
        public virtual List<string> ProductServiceClarificationCodeType_17 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Product/Service Clarification Code Value
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [StringLength(0, 40)]
        [DataElement("01972", typeof(HL7_AN))]
        [Pos(18)]
        public virtual List<string> ProductServiceClarificationCodeValue_18 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Health Document Reference Identifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(19)]
        public virtual List<ComprehensiveLocationIdentifier> HealthDocumentReferenceIdentifier_19 { get; set; }
        /// <summary>
        // Processing Consideration Code
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [DataElement("01974", typeof(HL7_ID_562))]
        [Pos(20)]
        public virtual List<string> ProcessingConsiderationCode_20 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Restricted Disclosure Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01975", typeof(HL7_ID_532))]
        [Pos(21)]
        public virtual string RestrictedDisclosureIndicator_21 { get; set; }
        /// <summary>
        // Related Product/Service Code Indicator
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual RelatedProductServiceCodeIndicator RelatedProductServiceCodeIndicator_22 { get; set; }
        /// <summary>
        // Product/Service Amount for Physician
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual CompositePrice ProductServiceAmountForPhysician_23 { get; set; }
        /// <summary>
        // Product/Service Cost Factor
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01978", typeof(HL7_N))]
        [Pos(24)]
        public virtual string ProductServiceCostFactor_24 { get; set; }
        /// <summary>
        // Cost Center
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual ExtendedCompositeIDWithCheckDigit CostCenter_25 { get; set; }
        /// <summary>
        // Billing Period
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual NameValidityRange BillingPeriod_26 { get; set; }
        /// <summary>
        // Days without Billing
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01981", typeof(HL7_N))]
        [Pos(27)]
        public virtual string DaysWithoutBilling_27 { get; set; }
        /// <summary>
        // Session-No
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01982", typeof(HL7_N))]
        [Pos(28)]
        public virtual string SessionNo_28 { get; set; }
        /// <summary>
        // Executing Physician ID
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual ExtendedCompositeIDNumberAndName ExecutingPhysicianID_29 { get; set; }
        /// <summary>
        // Responsible Physician ID
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual ExtendedCompositeIDNumberAndName ResponsiblePhysicianID_30 { get; set; }
        /// <summary>
        // Role Executing Physician
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual RoleExecutingPhysician RoleExecutingPhysician_31 { get; set; }
        /// <summary>
        // Medical Role Executing Physician
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual MedicalRoleExecutingPhysician MedicalRoleExecutingPhysician_32 { get; set; }
        /// <summary>
        // Side of body
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual SideOfBody SideOfBody_33 { get; set; }
        /// <summary>
        // Number of TP's PP
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("01988", typeof(HL7_N))]
        [Pos(34)]
        public virtual string NumberOfTPsPP_34 { get; set; }
        /// <summary>
        // TP-Value PP
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual CompositePrice TPValuePP_35 { get; set; }
        /// <summary>
        // Internal Scaling Factor PP
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01990", typeof(HL7_N))]
        [Pos(36)]
        public virtual string InternalScalingFactorPP_36 { get; set; }
        /// <summary>
        // External Scaling Factor PP
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01991", typeof(HL7_N))]
        [Pos(37)]
        public virtual string ExternalScalingFactorPP_37 { get; set; }
        /// <summary>
        // Amount PP
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual CompositePrice AmountPP_38 { get; set; }
        /// <summary>
        // Number of TP's Technical Part
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("01993", typeof(HL7_N))]
        [Pos(39)]
        public virtual string NumberOfTPsTechnicalPart_39 { get; set; }
        /// <summary>
        // TP-Value Technical Part
        /// </summary>
        [DataMember]
        [Pos(40)]
        public virtual CompositePrice TPValueTechnicalPart_40 { get; set; }
        /// <summary>
        // Internal Scaling Factor Technical Part
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01995", typeof(HL7_N))]
        [Pos(41)]
        public virtual string InternalScalingFactorTechnicalPart_41 { get; set; }
        /// <summary>
        // External Scaling Factor Technical Part
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01996", typeof(HL7_N))]
        [Pos(42)]
        public virtual string ExternalScalingFactorTechnicalPart_42 { get; set; }
        /// <summary>
        // Amount Technical Part
        /// </summary>
        [DataMember]
        [Pos(43)]
        public virtual CompositePrice AmountTechnicalPart_43 { get; set; }
        /// <summary>
        // Total Amount Professional Part + Technical Part
        /// </summary>
        [DataMember]
        [Pos(44)]
        public virtual CompositePrice TotalAmountProfessionalPartTechnicalPart_44 { get; set; }
        /// <summary>
        // VAT-Rate
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("01999", typeof(HL7_N))]
        [Pos(45)]
        public virtual string VATRate_45 { get; set; }
        /// <summary>
        // Main-Service
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("02000", typeof(HL7_AN))]
        [Pos(46)]
        public virtual string MainService_46 { get; set; }
        /// <summary>
        // Validation
        /// </summary>
        [DataMember]
        [DataElement("02001", typeof(HL7_ID_136))]
        [Pos(47)]
        public virtual string Validation_47 { get; set; }
        /// <summary>
        // Comment
        /// </summary>
        [DataMember]
        [StringLength(0, 255)]
        [DataElement("02002", typeof(HL7_AN))]
        [Pos(48)]
        public virtual string Comment_48 { get; set; }
    }
    
    /// <summary>
    // Product/Service Section
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSS")]
    public class PSS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Provider Product/Service Section Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ProviderProductServiceSectionNumber_01 { get; set; }
        /// <summary>
        // Payer Product/Service Section Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier PayerProductServiceSectionNumber_02 { get; set; }
        /// <summary>
        // Product/Service Section Sequence Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01948", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ProductServiceSectionSequenceNumber_03 { get; set; }
        /// <summary>
        // Billed Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual CompositePrice BilledAmount_04 { get; set; }
        /// <summary>
        // Section Description or Heading
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 254)]
        [DataElement("02043", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string SectionDescriptionOrHeading_05 { get; set; }
    }
    
    /// <summary>
    // Pathway
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PTH")]
    public class PTH
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00816", typeof(HL7_ID_287))]
        [Pos(1)]
        public virtual string ActionCode_01 { get; set; }
        /// <summary>
        // Pathway ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment PathwayID_02 { get; set; }
        /// <summary>
        // Pathway Instance ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier PathwayInstanceID_03 { get; set; }
        /// <summary>
        // Pathway Established Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01209", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string PathwayEstablishedDateTime_04 { get; set; }
        /// <summary>
        // Pathway Life Cycle Status
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment PathwayLifeCycleStatus_05 { get; set; }
        /// <summary>
        // Change Pathway Life Cycle Status Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01211", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string ChangePathwayLifeCycleStatusDateTime_06 { get; set; }
        /// <summary>
        // Mood Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MoodCode MoodCode_07 { get; set; }
    }
    
    /// <summary>
    // Patient Visit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PV1")]
    public class PV1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - PV1
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00131", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDPV_01 { get; set; }
        /// <summary>
        // Patient Class
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00132", typeof(HL7_ID_4))]
        [Pos(2)]
        public virtual string PatientClass_02 { get; set; }
        /// <summary>
        // Assigned Patient Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PersonLocation AssignedPatientLocation_03 { get; set; }
        /// <summary>
        // Admission Type
        /// </summary>
        [DataMember]
        [DataElement("00134", typeof(HL7_ID_7))]
        [Pos(4)]
        public virtual string AdmissionType_04 { get; set; }
        /// <summary>
        // Preadmit Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ExtendedCompositeIDWithCheckDigit PreadmitNumber_05 { get; set; }
        /// <summary>
        // Prior Patient Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PersonLocation PriorPatientLocation_06 { get; set; }
        /// <summary>
        // Attending Doctor
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DischargeCareProvider> AttendingDoctor_07 { get; set; }
        /// <summary>
        // Referring Doctor
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<DischargeCareProvider> ReferringDoctor_08 { get; set; }
        /// <summary>
        // Consulting Doctor
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<DischargeCareProvider> ConsultingDoctor_09 { get; set; }
        /// <summary>
        // Hospital Service
        /// </summary>
        [DataMember]
        [DataElement("00140", typeof(HL7_ID_69))]
        [Pos(10)]
        public virtual string HospitalService_10 { get; set; }
        /// <summary>
        // Temporary Location
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual PersonLocation TemporaryLocation_11 { get; set; }
        /// <summary>
        // Preadmit Test Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00142", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string PreadmitTestIndicator_12 { get; set; }
        /// <summary>
        // Re-admission Indicator
        /// </summary>
        [DataMember]
        [DataElement("00143", typeof(HL7_ID_92))]
        [Pos(13)]
        public virtual string ReadmissionIndicator_13 { get; set; }
        /// <summary>
        // Admit Source
        /// </summary>
        [DataMember]
        [DataElement("00144", typeof(HL7_ID_23))]
        [Pos(14)]
        public virtual string AdmitSource_14 { get; set; }
        /// <summary>
        // Ambulatory Status
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00145", typeof(HL7_ID_9))]
        [Pos(15)]
        public virtual List<string> AmbulatoryStatus_15 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // VIP Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00146", typeof(HL7_AN))]
        [Pos(16)]
        public virtual string VIPIndicator_16 { get; set; }
        /// <summary>
        // Admitting Doctor
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<DischargeCareProvider> AdmittingDoctor_17 { get; set; }
        /// <summary>
        // Patient Type
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00148", typeof(HL7_AN))]
        [Pos(18)]
        public virtual string PatientType_18 { get; set; }
        /// <summary>
        // Visit Number
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual ExtendedCompositeIDWithCheckDigit VisitNumber_19 { get; set; }
        /// <summary>
        // Financial Class
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<FinancialClass> FinancialClass_20 { get; set; }
        /// <summary>
        // Charge Price Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00151", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string ChargePriceIndicator_21 { get; set; }
        /// <summary>
        // Courtesy Code
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00152", typeof(HL7_AN))]
        [Pos(22)]
        public virtual string CourtesyCode_22 { get; set; }
        /// <summary>
        // Credit Rating
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00153", typeof(HL7_AN))]
        [Pos(23)]
        public virtual string CreditRating_23 { get; set; }
        /// <summary>
        // Contract Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 2)]
        [DataElement("00154", typeof(HL7_AN))]
        [Pos(24)]
        public virtual List<string> ContractCode_24 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Contract Effective Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 8)]
        [DataElement("00155", typeof(HL7_DT))]
        [Pos(25)]
        public virtual List<string> ContractEffectiveDate_25 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Contract Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 12)]
        [DataElement("00156", typeof(HL7_N))]
        [Pos(26)]
        public virtual List<string> ContractAmount_26 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Contract Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 3)]
        [DataElement("00157", typeof(HL7_N))]
        [Pos(27)]
        public virtual List<string> ContractPeriod_27 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Interest Code
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00158", typeof(HL7_AN))]
        [Pos(28)]
        public virtual string InterestCode_28 { get; set; }
        /// <summary>
        // Transfer to Bad Debt Code
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00159", typeof(HL7_AN))]
        [Pos(29)]
        public virtual string TransferToBadDebtCode_29 { get; set; }
        /// <summary>
        // Transfer to Bad Debt Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00160", typeof(HL7_DT))]
        [Pos(30)]
        public virtual string TransferToBadDebtDate_30 { get; set; }
        /// <summary>
        // Bad Debt Agency Code
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("00161", typeof(HL7_AN))]
        [Pos(31)]
        public virtual string BadDebtAgencyCode_31 { get; set; }
        /// <summary>
        // Bad Debt Transfer Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00162", typeof(HL7_N))]
        [Pos(32)]
        public virtual string BadDebtTransferAmount_32 { get; set; }
        /// <summary>
        // Bad Debt Recovery Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00163", typeof(HL7_N))]
        [Pos(33)]
        public virtual string BadDebtRecoveryAmount_33 { get; set; }
        /// <summary>
        // Delete Account Indicator
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("00164", typeof(HL7_AN))]
        [Pos(34)]
        public virtual string DeleteAccountIndicator_34 { get; set; }
        /// <summary>
        // Delete Account Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00165", typeof(HL7_DT))]
        [Pos(35)]
        public virtual string DeleteAccountDate_35 { get; set; }
        /// <summary>
        // Discharge Disposition
        /// </summary>
        [DataMember]
        [DataElement("00166", typeof(HL7_ID_112))]
        [Pos(36)]
        public virtual string DischargeDisposition_36 { get; set; }
        /// <summary>
        // Discharged to Location
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual DischargeToLocationAndDate DischargedToLocation_37 { get; set; }
        /// <summary>
        // Diet Type
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual DietType DietType_38 { get; set; }
        /// <summary>
        // Servicing Facility
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00169", typeof(HL7_AN))]
        [Pos(39)]
        public virtual string ServicingFacility_39 { get; set; }
        /// <summary>
        // Bed Status
        /// </summary>
        [DataMember]
        [DataElement("00170", typeof(HL7_ID_116))]
        [Pos(40)]
        public virtual string BedStatus_40 { get; set; }
        /// <summary>
        // Account Status
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00171", typeof(HL7_AN))]
        [Pos(41)]
        public virtual string AccountStatus_41 { get; set; }
        /// <summary>
        // Pending Location
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual PersonLocation PendingLocation_42 { get; set; }
        /// <summary>
        // Prior Temporary Location
        /// </summary>
        [DataMember]
        [Pos(43)]
        public virtual PersonLocation PriorTemporaryLocation_43 { get; set; }
        /// <summary>
        // Admit Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00174", typeof(HL7_DTM))]
        [Pos(44)]
        public virtual string AdmitDateTime_44 { get; set; }
        /// <summary>
        // Discharge Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00175", typeof(HL7_DTM))]
        [Pos(45)]
        public virtual string DischargeDateTime_45 { get; set; }
        /// <summary>
        // Current Patient Balance
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00176", typeof(HL7_N))]
        [Pos(46)]
        public virtual string CurrentPatientBalance_46 { get; set; }
        /// <summary>
        // Total Charges
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00177", typeof(HL7_N))]
        [Pos(47)]
        public virtual string TotalCharges_47 { get; set; }
        /// <summary>
        // Total Adjustments
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00178", typeof(HL7_N))]
        [Pos(48)]
        public virtual string TotalAdjustments_48 { get; set; }
        /// <summary>
        // Total Payments
        /// </summary>
        [DataMember]
        [StringLength(0, 12)]
        [DataElement("00179", typeof(HL7_N))]
        [Pos(49)]
        public virtual string TotalPayments_49 { get; set; }
        /// <summary>
        // Alternate Visit ID
        /// </summary>
        [DataMember]
        [Pos(50)]
        public virtual AlternateVisitID AlternateVisitID_50 { get; set; }
        /// <summary>
        // Visit Indicator
        /// </summary>
        [DataMember]
        [DataElement("01226", typeof(HL7_ID_326))]
        [Pos(51)]
        public virtual string VisitIndicator_51 { get; set; }
        /// <summary>
        // Other Healthcare Provider
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(52)]
        public virtual List<DischargeCareProvider> OtherHealthcareProvider_52 { get; set; }
    }
    
    /// <summary>
    // Patient Visit - Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PV2")]
    public class PV2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Prior Pending Location
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual PersonLocation PriorPendingLocation_01 { get; set; }
        /// <summary>
        // Accommodation Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AccommodationType AccommodationCode_02 { get; set; }
        /// <summary>
        // Admit Reason
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment AdmitReason_03 { get; set; }
        /// <summary>
        // Transfer Reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment TransferReason_04 { get; set; }
        /// <summary>
        // Patient Valuables
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 25)]
        [DataElement("00185", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> PatientValuables_05 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Patient Valuables Location
        /// </summary>
        [DataMember]
        [StringLength(0, 25)]
        [DataElement("00186", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string PatientValuablesLocation_06 { get; set; }
        /// <summary>
        // Visit User Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00187", typeof(HL7_ID_130))]
        [Pos(7)]
        public virtual List<string> VisitUserCode_07 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Expected Admit Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00188", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string ExpectedAdmitDateTime_08 { get; set; }
        /// <summary>
        // Expected Discharge Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00189", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual string ExpectedDischargeDateTime_09 { get; set; }
        /// <summary>
        // Estimated Length of Inpatient Stay
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00711", typeof(HL7_N))]
        [Pos(10)]
        public virtual string EstimatedLengthOfInpatientStay_10 { get; set; }
        /// <summary>
        // Actual Length of Inpatient Stay
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00712", typeof(HL7_N))]
        [Pos(11)]
        public virtual string ActualLengthOfInpatientStay_11 { get; set; }
        /// <summary>
        // Visit Description
        /// </summary>
        [DataMember]
        [StringLength(0, 50)]
        [DataElement("00713", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string VisitDescription_12 { get; set; }
        /// <summary>
        // Referral Source Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<ExtendedCompositeIDNumberAndName> ReferralSourceCode_13 { get; set; }
        /// <summary>
        // Previous Service Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00715", typeof(HL7_DT))]
        [Pos(14)]
        public virtual string PreviousServiceDate_14 { get; set; }
        /// <summary>
        // Employment Illness Related Indicator
        /// </summary>
        [DataMember]
        [DataElement("00716", typeof(HL7_ID_136))]
        [Pos(15)]
        public virtual string EmploymentIllnessRelatedIndicator_15 { get; set; }
        /// <summary>
        // Purge Status Code
        /// </summary>
        [DataMember]
        [DataElement("00717", typeof(HL7_ID_213))]
        [Pos(16)]
        public virtual string PurgeStatusCode_16 { get; set; }
        /// <summary>
        // Purge Status Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00718", typeof(HL7_DT))]
        [Pos(17)]
        public virtual string PurgeStatusDate_17 { get; set; }
        /// <summary>
        // Special Program Code
        /// </summary>
        [DataMember]
        [DataElement("00719", typeof(HL7_ID_214))]
        [Pos(18)]
        public virtual string SpecialProgramCode_18 { get; set; }
        /// <summary>
        // Retention Indicator
        /// </summary>
        [DataMember]
        [DataElement("00720", typeof(HL7_ID_136))]
        [Pos(19)]
        public virtual string RetentionIndicator_19 { get; set; }
        /// <summary>
        // Expected Number of Insurance Plans
        /// </summary>
        [DataMember]
        [StringLength(0, 1)]
        [DataElement("00721", typeof(HL7_N))]
        [Pos(20)]
        public virtual string ExpectedNumberOfInsurancePlans_20 { get; set; }
        /// <summary>
        // Visit Publicity Code
        /// </summary>
        [DataMember]
        [DataElement("00722", typeof(HL7_ID_215))]
        [Pos(21)]
        public virtual string VisitPublicityCode_21 { get; set; }
        /// <summary>
        // Visit Protection Indicator
        /// </summary>
        [DataMember]
        [DataElement("00723", typeof(HL7_ID_136))]
        [Pos(22)]
        public virtual string VisitProtectionIndicator_22 { get; set; }
        /// <summary>
        // Clinic Organization Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(23)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> ClinicOrganizationName_23 { get; set; }
        /// <summary>
        // Patient Status Code
        /// </summary>
        [DataMember]
        [DataElement("00725", typeof(HL7_ID_216))]
        [Pos(24)]
        public virtual string PatientStatusCode_24 { get; set; }
        /// <summary>
        // Visit Priority Code
        /// </summary>
        [DataMember]
        [DataElement("00726", typeof(HL7_ID_217))]
        [Pos(25)]
        public virtual string VisitPriorityCode_25 { get; set; }
        /// <summary>
        // Previous Treatment Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00727", typeof(HL7_DT))]
        [Pos(26)]
        public virtual string PreviousTreatmentDate_26 { get; set; }
        /// <summary>
        // Expected Discharge Disposition
        /// </summary>
        [DataMember]
        [DataElement("00728", typeof(HL7_ID_112))]
        [Pos(27)]
        public virtual string ExpectedDischargeDisposition_27 { get; set; }
        /// <summary>
        // Signature on File Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00729", typeof(HL7_DT))]
        [Pos(28)]
        public virtual string SignatureOnFileDate_28 { get; set; }
        /// <summary>
        // First Similar Illness Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00730", typeof(HL7_DT))]
        [Pos(29)]
        public virtual string FirstSimilarIllnessDate_29 { get; set; }
        /// <summary>
        // Patient Charge Adjustment Code
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual GuarantorChargeAdjustmentCode PatientChargeAdjustmentCode_30 { get; set; }
        /// <summary>
        // Recurring Service Code
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00732", typeof(HL7_AN))]
        [Pos(31)]
        public virtual string RecurringServiceCode_31 { get; set; }
        /// <summary>
        // Billing Media Code
        /// </summary>
        [DataMember]
        [DataElement("00733", typeof(HL7_ID_136))]
        [Pos(32)]
        public virtual string BillingMediaCode_32 { get; set; }
        /// <summary>
        // Expected Surgery Date and Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00734", typeof(HL7_DTM))]
        [Pos(33)]
        public virtual string ExpectedSurgeryDateAndTime_33 { get; set; }
        /// <summary>
        // Military Partnership Code
        /// </summary>
        [DataMember]
        [DataElement("00735", typeof(HL7_ID_136))]
        [Pos(34)]
        public virtual string MilitaryPartnershipCode_34 { get; set; }
        /// <summary>
        // Military Non-Availability Code
        /// </summary>
        [DataMember]
        [DataElement("00736", typeof(HL7_ID_136))]
        [Pos(35)]
        public virtual string MilitaryNonAvailabilityCode_35 { get; set; }
        /// <summary>
        // Newborn Baby Indicator
        /// </summary>
        [DataMember]
        [DataElement("00737", typeof(HL7_ID_136))]
        [Pos(36)]
        public virtual string NewbornBabyIndicator_36 { get; set; }
        /// <summary>
        // Baby Detained Indicator
        /// </summary>
        [DataMember]
        [DataElement("00738", typeof(HL7_ID_136))]
        [Pos(37)]
        public virtual string BabyDetainedIndicator_37 { get; set; }
        /// <summary>
        // Mode of Arrival Code
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual ModeOfArrivalCode ModeOfArrivalCode_38 { get; set; }
        /// <summary>
        // Recreational Drug Use Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(39)]
        public virtual List<RecreationalDrugUseCode> RecreationalDrugUseCode_39 { get; set; }
        /// <summary>
        // Admission Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(40)]
        public virtual AdmissionLevelOfCareCode AdmissionLevelOfCareCode_40 { get; set; }
        /// <summary>
        // Precaution Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(41)]
        public virtual List<PrecautionCode> PrecautionCode_41 { get; set; }
        /// <summary>
        // Patient Condition Code
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual PatientConditionCode PatientConditionCode_42 { get; set; }
        /// <summary>
        // Living Will Code
        /// </summary>
        [DataMember]
        [DataElement("00759", typeof(HL7_ID_315))]
        [Pos(43)]
        public virtual string LivingWillCode_43 { get; set; }
        /// <summary>
        // Organ Donor Code
        /// </summary>
        [DataMember]
        [DataElement("00760", typeof(HL7_ID_316))]
        [Pos(44)]
        public virtual string OrganDonorCode_44 { get; set; }
        /// <summary>
        // Advance Directive Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(45)]
        public virtual List<AdvanceDirectiveCode> AdvanceDirectiveCode_45 { get; set; }
        /// <summary>
        // Patient Status Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01549", typeof(HL7_DT))]
        [Pos(46)]
        public virtual string PatientStatusEffectiveDate_46 { get; set; }
        /// <summary>
        // Expected LOA Return Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01550", typeof(HL7_DTM))]
        [Pos(47)]
        public virtual string ExpectedLOAReturnDateTime_47 { get; set; }
        /// <summary>
        // Expected Pre-admission Testing Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01841", typeof(HL7_DTM))]
        [Pos(48)]
        public virtual string ExpectedPreadmissionTestingDateTime_48 { get; set; }
        /// <summary>
        // Notify Clergy Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01842", typeof(HL7_ID_534))]
        [Pos(49)]
        public virtual List<string> NotifyClergyCode_49 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Advance Directive Last Verified Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("02141", typeof(HL7_DT))]
        [Pos(50)]
        public virtual string AdvanceDirectiveLastVerifiedDate_50 { get; set; }
    }
    
    /// <summary>
    // Payee Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PYE")]
    public class PYE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - PYE
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01939", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDPYE_01 { get; set; }
        /// <summary>
        // Payee Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("01940", typeof(HL7_ID_557))]
        [Pos(2)]
        public virtual string PayeeType_02 { get; set; }
        /// <summary>
        // Payee Relationship to Invoice (Patient)
        /// </summary>
        [DataMember]
        [DataElement("01941", typeof(HL7_ID_558))]
        [Pos(3)]
        public virtual string PayeeRelationshipToInvoice_03 { get; set; }
        /// <summary>
        // Payee Identification List
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<ExtendedCompositeNameAndIDNumberForOrganizations> PayeeIdentificationList_04 { get; set; }
        /// <summary>
        // Payee Person Name
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(5)]
        public virtual List<ExtendedPersonName> PayeePersonName_05 { get; set; }
        /// <summary>
        // Payee Address
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<ExtendedAddress> PayeeAddress_06 { get; set; }
        /// <summary>
        // Payment Method
        /// </summary>
        [DataMember]
        [DataElement("01945", typeof(HL7_ID_570))]
        [Pos(7)]
        public virtual string PaymentMethod_07 { get; set; }
    }
    
    /// <summary>
    // Query Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QAK")]
    public class QAK
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Query Tag
        /// </summary>
        [DataMember]
        [StringLength(0, 32)]
        [DataElement("00696", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string QueryTag_01 { get; set; }
        /// <summary>
        // Query Response Status
        /// </summary>
        [DataMember]
        [DataElement("00708", typeof(HL7_ID_208))]
        [Pos(2)]
        public virtual string QueryResponseStatus_02 { get; set; }
        /// <summary>
        // Message Query Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual MessageQueryName MessageQueryName_03 { get; set; }
        /// <summary>
        // Hit Count Total
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01434", typeof(HL7_N))]
        [Pos(4)]
        public virtual string HitCountTotal_04 { get; set; }
        /// <summary>
        // This payload
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01622", typeof(HL7_N))]
        [Pos(5)]
        public virtual string ThisPayload_05 { get; set; }
        /// <summary>
        // Hits remaining
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01623", typeof(HL7_N))]
        [Pos(6)]
        public virtual string HitsRemaining_06 { get; set; }
    }
    
    /// <summary>
    // Query Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QID")]
    public class QID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Query Tag
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 32)]
        [DataElement("00696", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string QueryTag_01 { get; set; }
        /// <summary>
        // Message Query Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual MessageQueryName MessageQueryName_02 { get; set; }
    }
    
    /// <summary>
    // Query Parameter Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QPD")]
    public class QPD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Message Query Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MessageQueryName MessageQueryName_01 { get; set; }
        /// <summary>
        // Query Tag
        /// </summary>
        [DataMember]
        [StringLength(0, 32)]
        [DataElement("00696", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string QueryTag_02 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [DataElement("01435", typeof(ANY))]
        [Pos(3)]
        public virtual List<string> QPD03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Original-Style Query Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QRD")]
    public class QRD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Query Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00025", typeof(HL7_DTM))]
        [Pos(1)]
        public virtual string QueryDateTime_01 { get; set; }
        /// <summary>
        // Query Format Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00026", typeof(HL7_ID_106))]
        [Pos(2)]
        public virtual string QueryFormatCode_02 { get; set; }
        /// <summary>
        // Query Priority
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00027", typeof(HL7_ID_91))]
        [Pos(3)]
        public virtual string QueryPriority_03 { get; set; }
        /// <summary>
        // Query ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 10)]
        [DataElement("00028", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string QueryID_04 { get; set; }
        /// <summary>
        // Deferred Response Type
        /// </summary>
        [DataMember]
        [DataElement("00029", typeof(HL7_ID_107))]
        [Pos(5)]
        public virtual string DeferredResponseType_05 { get; set; }
        /// <summary>
        // Deferred Response Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00030", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string DeferredResponseDateTime_06 { get; set; }
        /// <summary>
        // Quantity Limited Request
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual QuantityLimitedRequest QuantityLimitedRequest_07 { get; set; }
        /// <summary>
        // Who Subject Filter
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<ExtendedCompositeIDNumberAndName> WhoSubjectFilter_08 { get; set; }
        /// <summary>
        // What Subject Filter
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<RUWhatSubjectDefinition> WhatSubjectFilter_09 { get; set; }
        /// <summary>
        // What Department Data Code
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<AssigningAgencyOrDepartment> WhatDepartmentDataCode_10 { get; set; }
        /// <summary>
        // What Data Code Value Qual.
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ValueRange> WhatDataCodeValueQual_11 { get; set; }
        /// <summary>
        // Query Results Level
        /// </summary>
        [DataMember]
        [DataElement("00036", typeof(HL7_ID_108))]
        [Pos(12)]
        public virtual string QueryResultsLevel_12 { get; set; }
    }
    
    /// <summary>
    // Original style query filter
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QRF")]
    public class QRF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Where Subject Filter
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("00037", typeof(HL7_AN))]
        [Pos(1)]
        public virtual List<string> WhereSubjectFilter_01 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // When Data Start Date/Time
        /// </summary>
        [DataMember]
        [DataElement("00038", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string WhenDataStartDateTime_02 { get; set; }
        /// <summary>
        // When Data End Date/Time
        /// </summary>
        [DataMember]
        [DataElement("00039", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string WhenDataEndDateTime_03 { get; set; }
        /// <summary>
        // What User Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 60)]
        [DataElement("00040", typeof(HL7_AN))]
        [Pos(4)]
        public virtual List<string> WhatUserQualifier_04 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Other QRY Subject Filter
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 60)]
        [DataElement("00041", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> OtherQRYSubjectFilter_05 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Which Date/Time Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00042", typeof(HL7_ID_156))]
        [Pos(6)]
        public virtual List<string> WhichDateTimeQualifier_06 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Which Date/Time Status Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00043", typeof(HL7_ID_157))]
        [Pos(7)]
        public virtual List<string> WhichDateTimeStatusQualifier_07 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Date/Time Selection Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00044", typeof(HL7_ID_158))]
        [Pos(8)]
        public virtual List<string> DateTimeSelectionQualifier_08 
        {
            get { return _stringList6; }
            set { _stringList6 = value; }
        }

        private List<string> _stringList6 { get; set; }
        public virtual string StringList6
        {
            get
            {
                if (_stringList6 != null)
                    return string.Join("^", _stringList6);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList6 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // When Quantity/Timing Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Timingquantity WhenQuantityTimingQualifier_09 { get; set; }
        /// <summary>
        // Search Confidence Threshold
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01442", typeof(HL7_N))]
        [Pos(10)]
        public virtual string SearchConfidenceThreshold_10 { get; set; }
    }
    
    /// <summary>
    // Query Response Instance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QRI")]
    public class QRI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Candidate Confidence
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01436", typeof(HL7_N))]
        [Pos(1)]
        public virtual string CandidateConfidence_01 { get; set; }
        /// <summary>
        // Match Reason Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01437", typeof(HL7_ID_392))]
        [Pos(2)]
        public virtual List<string> MatchReasonCode_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Algorithm Descriptor
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AlgorithmDescriptor AlgorithmDescriptor_03 { get; set; }
    }
    
    /// <summary>
    // Response Control Parameter
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCP")]
    public class RCP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Query Priority
        /// </summary>
        [DataMember]
        [DataElement("00027", typeof(HL7_ID_91))]
        [Pos(1)]
        public virtual string QueryPriority_01 { get; set; }
        /// <summary>
        // Quantity Limited Request
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QuantityLimitedRequest QuantityLimitedRequest_02 { get; set; }
        /// <summary>
        // Response Modality
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ResponseModality ResponseModality_03 { get; set; }
        /// <summary>
        // Execution and Delivery Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01441", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string ExecutionAndDeliveryTime_04 { get; set; }
        /// <summary>
        // Modify Indicator
        /// </summary>
        [DataMember]
        [DataElement("01443", typeof(HL7_ID_395))]
        [Pos(5)]
        public virtual string ModifyIndicator_05 { get; set; }
        /// <summary>
        // Sort-by Field
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<SortOrder> SortbyField_06 { get; set; }
        /// <summary>
        // Segment group inclusion
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("01594", typeof(HL7_ID_391))]
        [Pos(7)]
        public virtual List<string> SegmentGroupInclusion_07 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Table Row Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RDF")]
    public class RDF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Number of Columns per Row
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 3)]
        [DataElement("00701", typeof(HL7_N))]
        [Pos(1)]
        public virtual string NumberOfColumnsPerRow_01 { get; set; }
        /// <summary>
        // Column Description
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<RowColumnDefinition> ColumnDescription_02 { get; set; }
    }
    
    /// <summary>
    // Table Row Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RDT")]
    public class RDT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        [DataElement("00703", typeof(ANY))]
        [Pos(1)]
        public virtual List<string> RDT01 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Clinical Relationship Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REL")]
    public class REL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID -REL
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("02240", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDREL_01 { get; set; }
        /// <summary>
        // Relationship Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment RelationshipType_02 { get; set; }
        /// <summary>
        // This Relationship Instance Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier ThisRelationshipInstanceIdentifier_03 { get; set; }
        /// <summary>
        // Source Information Instance Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier SourceInformationInstanceIdentifier_04 { get; set; }
        /// <summary>
        // Target Information Instance Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier TargetInformationInstanceIdentifier_05 { get; set; }
        /// <summary>
        // Asserting Entity Instance ID
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ComprehensiveLocationIdentifier AssertingEntityInstanceID_06 { get; set; }
        /// <summary>
        // Asserting Person
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ExtendedCompositeIDNumberAndName AssertingPerson_07 { get; set; }
        /// <summary>
        // Asserting Organization
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations AssertingOrganization_08 { get; set; }
        /// <summary>
        // Assertor Address
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ExtendedAddress AssertorAddress_09 { get; set; }
        /// <summary>
        // Assertor Contact
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ExtendedTelecommunicationsNumber AssertorContact_10 { get; set; }
        /// <summary>
        // Assertion Date Range
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual NameValidityRange AssertionDateRange_11 { get; set; }
        /// <summary>
        // Negation Indicator
        /// </summary>
        [DataMember]
        [DataElement("02251", typeof(HL7_ID_136))]
        [Pos(12)]
        public virtual string NegationIndicator_12 { get; set; }
        /// <summary>
        // Certainty of Relationship
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual AssigningAgencyOrDepartment CertaintyOfRelationship_13 { get; set; }
        /// <summary>
        // Priority No
        /// </summary>
        [DataMember]
        [StringLength(0, 26)]
        [DataElement("02253", typeof(HL7_N))]
        [Pos(14)]
        public virtual string PriorityNo_14 { get; set; }
        /// <summary>
        // Priority Sequence No (rel preference for consideration)
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("02254", typeof(HL7_N))]
        [Pos(15)]
        public virtual string PrioritySequenceNo_15 { get; set; }
        /// <summary>
        // Separability Indicator
        /// </summary>
        [DataMember]
        [DataElement("02255", typeof(HL7_ID_136))]
        [Pos(16)]
        public virtual string SeparabilityIndicator_16 { get; set; }
    }
    
    /// <summary>
    // Referral Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RF1")]
    public class RF1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Referral Status
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ReferralStatus ReferralStatus_01 { get; set; }
        /// <summary>
        // Referral Priority
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ReferralPriority ReferralPriority_02 { get; set; }
        /// <summary>
        // Referral Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ReferralType ReferralType_03 { get; set; }
        /// <summary>
        // Referral Disposition
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ReferralDisposition> ReferralDisposition_04 { get; set; }
        /// <summary>
        // Referral Category
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ReferralCategory ReferralCategory_05 { get; set; }
        /// <summary>
        // Originating Referral Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual ComprehensiveLocationIdentifier OriginatingReferralIdentifier_06 { get; set; }
        /// <summary>
        // Effective Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01143", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string EffectiveDate_07 { get; set; }
        /// <summary>
        // Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01144", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string ExpirationDate_08 { get; set; }
        /// <summary>
        // Process Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01145", typeof(HL7_DTM))]
        [Pos(9)]
        public virtual string ProcessDate_09 { get; set; }
        /// <summary>
        // Referral Reason
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ReferralReason> ReferralReason_10 { get; set; }
        /// <summary>
        // External Referral Identifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ComprehensiveLocationIdentifier> ExternalReferralIdentifier_11 { get; set; }
        /// <summary>
        // Referral Documentation Completion Status
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ReferralDocumentationCompletionStatus ReferralDocumentationCompletionStatus_12 { get; set; }
    }
    
    /// <summary>
    // Resource Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RGS")]
    public class RGS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - RGS
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("01203", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDRGS_01 { get; set; }
        /// <summary>
        // Segment Action Code
        /// </summary>
        [DataMember]
        [DataElement("00763", typeof(HL7_ID_206))]
        [Pos(2)]
        public virtual string SegmentActionCode_02 { get; set; }
        /// <summary>
        // Resource Group ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment ResourceGroupID_03 { get; set; }
    }
    
    /// <summary>
    // Risk Management Incident
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RMI")]
    public class RMI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Risk Management Incident Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual RiskManagementIncidentCode RiskManagementIncidentCode_01 { get; set; }
        /// <summary>
        // Date/Time Incident
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01531", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string DateTimeIncident_02 { get; set; }
        /// <summary>
        // Incident Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual IncidentTypeCode IncidentTypeCode_03 { get; set; }
    }
    
    /// <summary>
    // Request for Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFI")]
    public class RFI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Request Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01910", typeof(HL7_DTM))]
        [Pos(1)]
        public virtual string RequestDate_01 { get; set; }
        /// <summary>
        // Response Due Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01911", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string ResponseDueDate_02 { get; set; }
        /// <summary>
        // Patient Consent
        /// </summary>
        [DataMember]
        [DataElement("01912", typeof(HL7_ID_136))]
        [Pos(3)]
        public virtual string PatientConsent_03 { get; set; }
        /// <summary>
        // Date Additional Information was submitted
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01913", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string DateAdditionalInformationWasSubmitted_04 { get; set; }
    }
    
    /// <summary>
    // Role
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ROL")]
    public class ROL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Role Instance ID
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier RoleInstanceID_01 { get; set; }
        /// <summary>
        // Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00816", typeof(HL7_ID_287))]
        [Pos(2)]
        public virtual string ActionCode_02 { get; set; }
        /// <summary>
        // Role-ROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual RoleROL RoleROL_03 { get; set; }
        /// <summary>
        // Role Person
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedCompositeIDNumberAndName> RolePerson_04 { get; set; }
        /// <summary>
        // Role Begin Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01199", typeof(HL7_DTM))]
        [Pos(5)]
        public virtual string RoleBeginDateTime_05 { get; set; }
        /// <summary>
        // Role End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01200", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string RoleEndDateTime_06 { get; set; }
        /// <summary>
        // Role Duration
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AssigningAgencyOrDepartment RoleDuration_07 { get; set; }
        /// <summary>
        // Role Action Reason
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningAgencyOrDepartment RoleActionReason_08 { get; set; }
        /// <summary>
        // Provider Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<AssigningAgencyOrDepartment> ProviderType_09 { get; set; }
        /// <summary>
        // Organization Unit Type
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual OrganizationUnitType OrganizationUnitType_10 { get; set; }
        /// <summary>
        // Office/Home Address/Birthplace
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedAddress> OfficeHomeAddressBirthplace_11 { get; set; }
        /// <summary>
        // Phone
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<ExtendedTelecommunicationsNumber> Phone_12 { get; set; }
        /// <summary>
        // Person's Location
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual PersonLocation PersonsLocation_13 { get; set; }
    }
    
    /// <summary>
    // Requisition Detail-1
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RQ1")]
    public class RQ1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Anticipated Price
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("00285", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string AnticipatedPrice_01 { get; set; }
        /// <summary>
        // Manufacturer Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SubstanceManufacturerIdentifier ManufacturerIdentifier_02 { get; set; }
        /// <summary>
        // Manufacturer's Catalog
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("00287", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string ManufacturersCatalog_03 { get; set; }
        /// <summary>
        // Vendor ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment VendorID_04 { get; set; }
        /// <summary>
        // Vendor Catalog
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("00289", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string VendorCatalog_05 { get; set; }
        /// <summary>
        // Taxable
        /// </summary>
        [DataMember]
        [DataElement("00290", typeof(HL7_ID_136))]
        [Pos(6)]
        public virtual string Taxable_06 { get; set; }
        /// <summary>
        // Substitute Allowed
        /// </summary>
        [DataMember]
        [DataElement("00291", typeof(HL7_ID_136))]
        [Pos(7)]
        public virtual string SubstituteAllowed_07 { get; set; }
    }
    
    /// <summary>
    // Requisition Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RQD")]
    public class RQD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Requisition Line Number
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00275", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string RequisitionLineNumber_01 { get; set; }
        /// <summary>
        // Item Code - Internal
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment ItemCodeInternal_02 { get; set; }
        /// <summary>
        // Item Code - External
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AssigningAgencyOrDepartment ItemCodeExternal_03 { get; set; }
        /// <summary>
        // Hospital Item Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment HospitalItemCode_04 { get; set; }
        /// <summary>
        // Requisition Quantity
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("00279", typeof(HL7_N))]
        [Pos(5)]
        public virtual string RequisitionQuantity_05 { get; set; }
        /// <summary>
        // Requisition Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment RequisitionUnitOfMeasure_06 { get; set; }
        /// <summary>
        // Cost Center Account Number
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00281", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string CostCenterAccountNumber_07 { get; set; }
        /// <summary>
        // Item Natural Account Code
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00282", typeof(HL7_AN))]
        [Pos(8)]
        public virtual string ItemNaturalAccountCode_08 { get; set; }
        /// <summary>
        // Deliver To ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment DeliverToID_09 { get; set; }
        /// <summary>
        // Date Needed
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00284", typeof(HL7_DT))]
        [Pos(10)]
        public virtual string DateNeeded_10 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Administration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXA")]
    public class RXA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Give Sub-ID Counter
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00342", typeof(HL7_N))]
        [Pos(1)]
        public virtual string GiveSubIDCounter_01 { get; set; }
        /// <summary>
        // Administration Sub-ID Counter
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00344", typeof(HL7_N))]
        [Pos(2)]
        public virtual string AdministrationSubIDCounter_02 { get; set; }
        /// <summary>
        // Date/Time Start of Administration
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00345", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string DateTimeStartOfAdministration_03 { get; set; }
        /// <summary>
        // Date/Time End of Administration
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00346", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string DateTimeEndOfAdministration_04 { get; set; }
        /// <summary>
        // Administered Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual AdministeredCode AdministeredCode_05 { get; set; }
        /// <summary>
        // Administered Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00348", typeof(HL7_N))]
        [Pos(6)]
        public virtual string AdministeredAmount_06 { get; set; }
        /// <summary>
        // Administered Units
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AssigningAgencyOrDepartment AdministeredUnits_07 { get; set; }
        /// <summary>
        // Administered Dosage Form
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningAgencyOrDepartment AdministeredDosageForm_08 { get; set; }
        /// <summary>
        // Administration Notes
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<AssigningAgencyOrDepartment> AdministrationNotes_09 { get; set; }
        /// <summary>
        // Administering Provider
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDNumberAndName> AdministeringProvider_10 { get; set; }
        /// <summary>
        // Administered-at Location
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual LocationWithAddressVariation AdministeredatLocation_11 { get; set; }
        /// <summary>
        // Administered Per (Time Unit)
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00354", typeof(HL7_AN))]
        [Pos(12)]
        public virtual string AdministeredPer_12 { get; set; }
        /// <summary>
        // Administered Strength
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01134", typeof(HL7_N))]
        [Pos(13)]
        public virtual string AdministeredStrength_13 { get; set; }
        /// <summary>
        // Administered Strength Units
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual AssigningAgencyOrDepartment AdministeredStrengthUnits_14 { get; set; }
        /// <summary>
        // Substance Lot Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("01129", typeof(HL7_AN))]
        [Pos(15)]
        public virtual List<string> SubstanceLotNumber_15 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Substance Expiration Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 24)]
        [DataElement("01130", typeof(HL7_DTM))]
        [Pos(16)]
        public virtual List<string> SubstanceExpirationDate_16 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Substance Manufacturer Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<SubstanceManufacturerName> SubstanceManufacturerName_17 { get; set; }
        /// <summary>
        // Substance/Treatment Refusal Reason
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<AssigningAgencyOrDepartment> SubstanceTreatmentRefusalReason_18 { get; set; }
        /// <summary>
        // Indication
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<AssigningAgencyOrDepartment> Indication_19 { get; set; }
        /// <summary>
        // Completion Status
        /// </summary>
        [DataMember]
        [DataElement("01223", typeof(HL7_ID_322))]
        [Pos(20)]
        public virtual string CompletionStatus_20 { get; set; }
        /// <summary>
        // Action Code - RXA
        /// </summary>
        [DataMember]
        [DataElement("01224", typeof(HL7_ID_206))]
        [Pos(21)]
        public virtual string ActionCodeRXA_21 { get; set; }
        /// <summary>
        // System Entry Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01225", typeof(HL7_DTM))]
        [Pos(22)]
        public virtual string SystemEntryDateTime_22 { get; set; }
        /// <summary>
        // Administered Drug Strength Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01696", typeof(HL7_N))]
        [Pos(23)]
        public virtual string AdministeredDrugStrengthVolume_23 { get; set; }
        /// <summary>
        // Administered Drug Strength Volume Units
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual AssigningAgencyOrDepartment AdministeredDrugStrengthVolumeUnits_24 { get; set; }
        /// <summary>
        // Administered Barcode Identifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual AssigningAgencyOrDepartment AdministeredBarcodeIdentifier_25 { get; set; }
        /// <summary>
        // Pharmacy Order Type
        /// </summary>
        [DataMember]
        [DataElement("01699", typeof(HL7_ID_480))]
        [Pos(26)]
        public virtual string PharmacyOrderType_26 { get; set; }
        /// <summary>
        // Administer-at
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual PersonLocation Administerat_27 { get; set; }
        /// <summary>
        // Administered-at Address
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual ExtendedAddress AdministeredatAddress_28 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Component Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXC")]
    public class RXC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // RX Component Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00313", typeof(HL7_ID_166))]
        [Pos(1)]
        public virtual string RXComponentType_01 { get; set; }
        /// <summary>
        // Component Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment ComponentCode_02 { get; set; }
        /// <summary>
        // Component Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00315", typeof(HL7_N))]
        [Pos(3)]
        public virtual string ComponentAmount_03 { get; set; }
        /// <summary>
        // Component Units
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment ComponentUnits_04 { get; set; }
        /// <summary>
        // Component Strength
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01124", typeof(HL7_N))]
        [Pos(5)]
        public virtual string ComponentStrength_05 { get; set; }
        /// <summary>
        // Component Strength Units
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment ComponentStrengthUnits_06 { get; set; }
        /// <summary>
        // Supplementary Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<AssigningAgencyOrDepartment> SupplementaryCode_07 { get; set; }
        /// <summary>
        // Component Drug Strength Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01671", typeof(HL7_N))]
        [Pos(8)]
        public virtual string ComponentDrugStrengthVolume_08 { get; set; }
        /// <summary>
        // Component Drug Strength Volume Units
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AssigningAgencyOrDepartment ComponentDrugStrengthVolumeUnits_09 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Dispense
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXD")]
    public class RXD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Dispense Sub-ID Counter
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00334", typeof(HL7_N))]
        [Pos(1)]
        public virtual string DispenseSubIDCounter_01 { get; set; }
        /// <summary>
        // Dispense/Give Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AdministeredCode DispenseGiveCode_02 { get; set; }
        /// <summary>
        // Date/Time Dispensed
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("00336", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string DateTimeDispensed_03 { get; set; }
        /// <summary>
        // Actual Dispense Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00337", typeof(HL7_N))]
        [Pos(4)]
        public virtual string ActualDispenseAmount_04 { get; set; }
        /// <summary>
        // Actual Dispense Units
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ActualDispenseUnits_05 { get; set; }
        /// <summary>
        // Actual Dosage Form
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment ActualDosageForm_06 { get; set; }
        /// <summary>
        // Prescription Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00325", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string PrescriptionNumber_07 { get; set; }
        /// <summary>
        // Number of Refills Remaining
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00326", typeof(HL7_N))]
        [Pos(8)]
        public virtual string NumberOfRefillsRemaining_08 { get; set; }
        /// <summary>
        // Dispense Notes
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 200)]
        [DataElement("00340", typeof(HL7_AN))]
        [Pos(9)]
        public virtual List<string> DispenseNotes_09 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Dispensing Provider
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDNumberAndName> DispensingProvider_10 { get; set; }
        /// <summary>
        // Substitution Status
        /// </summary>
        [DataMember]
        [DataElement("00322", typeof(HL7_ID_167))]
        [Pos(11)]
        public virtual string SubstitutionStatus_11 { get; set; }
        /// <summary>
        // Total Daily Dose
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Quantity TotalDailyDose_12 { get; set; }
        /// <summary>
        // Dispense-to Location
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual LocationWithAddressVariation DispensetoLocation_13 { get; set; }
        /// <summary>
        // Needs Human Review
        /// </summary>
        [DataMember]
        [DataElement("00307", typeof(HL7_ID_136))]
        [Pos(14)]
        public virtual string NeedsHumanReview_14 { get; set; }
        /// <summary>
        // Pharmacy/Treatment Supplier's Special Dispensing Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<AssigningAgencyOrDepartment> PharmacyTreatmentSuppliersSpecialDispensingInstructions_15 { get; set; }
        /// <summary>
        // Actual Strength
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01132", typeof(HL7_N))]
        [Pos(16)]
        public virtual string ActualStrength_16 { get; set; }
        /// <summary>
        // Actual Strength Unit
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual AssigningAgencyOrDepartment ActualStrengthUnit_17 { get; set; }
        /// <summary>
        // Substance Lot Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("01129", typeof(HL7_AN))]
        [Pos(18)]
        public virtual List<string> SubstanceLotNumber_18 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Substance Expiration Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 24)]
        [DataElement("01130", typeof(HL7_DTM))]
        [Pos(19)]
        public virtual List<string> SubstanceExpirationDate_19 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Substance Manufacturer Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<SubstanceManufacturerName> SubstanceManufacturerName_20 { get; set; }
        /// <summary>
        // Indication
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<AssigningAgencyOrDepartment> Indication_21 { get; set; }
        /// <summary>
        // Dispense Package Size
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01220", typeof(HL7_N))]
        [Pos(22)]
        public virtual string DispensePackageSize_22 { get; set; }
        /// <summary>
        // Dispense Package Size Unit
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AssigningAgencyOrDepartment DispensePackageSizeUnit_23 { get; set; }
        /// <summary>
        // Dispense Package Method
        /// </summary>
        [DataMember]
        [DataElement("01222", typeof(HL7_ID_321))]
        [Pos(24)]
        public virtual string DispensePackageMethod_24 { get; set; }
        /// <summary>
        // Supplementary Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(25)]
        public virtual List<AssigningAgencyOrDepartment> SupplementaryCode_25 { get; set; }
        /// <summary>
        // Initiating Location
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual AssigningAgencyOrDepartment InitiatingLocation_26 { get; set; }
        /// <summary>
        // Packaging/Assembly Location
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual AssigningAgencyOrDepartment PackagingAssemblyLocation_27 { get; set; }
        /// <summary>
        // Actual Drug Strength Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01686", typeof(HL7_N))]
        [Pos(28)]
        public virtual string ActualDrugStrengthVolume_28 { get; set; }
        /// <summary>
        // Actual Drug Strength Volume Units
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual AssigningAgencyOrDepartment ActualDrugStrengthVolumeUnits_29 { get; set; }
        /// <summary>
        // Dispense to Pharmacy
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual AssigningAgencyOrDepartment DispenseToPharmacy_30 { get; set; }
        /// <summary>
        // Dispense to Pharmacy Address
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual ExtendedAddress DispenseToPharmacyAddress_31 { get; set; }
        /// <summary>
        // Pharmacy Order Type
        /// </summary>
        [DataMember]
        [DataElement("01690", typeof(HL7_ID_480))]
        [Pos(32)]
        public virtual string PharmacyOrderType_32 { get; set; }
        /// <summary>
        // Dispense Type
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual DispenseType DispenseType_33 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Encoded Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXE")]
    public class RXE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity/Timing
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Timingquantity QuantityTiming_01 { get; set; }
        /// <summary>
        // Give Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AdministeredCode GiveCode_02 { get; set; }
        /// <summary>
        // Give Amount - Minimum
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00318", typeof(HL7_N))]
        [Pos(3)]
        public virtual string GiveAmountMinimum_03 { get; set; }
        /// <summary>
        // Give Amount - Maximum
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00319", typeof(HL7_N))]
        [Pos(4)]
        public virtual string GiveAmountMaximum_04 { get; set; }
        /// <summary>
        // Give Units
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment GiveUnits_05 { get; set; }
        /// <summary>
        // Give Dosage Form
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment GiveDosageForm_06 { get; set; }
        /// <summary>
        // Provider's Administration Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<AssigningAgencyOrDepartment> ProvidersAdministrationInstructions_07 { get; set; }
        /// <summary>
        // Deliver-To Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LocationWithAddress DeliverToLocation_08 { get; set; }
        /// <summary>
        // Substitution Status
        /// </summary>
        [DataMember]
        [DataElement("00322", typeof(HL7_ID_167))]
        [Pos(9)]
        public virtual string SubstitutionStatus_09 { get; set; }
        /// <summary>
        // Dispense Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00323", typeof(HL7_N))]
        [Pos(10)]
        public virtual string DispenseAmount_10 { get; set; }
        /// <summary>
        // Dispense Units
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AssigningAgencyOrDepartment DispenseUnits_11 { get; set; }
        /// <summary>
        // Number Of Refills
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00304", typeof(HL7_N))]
        [Pos(12)]
        public virtual string NumberOfRefills_12 { get; set; }
        /// <summary>
        // Ordering Provider's DEA Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<ExtendedCompositeIDNumberAndName> OrderingProvidersDEANumber_13 { get; set; }
        /// <summary>
        // Pharmacist/Treatment Supplier's Verifier ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<ExtendedCompositeIDNumberAndName> PharmacistTreatmentSuppliersVerifierID_14 { get; set; }
        /// <summary>
        // Prescription Number
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00325", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string PrescriptionNumber_15 { get; set; }
        /// <summary>
        // Number of Refills Remaining
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00326", typeof(HL7_N))]
        [Pos(16)]
        public virtual string NumberOfRefillsRemaining_16 { get; set; }
        /// <summary>
        // Number of Refills/Doses Dispensed
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00327", typeof(HL7_N))]
        [Pos(17)]
        public virtual string NumberOfRefillsDosesDispensed_17 { get; set; }
        /// <summary>
        // D/T of Most Recent Refill or Dose Dispensed
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00328", typeof(HL7_DTM))]
        [Pos(18)]
        public virtual string DTOfMostRecentRefillOrDoseDispensed_18 { get; set; }
        /// <summary>
        // Total Daily Dose
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual Quantity TotalDailyDose_19 { get; set; }
        /// <summary>
        // Needs Human Review
        /// </summary>
        [DataMember]
        [DataElement("00307", typeof(HL7_ID_136))]
        [Pos(20)]
        public virtual string NeedsHumanReview_20 { get; set; }
        /// <summary>
        // Pharmacy/Treatment Supplier's Special Dispensing Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<AssigningAgencyOrDepartment> PharmacyTreatmentSuppliersSpecialDispensingInstructions_21 { get; set; }
        /// <summary>
        // Give Per (Time Unit)
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00331", typeof(HL7_AN))]
        [Pos(22)]
        public virtual string GivePer_22 { get; set; }
        /// <summary>
        // Give Rate Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("00332", typeof(HL7_AN))]
        [Pos(23)]
        public virtual string GiveRateAmount_23 { get; set; }
        /// <summary>
        // Give Rate Units
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual AssigningAgencyOrDepartment GiveRateUnits_24 { get; set; }
        /// <summary>
        // Give Strength
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01126", typeof(HL7_N))]
        [Pos(25)]
        public virtual string GiveStrength_25 { get; set; }
        /// <summary>
        // Give Strength Units
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual AssigningAgencyOrDepartment GiveStrengthUnits_26 { get; set; }
        /// <summary>
        // Give Indication
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(27)]
        public virtual List<AssigningAgencyOrDepartment> GiveIndication_27 { get; set; }
        /// <summary>
        // Dispense Package Size
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01220", typeof(HL7_N))]
        [Pos(28)]
        public virtual string DispensePackageSize_28 { get; set; }
        /// <summary>
        // Dispense Package Size Unit
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual AssigningAgencyOrDepartment DispensePackageSizeUnit_29 { get; set; }
        /// <summary>
        // Dispense Package Method
        /// </summary>
        [DataMember]
        [DataElement("01222", typeof(HL7_ID_321))]
        [Pos(30)]
        public virtual string DispensePackageMethod_30 { get; set; }
        /// <summary>
        // Supplementary Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(31)]
        public virtual List<AssigningAgencyOrDepartment> SupplementaryCode_31 { get; set; }
        /// <summary>
        // Original Order Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01673", typeof(HL7_DTM))]
        [Pos(32)]
        public virtual string OriginalOrderDateTime_32 { get; set; }
        /// <summary>
        // Give Drug Strength Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01674", typeof(HL7_N))]
        [Pos(33)]
        public virtual string GiveDrugStrengthVolume_33 { get; set; }
        /// <summary>
        // Give Drug Strength Volume Units
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual AssigningAgencyOrDepartment GiveDrugStrengthVolumeUnits_34 { get; set; }
        /// <summary>
        // Controlled Substance Schedule
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual ControlledSubstanceSchedule ControlledSubstanceSchedule_35 { get; set; }
        /// <summary>
        // Formulary Status
        /// </summary>
        [DataMember]
        [DataElement("01677", typeof(HL7_ID_478))]
        [Pos(36)]
        public virtual string FormularyStatus_36 { get; set; }
        /// <summary>
        // Pharmaceutical Substance Alternative
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(37)]
        public virtual List<AssigningAgencyOrDepartment> PharmaceuticalSubstanceAlternative_37 { get; set; }
        /// <summary>
        // Pharmacy of Most Recent Fill
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual AssigningAgencyOrDepartment PharmacyOfMostRecentFill_38 { get; set; }
        /// <summary>
        // Initial Dispense Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01680", typeof(HL7_N))]
        [Pos(39)]
        public virtual string InitialDispenseAmount_39 { get; set; }
        /// <summary>
        // Dispensing Pharmacy
        /// </summary>
        [DataMember]
        [Pos(40)]
        public virtual AssigningAgencyOrDepartment DispensingPharmacy_40 { get; set; }
        /// <summary>
        // Dispensing Pharmacy Address
        /// </summary>
        [DataMember]
        [Pos(41)]
        public virtual ExtendedAddress DispensingPharmacyAddress_41 { get; set; }
        /// <summary>
        // Deliver-to Patient Location
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual PersonLocation DelivertoPatientLocation_42 { get; set; }
        /// <summary>
        // Deliver-to Address
        /// </summary>
        [DataMember]
        [Pos(43)]
        public virtual ExtendedAddress DelivertoAddress_43 { get; set; }
        /// <summary>
        // Pharmacy Order Type
        /// </summary>
        [DataMember]
        [DataElement("01685", typeof(HL7_ID_480))]
        [Pos(44)]
        public virtual string PharmacyOrderType_44 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Give
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXG")]
    public class RXG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Give Sub-ID Counter
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00342", typeof(HL7_N))]
        [Pos(1)]
        public virtual string GiveSubIDCounter_01 { get; set; }
        /// <summary>
        // Dispense Sub-ID Counter
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00334", typeof(HL7_N))]
        [Pos(2)]
        public virtual string DispenseSubIDCounter_02 { get; set; }
        /// <summary>
        // Quantity/Timing
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Timingquantity QuantityTiming_03 { get; set; }
        /// <summary>
        // Give Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AdministeredCode GiveCode_04 { get; set; }
        /// <summary>
        // Give Amount - Minimum
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("00318", typeof(HL7_N))]
        [Pos(5)]
        public virtual string GiveAmountMinimum_05 { get; set; }
        /// <summary>
        // Give Amount - Maximum
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00319", typeof(HL7_N))]
        [Pos(6)]
        public virtual string GiveAmountMaximum_06 { get; set; }
        /// <summary>
        // Give Units
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual AssigningAgencyOrDepartment GiveUnits_07 { get; set; }
        /// <summary>
        // Give Dosage Form
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningAgencyOrDepartment GiveDosageForm_08 { get; set; }
        /// <summary>
        // Administration Notes
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<AssigningAgencyOrDepartment> AdministrationNotes_09 { get; set; }
        /// <summary>
        // Substitution Status
        /// </summary>
        [DataMember]
        [DataElement("00322", typeof(HL7_ID_167))]
        [Pos(10)]
        public virtual string SubstitutionStatus_10 { get; set; }
        /// <summary>
        // Dispense-to Location
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual LocationWithAddressVariation DispensetoLocation_11 { get; set; }
        /// <summary>
        // Needs Human Review
        /// </summary>
        [DataMember]
        [DataElement("00307", typeof(HL7_ID_136))]
        [Pos(12)]
        public virtual string NeedsHumanReview_12 { get; set; }
        /// <summary>
        // Pharmacy/Treatment Supplier's Special Administration Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<AssigningAgencyOrDepartment> PharmacyTreatmentSuppliersSpecialAdministrationInstructions_13 { get; set; }
        /// <summary>
        // Give Per (Time Unit)
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00331", typeof(HL7_AN))]
        [Pos(14)]
        public virtual string GivePer_14 { get; set; }
        /// <summary>
        // Give Rate Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("00332", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string GiveRateAmount_15 { get; set; }
        /// <summary>
        // Give Rate Units
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual AssigningAgencyOrDepartment GiveRateUnits_16 { get; set; }
        /// <summary>
        // Give Strength
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01126", typeof(HL7_N))]
        [Pos(17)]
        public virtual string GiveStrength_17 { get; set; }
        /// <summary>
        // Give Strength Units
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual AssigningAgencyOrDepartment GiveStrengthUnits_18 { get; set; }
        /// <summary>
        // Substance Lot Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("01129", typeof(HL7_AN))]
        [Pos(19)]
        public virtual List<string> SubstanceLotNumber_19 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Substance Expiration Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 24)]
        [DataElement("01130", typeof(HL7_DTM))]
        [Pos(20)]
        public virtual List<string> SubstanceExpirationDate_20 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Substance Manufacturer Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<SubstanceManufacturerName> SubstanceManufacturerName_21 { get; set; }
        /// <summary>
        // Indication
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<AssigningAgencyOrDepartment> Indication_22 { get; set; }
        /// <summary>
        // Give Drug Strength Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01692", typeof(HL7_N))]
        [Pos(23)]
        public virtual string GiveDrugStrengthVolume_23 { get; set; }
        /// <summary>
        // Give Drug Strength Volume Units
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual AssigningAgencyOrDepartment GiveDrugStrengthVolumeUnits_24 { get; set; }
        /// <summary>
        // Give Barcode Identifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual AssigningAgencyOrDepartment GiveBarcodeIdentifier_25 { get; set; }
        /// <summary>
        // Pharmacy Order Type
        /// </summary>
        [DataMember]
        [DataElement("01695", typeof(HL7_ID_480))]
        [Pos(26)]
        public virtual string PharmacyOrderType_26 { get; set; }
        /// <summary>
        // Dispense to Pharmacy
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual AssigningAgencyOrDepartment DispenseToPharmacy_27 { get; set; }
        /// <summary>
        // Dispense to Pharmacy Address
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual ExtendedAddress DispenseToPharmacyAddress_28 { get; set; }
        /// <summary>
        // Deliver-to Patient Location
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual PersonLocation DelivertoPatientLocation_29 { get; set; }
        /// <summary>
        // Deliver-to Address
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual ExtendedAddress DelivertoAddress_30 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXO")]
    public class RXO
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Requested Give Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment RequestedGiveCode_01 { get; set; }
        /// <summary>
        // Requested Give Amount - Minimum
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00293", typeof(HL7_N))]
        [Pos(2)]
        public virtual string RequestedGiveAmountMinimum_02 { get; set; }
        /// <summary>
        // Requested Give Amount - Maximum
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00294", typeof(HL7_N))]
        [Pos(3)]
        public virtual string RequestedGiveAmountMaximum_03 { get; set; }
        /// <summary>
        // Requested Give Units
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AssigningAgencyOrDepartment RequestedGiveUnits_04 { get; set; }
        /// <summary>
        // Requested Dosage Form
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment RequestedDosageForm_05 { get; set; }
        /// <summary>
        // Provider's Pharmacy/Treatment Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<AssigningAgencyOrDepartment> ProvidersPharmacyTreatmentInstructions_06 { get; set; }
        /// <summary>
        // Provider's Administration Instructions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<AssigningAgencyOrDepartment> ProvidersAdministrationInstructions_07 { get; set; }
        /// <summary>
        // Deliver-To Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LocationWithAddress DeliverToLocation_08 { get; set; }
        /// <summary>
        // Allow Substitutions
        /// </summary>
        [DataMember]
        [DataElement("00300", typeof(HL7_ID_161))]
        [Pos(9)]
        public virtual string AllowSubstitutions_09 { get; set; }
        /// <summary>
        // Requested Dispense Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AssigningAgencyOrDepartment RequestedDispenseCode_10 { get; set; }
        /// <summary>
        // Requested Dispense Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00302", typeof(HL7_N))]
        [Pos(11)]
        public virtual string RequestedDispenseAmount_11 { get; set; }
        /// <summary>
        // Requested Dispense Units
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual AssigningAgencyOrDepartment RequestedDispenseUnits_12 { get; set; }
        /// <summary>
        // Number Of Refills
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00304", typeof(HL7_N))]
        [Pos(13)]
        public virtual string NumberOfRefills_13 { get; set; }
        /// <summary>
        // Ordering Provider's DEA Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<ExtendedCompositeIDNumberAndName> OrderingProvidersDEANumber_14 { get; set; }
        /// <summary>
        // Pharmacist/Treatment Supplier's Verifier ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<ExtendedCompositeIDNumberAndName> PharmacistTreatmentSuppliersVerifierID_15 { get; set; }
        /// <summary>
        // Needs Human Review
        /// </summary>
        [DataMember]
        [DataElement("00307", typeof(HL7_ID_136))]
        [Pos(16)]
        public virtual string NeedsHumanReview_16 { get; set; }
        /// <summary>
        // Requested Give Per (Time Unit)
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00308", typeof(HL7_AN))]
        [Pos(17)]
        public virtual string RequestedGivePer_17 { get; set; }
        /// <summary>
        // Requested Give Strength
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01121", typeof(HL7_N))]
        [Pos(18)]
        public virtual string RequestedGiveStrength_18 { get; set; }
        /// <summary>
        // Requested Give Strength Units
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual AssigningAgencyOrDepartment RequestedGiveStrengthUnits_19 { get; set; }
        /// <summary>
        // Indication
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<AssigningAgencyOrDepartment> Indication_20 { get; set; }
        /// <summary>
        // Requested Give Rate Amount
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("01218", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string RequestedGiveRateAmount_21 { get; set; }
        /// <summary>
        // Requested Give Rate Units
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual AssigningAgencyOrDepartment RequestedGiveRateUnits_22 { get; set; }
        /// <summary>
        // Total Daily Dose
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual Quantity TotalDailyDose_23 { get; set; }
        /// <summary>
        // Supplementary Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<AssigningAgencyOrDepartment> SupplementaryCode_24 { get; set; }
        /// <summary>
        // Requested Drug Strength Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("01666", typeof(HL7_N))]
        [Pos(25)]
        public virtual string RequestedDrugStrengthVolume_25 { get; set; }
        /// <summary>
        // Requested Drug Strength Volume Units
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual AssigningAgencyOrDepartment RequestedDrugStrengthVolumeUnits_26 { get; set; }
        /// <summary>
        // Pharmacy Order Type
        /// </summary>
        [DataMember]
        [DataElement("01668", typeof(HL7_ID_480))]
        [Pos(27)]
        public virtual string PharmacyOrderType_27 { get; set; }
        /// <summary>
        // Dispensing Interval
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01669", typeof(HL7_N))]
        [Pos(28)]
        public virtual string DispensingInterval_28 { get; set; }
        /// <summary>
        // Medication Instance Identifier
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual ComprehensiveLocationIdentifier MedicationInstanceIdentifier_29 { get; set; }
        /// <summary>
        // Segment Instance Identifier
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual ComprehensiveLocationIdentifier SegmentInstanceIdentifier_30 { get; set; }
        /// <summary>
        // Mood Code
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual MoodCode MoodCode_31 { get; set; }
        /// <summary>
        // Dispensing Pharmacy
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual AssigningAgencyOrDepartment DispensingPharmacy_32 { get; set; }
        /// <summary>
        // Dispensing Pharmacy Address
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual ExtendedAddress DispensingPharmacyAddress_33 { get; set; }
        /// <summary>
        // Deliver-to Patient Location
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual PersonLocation DelivertoPatientLocation_34 { get; set; }
        /// <summary>
        // Deliver-to Address
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual ExtendedAddress DelivertoAddress_35 { get; set; }
    }
    
    /// <summary>
    // Pharmacy/Treatment Route
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RXR")]
    public class RXR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Route
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Route Route_01 { get; set; }
        /// <summary>
        // Administration Site
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AdministrationSite AdministrationSite_02 { get; set; }
        /// <summary>
        // Administration Device
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AdministrationDevice AdministrationDevice_03 { get; set; }
        /// <summary>
        // Administration Method
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AdministrationMethod AdministrationMethod_04 { get; set; }
        /// <summary>
        // Routing Instruction
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment RoutingInstruction_05 { get; set; }
        /// <summary>
        // Administration Site Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AdministrationSiteModifier AdministrationSiteModifier_06 { get; set; }
    }
    
    /// <summary>
    // Specimen Container detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SAC")]
    public class SAC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // External Accession Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier ExternalAccessionIdentifier_01 { get; set; }
        /// <summary>
        // Accession Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier AccessionIdentifier_02 { get; set; }
        /// <summary>
        // Container Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier ContainerIdentifier_03 { get; set; }
        /// <summary>
        // Primary (Parent) Container Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier Primary_04 { get; set; }
        /// <summary>
        // Equipment Container Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ComprehensiveLocationIdentifier EquipmentContainerIdentifier_05 { get; set; }
        /// <summary>
        // Specimen Source
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SpecimenSource SpecimenSource_06 { get; set; }
        /// <summary>
        // Registration Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01334", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string RegistrationDateTime_07 { get; set; }
        /// <summary>
        // Container Status
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ContainerStatus ContainerStatus_08 { get; set; }
        /// <summary>
        // Carrier Type
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual CarrierType CarrierType_09 { get; set; }
        /// <summary>
        // Carrier Identifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ComprehensiveLocationIdentifier CarrierIdentifier_10 { get; set; }
        /// <summary>
        // Position in Carrier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual NumericArray PositionInCarrier_11 { get; set; }
        /// <summary>
        // Tray Type - SAC
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual TrayTypeSAC TrayTypeSAC_12 { get; set; }
        /// <summary>
        // Tray Identifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ComprehensiveLocationIdentifier TrayIdentifier_13 { get; set; }
        /// <summary>
        // Position in Tray
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual NumericArray PositionInTray_14 { get; set; }
        /// <summary>
        // Location
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<AssigningAgencyOrDepartment> Location_15 { get; set; }
        /// <summary>
        // Container Height
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01343", typeof(HL7_N))]
        [Pos(16)]
        public virtual string ContainerHeight_16 { get; set; }
        /// <summary>
        // Container Diameter
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01344", typeof(HL7_N))]
        [Pos(17)]
        public virtual string ContainerDiameter_17 { get; set; }
        /// <summary>
        // Barrier Delta
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01345", typeof(HL7_N))]
        [Pos(18)]
        public virtual string BarrierDelta_18 { get; set; }
        /// <summary>
        // Bottom Delta
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01346", typeof(HL7_N))]
        [Pos(19)]
        public virtual string BottomDelta_19 { get; set; }
        /// <summary>
        // Container Height/Diameter/Delta Units
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual AssigningAgencyOrDepartment ContainerHeightDiameterDeltaUnits_20 { get; set; }
        /// <summary>
        // Container Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00644", typeof(HL7_N))]
        [Pos(21)]
        public virtual string ContainerVolume_21 { get; set; }
        /// <summary>
        // Available Specimen Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01349", typeof(HL7_N))]
        [Pos(22)]
        public virtual string AvailableSpecimenVolume_22 { get; set; }
        /// <summary>
        // Initial Specimen Volume
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01350", typeof(HL7_N))]
        [Pos(23)]
        public virtual string InitialSpecimenVolume_23 { get; set; }
        /// <summary>
        // Volume Units
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual AssigningAgencyOrDepartment VolumeUnits_24 { get; set; }
        /// <summary>
        // Separator Type
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual SeparatorType SeparatorType_25 { get; set; }
        /// <summary>
        // Cap Type
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual CapType CapType_26 { get; set; }
        /// <summary>
        // Additive
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(27)]
        public virtual List<SpecimenAdditives> Additive_27 { get; set; }
        /// <summary>
        // Specimen Component
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual SpecimenComponent SpecimenComponent_28 { get; set; }
        /// <summary>
        // Dilution Factor
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual StructuredNumeric DilutionFactor_29 { get; set; }
        /// <summary>
        // Treatment
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual Treatment Treatment_30 { get; set; }
        /// <summary>
        // Temperature
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual StructuredNumeric Temperature_31 { get; set; }
        /// <summary>
        // Hemolysis Index
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01359", typeof(HL7_N))]
        [Pos(32)]
        public virtual string HemolysisIndex_32 { get; set; }
        /// <summary>
        // Hemolysis Index Units
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual AssigningAgencyOrDepartment HemolysisIndexUnits_33 { get; set; }
        /// <summary>
        // Lipemia Index
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01361", typeof(HL7_N))]
        [Pos(34)]
        public virtual string LipemiaIndex_34 { get; set; }
        /// <summary>
        // Lipemia Index Units
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual AssigningAgencyOrDepartment LipemiaIndexUnits_35 { get; set; }
        /// <summary>
        // Icterus Index
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01363", typeof(HL7_N))]
        [Pos(36)]
        public virtual string IcterusIndex_36 { get; set; }
        /// <summary>
        // Icterus Index Units
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual AssigningAgencyOrDepartment IcterusIndexUnits_37 { get; set; }
        /// <summary>
        // Fibrin Index
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01365", typeof(HL7_N))]
        [Pos(38)]
        public virtual string FibrinIndex_38 { get; set; }
        /// <summary>
        // Fibrin Index Units
        /// </summary>
        [DataMember]
        [Pos(39)]
        public virtual AssigningAgencyOrDepartment FibrinIndexUnits_39 { get; set; }
        /// <summary>
        // System Induced Contaminants
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(40)]
        public virtual List<SystemInducedContaminants> SystemInducedContaminants_40 { get; set; }
        /// <summary>
        // Drug Interference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(41)]
        public virtual List<DrugInterference> DrugInterference_41 { get; set; }
        /// <summary>
        // Artificial Blood
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual ArtificialBlood ArtificialBlood_42 { get; set; }
        /// <summary>
        // Special Handling Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(43)]
        public virtual List<SpecimenHandlingCode> SpecialHandlingCode_43 { get; set; }
        /// <summary>
        // Other Environmental Factors
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(44)]
        public virtual List<OtherEnvironmentalFactors> OtherEnvironmentalFactors_44 { get; set; }
    }
    
    /// <summary>
    // Anti-Microbial Cycle Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCD")]
    public class SCD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Cycle Start Time
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("02104", typeof(HL7_TM))]
        [Pos(1)]
        public virtual string CycleStartTime_01 { get; set; }
        /// <summary>
        // Cycle Count
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("02105", typeof(HL7_N))]
        [Pos(2)]
        public virtual string CycleCount_02 { get; set; }
        /// <summary>
        // Temp Max
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Quantity TempMax_03 { get; set; }
        /// <summary>
        // Temp Min
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Quantity TempMin_04 { get; set; }
        /// <summary>
        // Load Number
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("02108", typeof(HL7_N))]
        [Pos(5)]
        public virtual string LoadNumber_05 { get; set; }
        /// <summary>
        // Condition Time
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Quantity ConditionTime_06 { get; set; }
        /// <summary>
        // Sterilize Time
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Quantity SterilizeTime_07 { get; set; }
        /// <summary>
        // Exhaust Time
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Quantity ExhaustTime_08 { get; set; }
        /// <summary>
        // Total Cycle Time
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Quantity TotalCycleTime_09 { get; set; }
        /// <summary>
        // Device Status
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual DeviceStatus DeviceStatus_10 { get; set; }
        /// <summary>
        // Cycle Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("02114", typeof(HL7_DTM))]
        [Pos(11)]
        public virtual string CycleStartDateTime_11 { get; set; }
        /// <summary>
        // Dry Time
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Quantity DryTime_12 { get; set; }
        /// <summary>
        // Leak Rate
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual Quantity LeakRate_13 { get; set; }
        /// <summary>
        // Control Temperature
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual Quantity ControlTemperature_14 { get; set; }
        /// <summary>
        // Sterilizer Temperature
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual Quantity SterilizerTemperature_15 { get; set; }
        /// <summary>
        // Cycle Complete Time
        /// </summary>
        [DataMember]
        [StringLength(0, 16)]
        [DataElement("02119", typeof(HL7_TM))]
        [Pos(16)]
        public virtual string CycleCompleteTime_16 { get; set; }
        /// <summary>
        // Under Temperature
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual Quantity UnderTemperature_17 { get; set; }
        /// <summary>
        // Over Temperature
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual Quantity OverTemperature_18 { get; set; }
        /// <summary>
        // Abort Cycle
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual DefaultOrderUnitOfMeasureIndicator AbortCycle_19 { get; set; }
        /// <summary>
        // Alarm
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual DefaultOrderUnitOfMeasureIndicator Alarm_20 { get; set; }
        /// <summary>
        // Long in Charge Phase
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual DefaultOrderUnitOfMeasureIndicator LongInChargePhase_21 { get; set; }
        /// <summary>
        // Long in Exhaust Phase
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual DefaultOrderUnitOfMeasureIndicator LongInExhaustPhase_22 { get; set; }
        /// <summary>
        // Long in Fast Exhaust Phase
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual DefaultOrderUnitOfMeasureIndicator LongInFastExhaustPhase_23 { get; set; }
        /// <summary>
        // Reset
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual DefaultOrderUnitOfMeasureIndicator Reset_24 { get; set; }
        /// <summary>
        // Operator - Unload
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual ExtendedCompositeIDNumberAndName OperatorUnload_25 { get; set; }
        /// <summary>
        // Door Open
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual DefaultOrderUnitOfMeasureIndicator DoorOpen_26 { get; set; }
        /// <summary>
        // Reading Failure
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual DefaultOrderUnitOfMeasureIndicator ReadingFailure_27 { get; set; }
        /// <summary>
        // Cycle Type
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual CycleType CycleType_28 { get; set; }
        /// <summary>
        // Thermal Rinse Time
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual Quantity ThermalRinseTime_29 { get; set; }
        /// <summary>
        // Wash Time
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual Quantity WashTime_30 { get; set; }
        /// <summary>
        // Injection Rate
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual Quantity InjectionRate_31 { get; set; }
        /// <summary>
        // Procedure Code
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual ProcedureCode ProcedureCode_32 { get; set; }
        /// <summary>
        // Patient Identifier List
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(33)]
        public virtual List<ExtendedCompositeIDWithCheckDigit> PatientIdentifierList_33 { get; set; }
        /// <summary>
        // Attending Doctor
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual DischargeCareProvider AttendingDoctor_34 { get; set; }
        /// <summary>
        // Dilution Factor
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual StructuredNumeric DilutionFactor_35 { get; set; }
        /// <summary>
        // Fill Time
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual Quantity FillTime_36 { get; set; }
        /// <summary>
        // Inlet Temperature
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual Quantity InletTemperature_37 { get; set; }
    }
    
    /// <summary>
    // Scheduling Activity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCH")]
    public class SCH
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Placer Appointment ID
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier PlacerAppointmentID_01 { get; set; }
        /// <summary>
        // Filler Appointment ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier FillerAppointmentID_02 { get; set; }
        /// <summary>
        // Occurrence Number
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00862", typeof(HL7_N))]
        [Pos(3)]
        public virtual string OccurrenceNumber_03 { get; set; }
        /// <summary>
        // Placer Group Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier PlacerGroupNumber_04 { get; set; }
        /// <summary>
        // Schedule ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment ScheduleID_05 { get; set; }
        /// <summary>
        // Event Reason
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual AssigningAgencyOrDepartment EventReason_06 { get; set; }
        /// <summary>
        // Appointment Reason
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AppointmentReason AppointmentReason_07 { get; set; }
        /// <summary>
        // Appointment Type
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AppointmentType AppointmentType_08 { get; set; }
        /// <summary>
        // Appointment Duration
        /// </summary>
        [DataMember]
        [DataElement("00868", typeof(HL7_N))]
        [Pos(9)]
        public virtual string AppointmentDuration_09 { get; set; }
        /// <summary>
        // Appointment Duration Units
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CodedWithNoExceptions AppointmentDurationUnits_10 { get; set; }
        /// <summary>
        // Appointment Timing Quantity
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Timingquantity> AppointmentTimingQuantity_11 { get; set; }
        /// <summary>
        // Placer Contact Person
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<ExtendedCompositeIDNumberAndName> PlacerContactPerson_12 { get; set; }
        /// <summary>
        // Placer Contact Phone Number
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ExtendedTelecommunicationsNumber PlacerContactPhoneNumber_13 { get; set; }
        /// <summary>
        // Placer Contact Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<ExtendedAddress> PlacerContactAddress_14 { get; set; }
        /// <summary>
        // Placer Contact Location
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual PersonLocation PlacerContactLocation_15 { get; set; }
        /// <summary>
        // Filler Contact Person
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<ExtendedCompositeIDNumberAndName> FillerContactPerson_16 { get; set; }
        /// <summary>
        // Filler Contact Phone Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual ExtendedTelecommunicationsNumber FillerContactPhoneNumber_17 { get; set; }
        /// <summary>
        // Filler Contact Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<ExtendedAddress> FillerContactAddress_18 { get; set; }
        /// <summary>
        // Filler Contact Location
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual PersonLocation FillerContactLocation_19 { get; set; }
        /// <summary>
        // Entered By Person
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<ExtendedCompositeIDNumberAndName> EnteredByPerson_20 { get; set; }
        /// <summary>
        // Entered By Phone Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<ExtendedTelecommunicationsNumber> EnteredByPhoneNumber_21 { get; set; }
        /// <summary>
        // Entered By Location
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual PersonLocation EnteredByLocation_22 { get; set; }
        /// <summary>
        // Parent Placer Appointment ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual ComprehensiveLocationIdentifier ParentPlacerAppointmentID_23 { get; set; }
        /// <summary>
        // Parent Filler Appointment ID
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual ComprehensiveLocationIdentifier ParentFillerAppointmentID_24 { get; set; }
        /// <summary>
        // Filler Status Code
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual FillerStatusCode FillerStatusCode_25 { get; set; }
        /// <summary>
        // Placer Order Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(26)]
        public virtual List<ComprehensiveLocationIdentifier> PlacerOrderNumber_26 { get; set; }
        /// <summary>
        // Filler Order Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(27)]
        public virtual List<ComprehensiveLocationIdentifier> FillerOrderNumber_27 { get; set; }
    }
    
    /// <summary>
    // Sterilizer Configuration Notification (Anti-Microbial Devices)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCP")]
    public class SCP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Number Of Decontamination/Sterilization Devices
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("02087", typeof(HL7_N))]
        [Pos(1)]
        public virtual string NumberOfDecontaminationSterilizationDevices_01 { get; set; }
        /// <summary>
        // Labor Calculation Type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LaborCalculationType LaborCalculationType_02 { get; set; }
        /// <summary>
        // Date Format
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DateFormat DateFormat_03 { get; set; }
        /// <summary>
        // Device Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier DeviceNumber_04 { get; set; }
        /// <summary>
        // Device Name
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("02279", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string DeviceName_05 { get; set; }
        /// <summary>
        // Device Model Name
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("02091", typeof(HL7_AN))]
        [Pos(6)]
        public virtual string DeviceModelName_06 { get; set; }
        /// <summary>
        // Device Type
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DeviceType DeviceType_07 { get; set; }
        /// <summary>
        // Lot Control
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LotControl LotControl_08 { get; set; }
    }
    
    /// <summary>
    // Sterilization Device Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SDD")]
    public class SDD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Lot Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier LotNumber_01 { get; set; }
        /// <summary>
        // Device Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier DeviceNumber_02 { get; set; }
        /// <summary>
        // Device Name
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("02281", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string DeviceName_03 { get; set; }
        /// <summary>
        // Device Data State
        /// </summary>
        [DataMember]
        [DataElement("02100", typeof(HL7_ID_667))]
        [Pos(4)]
        public virtual string DeviceDataState_04 { get; set; }
        /// <summary>
        // Load Status
        /// </summary>
        [DataMember]
        [DataElement("02101", typeof(HL7_ID_669))]
        [Pos(5)]
        public virtual string LoadStatus_05 { get; set; }
        /// <summary>
        // Control Code
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("02102", typeof(HL7_N))]
        [Pos(6)]
        public virtual string ControlCode_06 { get; set; }
        /// <summary>
        // Operator Name
        /// </summary>
        [DataMember]
        [StringLength(0, 15)]
        [DataElement("02103", typeof(HL7_AN))]
        [Pos(7)]
        public virtual string OperatorName_07 { get; set; }
    }
    
    /// <summary>
    // Software Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SFT")]
    public class SFT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Software Vendor Organization
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ExtendedCompositeNameAndIDNumberForOrganizations SoftwareVendorOrganization_01 { get; set; }
        /// <summary>
        // Software Certified Version or Release Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 15)]
        [DataElement("01835", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string SoftwareCertifiedVersionOrReleaseNumber_02 { get; set; }
        /// <summary>
        // Software Product Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("01836", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string SoftwareProductName_03 { get; set; }
        /// <summary>
        // Software Binary ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 20)]
        [DataElement("01837", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string SoftwareBinaryID_04 { get; set; }
        /// <summary>
        // Software Product Information
        /// </summary>
        [DataMember]
        [StringLength(0, 1024)]
        [DataElement("01838", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string SoftwareProductInformation_05 { get; set; }
        /// <summary>
        // Software Install Date
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01839", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string SoftwareInstallDate_06 { get; set; }
    }
    
    /// <summary>
    // Substance Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SID")]
    public class SID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Application/Method Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment ApplicationMethodIdentifier_01 { get; set; }
        /// <summary>
        // Substance Lot Number
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("01129", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string SubstanceLotNumber_02 { get; set; }
        /// <summary>
        // Substance Container Identifier
        /// </summary>
        [DataMember]
        [StringLength(0, 200)]
        [DataElement("01428", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string SubstanceContainerIdentifier_03 { get; set; }
        /// <summary>
        // Substance Manufacturer Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SubstanceManufacturerIdentifier SubstanceManufacturerIdentifier_04 { get; set; }
    }
    
    /// <summary>
    // Sterilization Lot
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SLT")]
    public class SLT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Device Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier DeviceNumber_01 { get; set; }
        /// <summary>
        // Device Name
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("02280", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string DeviceName_02 { get; set; }
        /// <summary>
        // Lot Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ComprehensiveLocationIdentifier LotNumber_03 { get; set; }
        /// <summary>
        // Item Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier ItemIdentifier_04 { get; set; }
        /// <summary>
        // Bar Code
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("02097", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string BarCode_05 { get; set; }
    }
    
    /// <summary>
    // Specimen
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPM")]
    public class SPM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - SPM
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01754", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDSPM_01 { get; set; }
        /// <summary>
        // Specimen ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EntityIdentifierPair SpecimenID_02 { get; set; }
        /// <summary>
        // Specimen Parent IDs
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<EntityIdentifierPair> SpecimenParentIDs_03 { get; set; }
        /// <summary>
        // Specimen Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual SpecimenType SpecimenType_04 { get; set; }
        /// <summary>
        // Specimen Type Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<SpecimenTypeModifier> SpecimenTypeModifier_05 { get; set; }
        /// <summary>
        // Specimen Additives
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<SpecimenAdditives> SpecimenAdditives_06 { get; set; }
        /// <summary>
        // Specimen Collection Method
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SpecimenCollectionMethod SpecimenCollectionMethod_07 { get; set; }
        /// <summary>
        // Specimen Source Site
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AssigningAgencyOrDepartment SpecimenSourceSite_08 { get; set; }
        /// <summary>
        // Specimen Source Site Modifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<SpecimenSourceSiteModifier> SpecimenSourceSiteModifier_09 { get; set; }
        /// <summary>
        // Specimen Collection Site
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SpecimenCollectionSite SpecimenCollectionSite_10 { get; set; }
        /// <summary>
        // Specimen Role
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<SpecimenRole> SpecimenRole_11 { get; set; }
        /// <summary>
        // Specimen Collection Amount
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Quantity SpecimenCollectionAmount_12 { get; set; }
        /// <summary>
        // Grouped Specimen Count
        /// </summary>
        [DataMember]
        [StringLength(0, 6)]
        [DataElement("01763", typeof(HL7_N))]
        [Pos(13)]
        public virtual string GroupedSpecimenCount_13 { get; set; }
        /// <summary>
        // Specimen Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 250)]
        [DataElement("01764", typeof(HL7_AN))]
        [Pos(14)]
        public virtual List<string> SpecimenDescription_14 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Specimen Handling Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<SpecimenHandlingCode> SpecimenHandlingCode_15 { get; set; }
        /// <summary>
        // Specimen Risk Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<SpecimenRiskCode> SpecimenRiskCode_16 { get; set; }
        /// <summary>
        // Specimen Collection Date/Time
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual NameValidityRange SpecimenCollectionDateTime_17 { get; set; }
        /// <summary>
        // Specimen Received Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00248", typeof(HL7_DTM))]
        [Pos(18)]
        public virtual string SpecimenReceivedDateTime_18 { get; set; }
        /// <summary>
        // Specimen Expiration Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01904", typeof(HL7_DTM))]
        [Pos(19)]
        public virtual string SpecimenExpirationDateTime_19 { get; set; }
        /// <summary>
        // Specimen Availability
        /// </summary>
        [DataMember]
        [DataElement("01766", typeof(HL7_ID_136))]
        [Pos(20)]
        public virtual string SpecimenAvailability_20 { get; set; }
        /// <summary>
        // Specimen Reject Reason
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<SpecimenRejectReason> SpecimenRejectReason_21 { get; set; }
        /// <summary>
        // Specimen Quality
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual SpecimenQuality SpecimenQuality_22 { get; set; }
        /// <summary>
        // Specimen Appropriateness
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual SpecimenAppropriateness SpecimenAppropriateness_23 { get; set; }
        /// <summary>
        // Specimen Condition
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<SpecimenCondition> SpecimenCondition_24 { get; set; }
        /// <summary>
        // Specimen Current Quantity
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual Quantity SpecimenCurrentQuantity_25 { get; set; }
        /// <summary>
        // Number of Specimen Containers
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01772", typeof(HL7_N))]
        [Pos(26)]
        public virtual string NumberOfSpecimenContainers_26 { get; set; }
        /// <summary>
        // Container Type
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual AssigningAgencyOrDepartment ContainerType_27 { get; set; }
        /// <summary>
        // Container Condition
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual ContainerCondition ContainerCondition_28 { get; set; }
        /// <summary>
        // Specimen Child Role
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual SpecimenChildRole SpecimenChildRole_29 { get; set; }
    }
    
    /// <summary>
    // Staff Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STF")]
    public class STF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary Key Value - STF
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment PrimaryKeyValueSTF_01 { get; set; }
        /// <summary>
        // Staff Identifier List
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<StaffIdentifierList> StaffIdentifierList_02 { get; set; }
        /// <summary>
        // Staff Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedPersonName> StaffName_03 { get; set; }
        /// <summary>
        // Staff Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 2)]
        [DataElement("00674", typeof(HL7_AN))]
        [Pos(4)]
        public virtual List<string> StaffType_04 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Administrative Sex
        /// </summary>
        [DataMember]
        [DataElement("00111", typeof(HL7_ID_1))]
        [Pos(5)]
        public virtual string AdministrativeSex_05 { get; set; }
        /// <summary>
        // Date/Time of Birth
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00110", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string DateTimeOfBirth_06 { get; set; }
        /// <summary>
        // Active/Inactive Flag
        /// </summary>
        [DataMember]
        [DataElement("00675", typeof(HL7_ID_183))]
        [Pos(7)]
        public virtual string ActiveInactiveFlag_07 { get; set; }
        /// <summary>
        // Department
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Department> Department_08 { get; set; }
        /// <summary>
        // Hospital Service - STF
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<TransferMedicalServiceCode> HospitalServiceSTF_09 { get; set; }
        /// <summary>
        // Phone
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedTelecommunicationsNumber> Phone_10 { get; set; }
        /// <summary>
        // Office/Home Address/Birthplace
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedAddress> OfficeHomeAddressBirthplace_11 { get; set; }
        /// <summary>
        // Institution Activation Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<DateAndInstitutionName> InstitutionActivationDate_12 { get; set; }
        /// <summary>
        // Institution Inactivation Date
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<DateAndInstitutionName> InstitutionInactivationDate_13 { get; set; }
        /// <summary>
        // Backup Person ID
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<AssigningAgencyOrDepartment> BackupPersonID_14 { get; set; }
        /// <summary>
        // E-Mail Address
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 40)]
        [DataElement("00683", typeof(HL7_AN))]
        [Pos(15)]
        public virtual List<string> EMailAddress_15 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Preferred Method of Contact
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual ProviderOrganizationMethodOfContact PreferredMethodOfContact_16 { get; set; }
        /// <summary>
        // Marital Status
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual GuarantorMaritalStatusCode MaritalStatus_17 { get; set; }
        /// <summary>
        // Job Title
        /// </summary>
        [DataMember]
        [StringLength(0, 20)]
        [DataElement("00785", typeof(HL7_AN))]
        [Pos(18)]
        public virtual string JobTitle_18 { get; set; }
        /// <summary>
        // Job Code/Class
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual JobCodeclass JobCodeClass_19 { get; set; }
        /// <summary>
        // Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual EmploymentStatusCode EmploymentStatusCode_20 { get; set; }
        /// <summary>
        // Additional Insured on Auto
        /// </summary>
        [DataMember]
        [DataElement("01275", typeof(HL7_ID_136))]
        [Pos(21)]
        public virtual string AdditionalInsuredOnAuto_21 { get; set; }
        /// <summary>
        // Driver's License Number - Staff
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual DriversLicenseNumber DriversLicenseNumberStaff_22 { get; set; }
        /// <summary>
        // Copy Auto Ins
        /// </summary>
        [DataMember]
        [DataElement("01229", typeof(HL7_ID_136))]
        [Pos(23)]
        public virtual string CopyAutoIns_23 { get; set; }
        /// <summary>
        // Auto Ins Expires
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01232", typeof(HL7_DT))]
        [Pos(24)]
        public virtual string AutoInsExpires_24 { get; set; }
        /// <summary>
        // Date Last DMV Review
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01298", typeof(HL7_DT))]
        [Pos(25)]
        public virtual string DateLastDMVReview_25 { get; set; }
        /// <summary>
        // Date Next DMV Review
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01234", typeof(HL7_DT))]
        [Pos(26)]
        public virtual string DateNextDMVReview_26 { get; set; }
        /// <summary>
        // Race
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual GuarantorRace Race_27 { get; set; }
        /// <summary>
        // Ethnic Group
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual EthnicGroup EthnicGroup_28 { get; set; }
        /// <summary>
        // Re-activation Approval Indicator
        /// </summary>
        [DataMember]
        [DataElement("01596", typeof(HL7_ID_136))]
        [Pos(29)]
        public virtual string ReactivationApprovalIndicator_29 { get; set; }
        /// <summary>
        // Citizenship
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(30)]
        public virtual List<TribalCitizenship> Citizenship_30 { get; set; }
        /// <summary>
        // Date/Time of Death
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01886", typeof(HL7_DTM))]
        [Pos(31)]
        public virtual string DateTimeOfDeath_31 { get; set; }
        /// <summary>
        // Death Indicator
        /// </summary>
        [DataMember]
        [DataElement("01887", typeof(HL7_ID_136))]
        [Pos(32)]
        public virtual string DeathIndicator_32 { get; set; }
        /// <summary>
        // Institution Relationship Type Code
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual InstitutionRelationshipTypeCode InstitutionRelationshipTypeCode_33 { get; set; }
        /// <summary>
        // Institution Relationship Period
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual NameValidityRange InstitutionRelationshipPeriod_34 { get; set; }
        /// <summary>
        // Expected Return Date
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("01890", typeof(HL7_DT))]
        [Pos(35)]
        public virtual string ExpectedReturnDate_35 { get; set; }
        /// <summary>
        // Cost Center Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(36)]
        public virtual List<CostCenterCode> CostCenterCode_36 { get; set; }
        /// <summary>
        // Generic Classification Indicator
        /// </summary>
        [DataMember]
        [DataElement("01892", typeof(HL7_ID_136))]
        [Pos(37)]
        public virtual string GenericClassificationIndicator_37 { get; set; }
        /// <summary>
        // Inactive Reason Code
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual InactiveReasonCode InactiveReasonCode_38 { get; set; }
        /// <summary>
        // Generic resource type or category
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(39)]
        public virtual List<GenericResourceTypeOrCategory> GenericResourceTypeOrCategory_39 { get; set; }
    }
    
    /// <summary>
    // Sterilization Parameter
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STZ")]
    public class STZ
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sterilization Type
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SterilizationType SterilizationType_01 { get; set; }
        /// <summary>
        // Sterilization Cycle
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AssigningAgencyOrDepartment SterilizationCycle_02 { get; set; }
        /// <summary>
        // Maintenance Cycle
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual MaintenanceCycle MaintenanceCycle_03 { get; set; }
        /// <summary>
        // Maintenance Type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MaintenanceType MaintenanceType_04 { get; set; }
    }
    
    /// <summary>
    // Test Code Configuration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TCC")]
    public class TCC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Universal Service Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment UniversalServiceIdentifier_01 { get; set; }
        /// <summary>
        // Equipment Test Application Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier EquipmentTestApplicationIdentifier_02 { get; set; }
        /// <summary>
        // Specimen Source
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SpecimenSource SpecimenSource_03 { get; set; }
        /// <summary>
        // Auto-Dilution Factor Default
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual StructuredNumeric AutoDilutionFactorDefault_04 { get; set; }
        /// <summary>
        // Rerun Dilution Factor Default
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual StructuredNumeric RerunDilutionFactorDefault_05 { get; set; }
        /// <summary>
        // Pre-Dilution Factor Default
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual StructuredNumeric PreDilutionFactorDefault_06 { get; set; }
        /// <summary>
        // Endogenous Content of Pre-Dilution Diluent
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual StructuredNumeric EndogenousContentOfPreDilutionDiluent_07 { get; set; }
        /// <summary>
        // Inventory Limits Warning Level
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01414", typeof(HL7_N))]
        [Pos(8)]
        public virtual string InventoryLimitsWarningLevel_08 { get; set; }
        /// <summary>
        // Automatic Rerun Allowed
        /// </summary>
        [DataMember]
        [DataElement("01415", typeof(HL7_ID_136))]
        [Pos(9)]
        public virtual string AutomaticRerunAllowed_09 { get; set; }
        /// <summary>
        // Automatic Repeat Allowed
        /// </summary>
        [DataMember]
        [DataElement("01416", typeof(HL7_ID_136))]
        [Pos(10)]
        public virtual string AutomaticRepeatAllowed_10 { get; set; }
        /// <summary>
        // Automatic Reflex Allowed
        /// </summary>
        [DataMember]
        [DataElement("01417", typeof(HL7_ID_136))]
        [Pos(11)]
        public virtual string AutomaticReflexAllowed_11 { get; set; }
        /// <summary>
        // Equipment Dynamic Range
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual StructuredNumeric EquipmentDynamicRange_12 { get; set; }
        /// <summary>
        // Units
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual AssigningAgencyOrDepartment Units_13 { get; set; }
        /// <summary>
        // Processing Type
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual ProcessingType ProcessingType_14 { get; set; }
    }
    
    /// <summary>
    // Test Code Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TCD")]
    public class TCD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Universal Service Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment UniversalServiceIdentifier_01 { get; set; }
        /// <summary>
        // Auto-Dilution Factor
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual StructuredNumeric AutoDilutionFactor_02 { get; set; }
        /// <summary>
        // Rerun Dilution Factor
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual StructuredNumeric RerunDilutionFactor_03 { get; set; }
        /// <summary>
        // Pre-Dilution Factor
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual StructuredNumeric PreDilutionFactor_04 { get; set; }
        /// <summary>
        // Endogenous Content of Pre-Dilution Diluent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual StructuredNumeric EndogenousContentOfPreDilutionDiluent_05 { get; set; }
        /// <summary>
        // Automatic Repeat Allowed
        /// </summary>
        [DataMember]
        [DataElement("01416", typeof(HL7_ID_136))]
        [Pos(6)]
        public virtual string AutomaticRepeatAllowed_06 { get; set; }
        /// <summary>
        // Reflex Allowed
        /// </summary>
        [DataMember]
        [DataElement("01424", typeof(HL7_ID_136))]
        [Pos(7)]
        public virtual string ReflexAllowed_07 { get; set; }
        /// <summary>
        // Analyte Repeat Status
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AnalyteRepeatStatus AnalyteRepeatStatus_08 { get; set; }
    }
    
    /// <summary>
    // Timing/Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TQ1")]
    public class TQ1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - TQ1
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01627", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDTQ_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Quantity Quantity_02 { get; set; }
        /// <summary>
        // Repeat Pattern
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<RepeatPattern> RepeatPattern_03 { get; set; }
        /// <summary>
        // Explicit Time
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("01630", typeof(HL7_TM))]
        [Pos(4)]
        public virtual List<string> ExplicitTime_04 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Relative Time and Units
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Quantity> RelativeTimeAndUnits_05 { get; set; }
        /// <summary>
        // Service Duration
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Quantity ServiceDuration_06 { get; set; }
        /// <summary>
        // Start date/time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01633", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string StartDatetime_07 { get; set; }
        /// <summary>
        // End date/time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01634", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual string EndDatetime_08 { get; set; }
        /// <summary>
        // Priority
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Priority> Priority_09 { get; set; }
        /// <summary>
        // Condition text
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01636", typeof(HL7_AN))]
        [Pos(10)]
        public virtual string ConditionText_10 { get; set; }
        /// <summary>
        // Text instruction
        /// </summary>
        [DataMember]
        [StringLength(0, 250)]
        [DataElement("01637", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string TextInstruction_11 { get; set; }
        /// <summary>
        // Conjunction
        /// </summary>
        [DataMember]
        [DataElement("01638", typeof(HL7_ID_472))]
        [Pos(12)]
        public virtual string Conjunction_12 { get; set; }
        /// <summary>
        // Occurrence duration
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual Quantity OccurrenceDuration_13 { get; set; }
        /// <summary>
        // Total occurrences
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01640", typeof(HL7_N))]
        [Pos(14)]
        public virtual string TotalOccurrences_14 { get; set; }
    }
    
    /// <summary>
    // Timing/Quantity Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TQ2")]
    public class TQ2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - TQ2
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("01648", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDTQ_01 { get; set; }
        /// <summary>
        // Sequence/Results Flag
        /// </summary>
        [DataMember]
        [DataElement("01649", typeof(HL7_ID_503))]
        [Pos(2)]
        public virtual string SequenceResultsFlag_02 { get; set; }
        /// <summary>
        // Related Placer Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ComprehensiveLocationIdentifier> RelatedPlacerNumber_03 { get; set; }
        /// <summary>
        // Related Filler Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ComprehensiveLocationIdentifier> RelatedFillerNumber_04 { get; set; }
        /// <summary>
        // Related Placer Group Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ComprehensiveLocationIdentifier> RelatedPlacerGroupNumber_05 { get; set; }
        /// <summary>
        // Sequence Condition Code
        /// </summary>
        [DataMember]
        [DataElement("01653", typeof(HL7_ID_504))]
        [Pos(6)]
        public virtual string SequenceConditionCode_06 { get; set; }
        /// <summary>
        // Cyclic Entry/Exit Indicator
        /// </summary>
        [DataMember]
        [DataElement("01654", typeof(HL7_ID_505))]
        [Pos(7)]
        public virtual string CyclicEntryExitIndicator_07 { get; set; }
        /// <summary>
        // Sequence Condition Time Interval
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Quantity SequenceConditionTimeInterval_08 { get; set; }
        /// <summary>
        // Cyclic Group Maximum Number of Repeats
        /// </summary>
        [DataMember]
        [StringLength(0, 10)]
        [DataElement("01656", typeof(HL7_N))]
        [Pos(9)]
        public virtual string CyclicGroupMaximumNumberOfRepeats_09 { get; set; }
        /// <summary>
        // Special Service Request Relationship
        /// </summary>
        [DataMember]
        [DataElement("01657", typeof(HL7_ID_506))]
        [Pos(10)]
        public virtual string SpecialServiceRequestRelationship_10 { get; set; }
    }
    
    /// <summary>
    // Transcription Document Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TXA")]
    public class TXA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID- TXA
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 4)]
        [DataElement("00914", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDTXA_01 { get; set; }
        /// <summary>
        // Document Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00915", typeof(HL7_ID_270))]
        [Pos(2)]
        public virtual string DocumentType_02 { get; set; }
        /// <summary>
        // Document Content Presentation
        /// </summary>
        [DataMember]
        [DataElement("00916", typeof(HL7_ID_191))]
        [Pos(3)]
        public virtual string DocumentContentPresentation_03 { get; set; }
        /// <summary>
        // Activity Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00917", typeof(HL7_DTM))]
        [Pos(4)]
        public virtual string ActivityDateTime_04 { get; set; }
        /// <summary>
        // Primary Activity Provider Code/Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ExtendedCompositeIDNumberAndName> PrimaryActivityProviderCodeName_05 { get; set; }
        /// <summary>
        // Origination Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00919", typeof(HL7_DTM))]
        [Pos(6)]
        public virtual string OriginationDateTime_06 { get; set; }
        /// <summary>
        // Transcription Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00920", typeof(HL7_DTM))]
        [Pos(7)]
        public virtual string TranscriptionDateTime_07 { get; set; }
        /// <summary>
        // Edit Date/Time
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 24)]
        [DataElement("00921", typeof(HL7_DTM))]
        [Pos(8)]
        public virtual List<string> EditDateTime_08 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Originator Code/Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ExtendedCompositeIDNumberAndName> OriginatorCodeName_09 { get; set; }
        /// <summary>
        // Assigned Document Authenticator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<ExtendedCompositeIDNumberAndName> AssignedDocumentAuthenticator_10 { get; set; }
        /// <summary>
        // Transcriptionist Code/Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ExtendedCompositeIDNumberAndName> TranscriptionistCodeName_11 { get; set; }
        /// <summary>
        // Unique Document Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual ComprehensiveLocationIdentifier UniqueDocumentNumber_12 { get; set; }
        /// <summary>
        // Parent Document Number
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual ComprehensiveLocationIdentifier ParentDocumentNumber_13 { get; set; }
        /// <summary>
        // Placer Order Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<ComprehensiveLocationIdentifier> PlacerOrderNumber_14 { get; set; }
        /// <summary>
        // Filler Order Number
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual ComprehensiveLocationIdentifier FillerOrderNumber_15 { get; set; }
        /// <summary>
        // Unique Document File Name
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00927", typeof(HL7_AN))]
        [Pos(16)]
        public virtual string UniqueDocumentFileName_16 { get; set; }
        /// <summary>
        // Document Completion Status
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("00928", typeof(HL7_ID_271))]
        [Pos(17)]
        public virtual string DocumentCompletionStatus_17 { get; set; }
        /// <summary>
        // Document Confidentiality Status
        /// </summary>
        [DataMember]
        [DataElement("00929", typeof(HL7_ID_272))]
        [Pos(18)]
        public virtual string DocumentConfidentialityStatus_18 { get; set; }
        /// <summary>
        // Document Availability Status
        /// </summary>
        [DataMember]
        [DataElement("00930", typeof(HL7_ID_273))]
        [Pos(19)]
        public virtual string DocumentAvailabilityStatus_19 { get; set; }
        /// <summary>
        // Document Storage Status
        /// </summary>
        [DataMember]
        [DataElement("00932", typeof(HL7_ID_275))]
        [Pos(20)]
        public virtual string DocumentStorageStatus_20 { get; set; }
        /// <summary>
        // Document Change Reason
        /// </summary>
        [DataMember]
        [StringLength(0, 30)]
        [DataElement("00933", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string DocumentChangeReason_21 { get; set; }
        /// <summary>
        // Authentication Person
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<PerformingPersonTimeStamp> AuthenticationPerson_22 { get; set; }
        /// <summary>
        // Distributed Copies (Code and Name of Recipient(s) )
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(23)]
        public virtual List<ExtendedCompositeIDNumberAndName> DistributedCopies_23 { get; set; }
    }
    
    /// <summary>
    // UB82
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UB1")]
    public class UB1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - UB1
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00530", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDUB_01 { get; set; }
        [DataMember]
        [DataElement("00531", typeof(ANY))]
        [Pos(2)]
        public virtual string UB102 { get; set; }
        /// <summary>
        // Blood Furnished-Pints (40)
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00532", typeof(HL7_N))]
        [Pos(3)]
        public virtual string BloodFurnishedPints_03 { get; set; }
        /// <summary>
        // Blood Replaced-Pints (41)
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00533", typeof(HL7_N))]
        [Pos(4)]
        public virtual string BloodReplacedPints_04 { get; set; }
        /// <summary>
        // Blood Not Replaced-Pints (42)
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00534", typeof(HL7_N))]
        [Pos(5)]
        public virtual string BloodNotReplacedPints_05 { get; set; }
        /// <summary>
        // Co-Insurance Days (25)
        /// </summary>
        [DataMember]
        [DataElement("00535", typeof(HL7_N))]
        [Pos(6)]
        public virtual string CoInsuranceDays_06 { get; set; }
        /// <summary>
        // Condition Code (35-39)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("00536", typeof(HL7_AN))]
        [Pos(7)]
        public virtual List<string> ConditionCode_07 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Covered Days (23)
        /// </summary>
        [DataMember]
        [DataElement("00537", typeof(HL7_N))]
        [Pos(8)]
        public virtual string CoveredDays_08 { get; set; }
        /// <summary>
        // Non Covered Days (24)
        /// </summary>
        [DataMember]
        [DataElement("00538", typeof(HL7_N))]
        [Pos(9)]
        public virtual string NonCoveredDays_09 { get; set; }
        /// <summary>
        // Value Amount & Code (46-49)
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(10)]
        public virtual List<UBValueCodeAndAmount> ValueAmountCode_10 { get; set; }
        /// <summary>
        // Number Of Grace Days (90)
        /// </summary>
        [DataMember]
        [StringLength(0, 2)]
        [DataElement("00540", typeof(HL7_N))]
        [Pos(11)]
        public virtual string NumberOfGraceDays_11 { get; set; }
        /// <summary>
        // Special Program Indicator (44)
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SpecialProgramIndicator SpecialProgramIndicator_12 { get; set; }
        /// <summary>
        // PSRO/UR Approval Indicator (87)
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual PSROURApprovalIndicator PSROURApprovalIndicator_13 { get; set; }
        /// <summary>
        // PSRO/UR Approved Stay-Fm (88)
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00543", typeof(HL7_DT))]
        [Pos(14)]
        public virtual string PSROURApprovedStayFm_14 { get; set; }
        /// <summary>
        // PSRO/UR Approved Stay-To (89)
        /// </summary>
        [DataMember]
        [StringLength(0, 8)]
        [DataElement("00544", typeof(HL7_DT))]
        [Pos(15)]
        public virtual string PSROURApprovedStayTo_15 { get; set; }
        /// <summary>
        // Occurrence (28-32)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(16)]
        public virtual List<OccurrenceCodeAndDate> Occurrence_16 { get; set; }
        /// <summary>
        // Occurrence Span (33)
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual OccurrenceSpan OccurrenceSpan_17 { get; set; }
        /// <summary>
        // Occur Span Start Date (33)
        /// </summary>
        [DataMember]
        [DataElement("00547", typeof(HL7_DT))]
        [Pos(18)]
        public virtual string OccurSpanStartDate_18 { get; set; }
        /// <summary>
        // Occur Span End Date (33)
        /// </summary>
        [DataMember]
        [DataElement("00548", typeof(HL7_DT))]
        [Pos(19)]
        public virtual string OccurSpanEndDate_19 { get; set; }
        /// <summary>
        // UB-82 Locator (2)
        /// </summary>
        [DataMember]
        [DataElement("00549", typeof(HL7_AN))]
        [Pos(20)]
        public virtual string UBLocator_20 { get; set; }
        /// <summary>
        // UB-82 Locator (9)
        /// </summary>
        [DataMember]
        [DataElement("00550", typeof(HL7_AN))]
        [Pos(21)]
        public virtual string UBLocator_21 { get; set; }
        /// <summary>
        // UB-82 Locator (27)
        /// </summary>
        [DataMember]
        [DataElement("00551", typeof(HL7_AN))]
        [Pos(22)]
        public virtual string UBLocator_22 { get; set; }
        /// <summary>
        // UB-82 Locator (45)
        /// </summary>
        [DataMember]
        [DataElement("00552", typeof(HL7_AN))]
        [Pos(23)]
        public virtual string UBLocator_23 { get; set; }
    }
    
    /// <summary>
    // UB92 Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UB2")]
    public class UB2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - UB2
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00553", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDUB_01 { get; set; }
        /// <summary>
        // Co-Insurance Days (9)
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00554", typeof(HL7_AN))]
        [Pos(2)]
        public virtual string CoInsuranceDays_02 { get; set; }
        /// <summary>
        // Condition Code (24-30)
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [StringLength(0, 2)]
        [DataElement("00555", typeof(HL7_AN))]
        [Pos(3)]
        public virtual List<string> ConditionCode_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Covered Days (7)
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00556", typeof(HL7_AN))]
        [Pos(4)]
        public virtual string CoveredDays_04 { get; set; }
        /// <summary>
        // Non-Covered Days (8)
        /// </summary>
        [DataMember]
        [StringLength(0, 4)]
        [DataElement("00557", typeof(HL7_AN))]
        [Pos(5)]
        public virtual string NonCoveredDays_05 { get; set; }
        /// <summary>
        // Value Amount & Code
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(6)]
        public virtual List<UBValueCodeAndAmount> ValueAmountCode_06 { get; set; }
        /// <summary>
        // Occurrence Code & Date (32-35)
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(7)]
        public virtual List<OccurrenceCodeAndDate> OccurrenceCodeDate_07 { get; set; }
        /// <summary>
        // Occurrence Span Code/Dates (36)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<OccurrenceSpanCodeAndDate> OccurrenceSpanCodeDates_08 { get; set; }
        /// <summary>
        // UB92 Locator 2 (State)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(0, 29)]
        [DataElement("00561", typeof(HL7_AN))]
        [Pos(9)]
        public virtual List<string> UBLocator_09 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // UB92 Locator 11 (State)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(0, 12)]
        [DataElement("00562", typeof(HL7_AN))]
        [Pos(10)]
        public virtual List<string> UBLocator_10 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // UB92 Locator 31 (National)
        /// </summary>
        [DataMember]
        [StringLength(0, 5)]
        [DataElement("00563", typeof(HL7_AN))]
        [Pos(11)]
        public virtual string UBLocator_11 { get; set; }
        /// <summary>
        // Document Control Number
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [StringLength(0, 23)]
        [DataElement("00564", typeof(HL7_AN))]
        [Pos(12)]
        public virtual List<string> DocumentControlNumber_12 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // UB92 Locator 49 (National)
        /// </summary>
        [DataMember]
        [ListCount(23)]
        [StringLength(0, 4)]
        [DataElement("00565", typeof(HL7_AN))]
        [Pos(13)]
        public virtual List<string> UBLocator_13 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // UB92 Locator 56 (State)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [StringLength(0, 14)]
        [DataElement("00566", typeof(HL7_AN))]
        [Pos(14)]
        public virtual List<string> UBLocator_14 
        {
            get { return _stringList6; }
            set { _stringList6 = value; }
        }

        private List<string> _stringList6 { get; set; }
        public virtual string StringList6
        {
            get
            {
                if (_stringList6 != null)
                    return string.Join("^", _stringList6);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList6 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // UB92 Locator 57 (National)
        /// </summary>
        [DataMember]
        [StringLength(0, 27)]
        [DataElement("00567", typeof(HL7_AN))]
        [Pos(15)]
        public virtual string UBLocator_15 { get; set; }
        /// <summary>
        // UB92 Locator 78 (State)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(0, 2)]
        [DataElement("00568", typeof(HL7_AN))]
        [Pos(16)]
        public virtual List<string> UBLocator_16 
        {
            get { return _stringList7; }
            set { _stringList7 = value; }
        }

        private List<string> _stringList7 { get; set; }
        public virtual string StringList7
        {
            get
            {
                if (_stringList7 != null)
                    return string.Join("^", _stringList7);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList7 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Special Visit Count
        /// </summary>
        [DataMember]
        [StringLength(0, 3)]
        [DataElement("00815", typeof(HL7_N))]
        [Pos(17)]
        public virtual string SpecialVisitCount_17 { get; set; }
    }
    
    /// <summary>
    // Results/update Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("URD")]
    public class URD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // R/U Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00045", typeof(HL7_DTM))]
        [Pos(1)]
        public virtual string RUDateTime_01 { get; set; }
        /// <summary>
        // Report Priority
        /// </summary>
        [DataMember]
        [DataElement("00046", typeof(HL7_ID_109))]
        [Pos(2)]
        public virtual string ReportPriority_02 { get; set; }
        /// <summary>
        // R/U Who Subject Definition
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ExtendedCompositeIDNumberAndName> RUWhoSubjectDefinition_03 { get; set; }
        /// <summary>
        // R/U What Subject Definition
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<RUWhatSubjectDefinition> RUWhatSubjectDefinition_04 { get; set; }
        /// <summary>
        // R/U What Department Code
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AssigningAgencyOrDepartment> RUWhatDepartmentCode_05 { get; set; }
        /// <summary>
        // R/U Display/Print Locations
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("00050", typeof(HL7_AN))]
        [Pos(6)]
        public virtual List<string> RUDisplayPrintLocations_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U Results Level
        /// </summary>
        [DataMember]
        [DataElement("00051", typeof(HL7_ID_108))]
        [Pos(7)]
        public virtual string RUResultsLevel_07 { get; set; }
    }
    
    /// <summary>
    // Unsolicited Selection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("URS")]
    public class URS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // R/U Where Subject Definition
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("00052", typeof(HL7_AN))]
        [Pos(1)]
        public virtual List<string> RUWhereSubjectDefinition_01 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U When Data Start Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00053", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string RUWhenDataStartDateTime_02 { get; set; }
        /// <summary>
        // R/U When Data End Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("00054", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string RUWhenDataEndDateTime_03 { get; set; }
        /// <summary>
        // R/U What User Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("00055", typeof(HL7_AN))]
        [Pos(4)]
        public virtual List<string> RUWhatUserQualifier_04 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U Other Results Subject Definition
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 20)]
        [DataElement("00056", typeof(HL7_AN))]
        [Pos(5)]
        public virtual List<string> RUOtherResultsSubjectDefinition_05 
        {
            get { return _stringList3; }
            set { _stringList3 = value; }
        }

        private List<string> _stringList3 { get; set; }
        public virtual string StringList3
        {
            get
            {
                if (_stringList3 != null)
                    return string.Join("^", _stringList3);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList3 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U Which Date/Time Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00057", typeof(HL7_ID_156))]
        [Pos(6)]
        public virtual List<string> RUWhichDateTimeQualifier_06 
        {
            get { return _stringList4; }
            set { _stringList4 = value; }
        }

        private List<string> _stringList4 { get; set; }
        public virtual string StringList4
        {
            get
            {
                if (_stringList4 != null)
                    return string.Join("^", _stringList4);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList4 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U Which Date/Time Status Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00058", typeof(HL7_ID_157))]
        [Pos(7)]
        public virtual List<string> RUWhichDateTimeStatusQualifier_07 
        {
            get { return _stringList5; }
            set { _stringList5 = value; }
        }

        private List<string> _stringList5 { get; set; }
        public virtual string StringList5
        {
            get
            {
                if (_stringList5 != null)
                    return string.Join("^", _stringList5);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList5 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U Date/Time Selection Qualifier
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [DataElement("00059", typeof(HL7_ID_158))]
        [Pos(8)]
        public virtual List<string> RUDateTimeSelectionQualifier_08 
        {
            get { return _stringList6; }
            set { _stringList6 = value; }
        }

        private List<string> _stringList6 { get; set; }
        public virtual string StringList6
        {
            get
            {
                if (_stringList6 != null)
                    return string.Join("^", _stringList6);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList6 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // R/U Quantity/Timing Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Timingquantity RUQuantityTimingQualifier_09 { get; set; }
    }
    
    /// <summary>
    // User Authentication Credential Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UAC")]
    public class UAC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // User Authentication Credential Type Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual UserAuthenticationCredentialTypeCode UserAuthenticationCredentialTypeCode_01 { get; set; }
        /// <summary>
        // User Authentication Credential
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual EncapsulatedData UserAuthenticationCredential_02 { get; set; }
    }
    
    /// <summary>
    // Variance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VAR")]
    public class VAR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Variance Instance ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ComprehensiveLocationIdentifier VarianceInstanceID_01 { get; set; }
        /// <summary>
        // Documented Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 24)]
        [DataElement("01213", typeof(HL7_DTM))]
        [Pos(2)]
        public virtual string DocumentedDateTime_02 { get; set; }
        /// <summary>
        // Stated Variance Date/Time
        /// </summary>
        [DataMember]
        [StringLength(0, 24)]
        [DataElement("01214", typeof(HL7_DTM))]
        [Pos(3)]
        public virtual string StatedVarianceDateTime_03 { get; set; }
        /// <summary>
        // Variance Originator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<ExtendedCompositeIDNumberAndName> VarianceOriginator_04 { get; set; }
        /// <summary>
        // Variance Classification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AssigningAgencyOrDepartment VarianceClassification_05 { get; set; }
        /// <summary>
        // Variance Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [StringLength(0, 512)]
        [DataElement("01217", typeof(HL7_AN))]
        [Pos(6)]
        public virtual List<string> VarianceDescription_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Purchasing Vendor
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VND")]
    public class VND
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Set ID - VND
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 2)]
        [DataElement("02217", typeof(HL7_AN))]
        [Pos(1)]
        public virtual string SetIDVND_01 { get; set; }
        /// <summary>
        // Vendor Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ComprehensiveLocationIdentifier VendorIdentifier_02 { get; set; }
        /// <summary>
        // Vendor Name
        /// </summary>
        [DataMember]
        [StringLength(0, 999)]
        [DataElement("02276", typeof(HL7_AN))]
        [Pos(3)]
        public virtual string VendorName_03 { get; set; }
        /// <summary>
        // Vendor Catalog Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ComprehensiveLocationIdentifier VendorCatalogNumber_04 { get; set; }
        /// <summary>
        // Primary Vendor Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DefaultOrderUnitOfMeasureIndicator PrimaryVendorIndicator_05 { get; set; }
    }
    
    /// <summary>
    // ZL7 Segment (Proposed Example Only)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ZL7")]
    public class ZL7
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Primary key value - ZL7
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AssigningAgencyOrDepartment PrimaryKeyValueZL_01 { get; set; }
        /// <summary>
        // Display-sort-key
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(0, 3)]
        [DataElement("19998", typeof(HL7_N))]
        [Pos(2)]
        public virtual string Displaysortkey_02 { get; set; }
    }
}
