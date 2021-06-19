using EdiFabric.Core.Model.Hl7;
using EdiFabric.Framework.Readers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.HL7.ValidateHL7
{
    class ValidateFHSorBHS
    {
        /// <summary>
        /// Validate the typed control segments
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream hl7Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\MixedTransactions.txt");

            using (var hl7Reader = new Hl7Reader(hl7Stream, "EdiFabric.Templates.Hl7"))
            {
                while (hl7Reader.Read())
                {
                    var fhs = hl7Reader.Item as FHS;
                    if (fhs != null)
                    {
                        //  Validate 
                        var fhsErrors = fhs.Validate();
                        //  Pull the sending application from FHS
                        var senderId = fhs.FileSendingApplication_03.NamespaceID_01;
                        Debug.WriteLine("Sending application:");
                        Debug.WriteLine(senderId);
                    }

                    var bhs = hl7Reader.Item as BHS;
                    if (bhs != null)
                    {
                        //  Validate 
                        var bhsErrors = bhs.Validate();
                        //  Pull the sending application from BHS
                        var senderId = bhs.BatchSendingApplication_03.NamespaceID_01;
                        Debug.WriteLine("Sending application:");
                        Debug.WriteLine(senderId);
                    }
                }
            }
        }
    }
}
