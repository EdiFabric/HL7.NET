Thank you for downloading EdiFabric's HL7 examples

1. Overview
The examples are organized into different projects in two logical categories: by product feature and by message type.

2. Requirements
- Visual Studio, compatible with the supported .NET versions
- Minimum .NET Framework 4.5 or .NET Core 3.1. All projects target .NET Framework 4.5, however, the Target Framework from each project's properties can be changed to .NET Core 3.1.
- EdiFabric trial NuGet packages and serial number.

3. Setup
Rebuild the solution to install the trial packages from nuget.org. If there are any build errors, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.

NOTE: it is possible to also reference DLLs instead of NuGet packages. Change the .nupkg extension of the packages to .zip, unzip them, and extract the DLL files. 
Then uninstall the NuGet packages from each project and replace them with DLL references.

4. Serial Key
Download the serial key from https://sowl.co/oApEt. 
The serial key is included in the file serial.key in folder edifabric-trial. Ensure it is there and that the file is not empty. The serial key is loaded in the file SerialKey.cs in project EdiFabric.Examples.HL7.Common. 
Open the file and ensure that the serialKeyPath is correct. If the serial key is invalid or the file is missing, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.

5. Getting started
To get started, set project EdiFabric.Examples.HL7.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own HL7 files.

6. Examples by feature
Explore the different features of EdiFabric, such as translating from HL7 file (ReadHL7), generating HL7 file (WriteHL7), validating HL7 transactions (ValidateHL7), 
import/export from/to JSON , XML, CSV.

7. Validation
All templates in EdiFabric.Templates.HL7 can be used for validation. 

8. EDI Templates
EdiFabric supports all HL7 versions and message types. We have an extensive library of EDI templates, however, if you can't find a particular transaction, please let us know. 
The following templates are available out-of-the-box:

https://support.edifabric.com/hc/en-us/articles/360017128357-HL7-version-2-6

9. Trial use
The trial assemblies are valid for 14 days and are subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the trial packages will begin throwing exceptions. 
To continue using the trial and the examples, you'll need to either request a trial extension or replace the trial packages, together with all references to the trial packages, with the full version of EdiFabric.

10. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.

11. Additional information

Install EdiFabric
https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric

Trial and examples
https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples

EdiFabric tutorial
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base
https://support.edifabric.com

Support
https://support.edifabric.com/hc/en-us/requests/new

Last updated on January 22, 2021
2021 � EdiFabric