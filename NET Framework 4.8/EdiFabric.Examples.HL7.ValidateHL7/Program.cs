using EdiFabric.Examples.HL7.Common;
using System;

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Validate custom EDI codes
            ValidateCustomHL7Codes.Run();
            ValidateCustomHL7Codes.Run2();

            //  Validate transactions 
            ValidateHL7Transations.Run();

            //  Validate transactions with custom code
            ValidateHL7TransationsWithCustomCode.Run();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Default();

            //  Validate control segments, FHS and BHS
            ValidateFHSorBHS.Run();

            //  Validate async
            ValidateHL7TransationsAsync.Run();
        }
    }
}
