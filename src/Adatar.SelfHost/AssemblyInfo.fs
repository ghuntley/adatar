namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Adatar.SelfHost")>]
[<assembly: AssemblyProductAttribute("Adatar")>]
[<assembly: AssemblyDescriptionAttribute("Adatar is a web microservice for retrieving employee photos.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
