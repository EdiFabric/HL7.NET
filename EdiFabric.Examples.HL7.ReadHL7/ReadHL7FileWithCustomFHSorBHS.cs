using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Hl7;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hl726;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ReadHL7
{
    class ReadHL7FileWithCustomFHSorBHS
    {
        /// <summary>
        /// Read with custom FHS or BHS.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\MixedTransactions.txt");

            //  Use the base Hl7ReaderBase instead of Hl7Reader
            List<IEdiItem> hl7Items;
            using (var hl7Reader = new Hl7ReaderBase<FHSCustom, BHSCustom>(hl7Stream, "EdiFabric.Templates.Hl7"))
                hl7Items = hl7Reader.ReadToEnd().ToList();

            var fhs = hl7Items.OfType<FHSCustom>();
            var bhs = hl7Items.OfType<BHSCustom>();
        }
    }

    public class FHSCustom : FHS
    {
    }

    public class BHSCustom : BHS
    {
    }
}
