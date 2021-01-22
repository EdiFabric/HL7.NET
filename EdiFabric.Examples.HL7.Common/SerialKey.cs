﻿using System;
using System.IO;

namespace EdiFabric.Examples.HL7.Common
{
    public class SerialKey
    {
        private static string _serialKey = null;
        static SerialKey()
        {
            var serialKeyPath = @"../../../../edifabric-trial/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.HL7.Common, file SerialKey.cs!");

            _serialKey = File.ReadAllText(serialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }

        public static string Get()
        {
            return _serialKey;
        }
    }
}
