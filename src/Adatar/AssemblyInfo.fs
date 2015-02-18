namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Adatar")>]
[<assembly: AssemblyProductAttribute("Adatar")>]
[<assembly: AssemblyDescriptionAttribute("Adatar is a Active Directory microservice for employee photos, with optional fallback to Gravatar.com")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
