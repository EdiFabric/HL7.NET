using EdiFabric.Examples.HL7.Common;
using System;

namespace EdiFabric.Examples.HL7.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            License.EnsureToken(Config.TrialSerialKey, 3600);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
