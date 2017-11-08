using System.Reflection;
using System.Runtime.InteropServices;
using FEV.TOPexpert.Common.ConfigurationManagement.TheAnsweringMachine;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("TheAnsweringMachine")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration(VersionProvider.BuildConfiguration)]
[assembly: AssemblyCompany("FEV Europe GmbH")]
[assembly: AssemblyProduct("TheAnsweringMachine " + VersionProvider.BuildConfiguration)]
[assembly: AssemblyCopyright("Copyright © FEV Europe GmbH 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

// Please do not change this value manually! It will be overridden with the next build. Use
// the com visible attribute on class level instead as described at http://dew175.fev.com/wiki/How_to_create_a_COM_component
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("5ea77b8c-6c6d-45c3-9df8-c89f40288d6f")]

// Version information for an assembly consists of the following three values:
//
//      Major Version
//      Minor Version 
//      Patch Version
//
// Please update those values manually according to the TOPEXPERT versioning guidelines.
// Update AssemblyVersion manually. The other ones are filled automatically.
[assembly: AssemblyVersion("1.0.0")]

// Do not change these values manually. They are updated with the next build automatically, based on the AssemblyVersion!
[assembly: AssemblyFileVersion("1.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0-" + VersionProvider.CommitID)]