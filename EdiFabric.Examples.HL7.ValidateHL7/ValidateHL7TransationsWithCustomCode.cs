using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
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

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class ValidateHL7TransationsWithCustomCode
    {
        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\MedicalRecord.txt");

            //  The custom validation logic is applied in the template by implementing IEdiValidator.
            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7Reader(hl7Stream, (FHS fhs, BHS bhs, MSH msh) => typeof(TSMDMT02CustomValidation).GetTypeInfo()))
                hl7Items = hl7Reader.ReadToEnd().ToList();

            //  Get the dispense
            var dispense = hl7Items.OfType<TSMDMT02CustomValidation>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!dispense.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Message == "NTE segment is missing.");
                Debug.WriteLine(customValidation.Message);
            }
        }
    }

    /// <summary>
    /// New validation attribute to apply to OBX loops
    /// Validates that if OBX segment exists, then NTE segment must also exists, otherwise throws an exception
    /// Preserves the position of the missing segment within the loop, to allow the correct index to be applied in the acknowledgment
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class OBXLoopValidationAttribute : ValidationAttribute
    {
        public OBXLoopValidationAttribute() : base(10, ValidationLevel.InterSegment_SNIP4)
        {
        }

        public override SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            var position = validationContext.SegmentIndex + 1;

            var obxLoops = validationContext.InstanceContext.Instance as IList<Loop_OBX_TSMDMT02>;
            if (obxLoops != null)
            {
                foreach (var obxLoop in obxLoops)
                {
                    //  Check if OBX exists and NTE also exist
                    if (obxLoop.OBX != null && (obxLoop.NTE == null || obxLoop.NTE.Count == 0))
                        return new SegmentErrorContext("NTE", validationContext.SegmentIndex + 1, null, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                            "NTE segment is missing.");

                    return null;
                }
            }

            return null;
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("HL7", "MDMT02")]
    public class TSMDMT02CustomValidation : TSMDMT02
    {
        [OBXLoopValidation]
        [DataMember]
        [Required]
        [Pos(9)]
        public new List<Loop_OBX_TSMDMT02> LoopOBX { get; set; }
    }
}
