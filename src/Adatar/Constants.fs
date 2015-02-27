namespace Adatar

[<AutoOpen>]
module Constants =

    open System.Reflection
    let HttpUserAgent = Assembly.GetExecutingAssembly().GetName().Version.ToString() |> sprintf "Adatar/v%s; https://github.com/ghuntley/adatar" 
