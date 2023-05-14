using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(InsidetheBackrooms.BuildInfo.Description)]
[assembly: AssemblyDescription(InsidetheBackrooms.BuildInfo.Description)]
[assembly: AssemblyCompany(InsidetheBackrooms.BuildInfo.Company)]
[assembly: AssemblyProduct(InsidetheBackrooms.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + InsidetheBackrooms.BuildInfo.Author)]
[assembly: AssemblyTrademark(InsidetheBackrooms.BuildInfo.Company)]
[assembly: AssemblyVersion(InsidetheBackrooms.BuildInfo.Version)]
[assembly: AssemblyFileVersion(InsidetheBackrooms.BuildInfo.Version)]
[assembly: MelonInfo(typeof(InsidetheBackrooms.InsidetheBackrooms), InsidetheBackrooms.BuildInfo.Name, InsidetheBackrooms.BuildInfo.Version, InsidetheBackrooms.BuildInfo.Author, InsidetheBackrooms.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]