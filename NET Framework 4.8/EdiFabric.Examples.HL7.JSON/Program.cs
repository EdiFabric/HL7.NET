﻿using EdiFabric.Examples.HL7.Common;

namespace EdiFabric.Examples.HL7.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
