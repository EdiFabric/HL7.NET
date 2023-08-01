using EdiFabric.Examples.HL7.Common;

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

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
