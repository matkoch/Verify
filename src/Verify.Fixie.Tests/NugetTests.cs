// #if RELEASE && NET9_0
//
// public class NugetTests
// {
//     public async Task Run()
//     {
//         if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
//         {
//             return;
//         }
//
//         var version = GetType().Assembly
//             .GetCustomAttribute<AssemblyInformationalVersionAttribute>()!
//             .InformationalVersion.Split('+')
//             .First();
//         var nugetPath = Path.Combine(
//             AttributeReader.GetSolutionDirectory(),
//             $"../nugets/Verify.Fixie.{version}.nupkg");
//         await VerifyZip(
//                 nugetPath,
//                 include: _ =>
//                 {
//                     var extension = Path.GetExtension(_.Name);
//                     return !extension.Contains(".psmdc") &&
//                            !extension.Contains(".xml") &&
//                            !extension.Contains(".dll") &&
//                            !extension.Contains(".rels");
//                 },
//                 includeStructure: true)
//             .ScrubLinesContaining("psmdcp", "repository")
//             .ScrubLinesWithReplace(_ => _.Replace(version, "version"));
//     }
// }
//
// #endif