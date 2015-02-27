module Adatar.Tests.``Gravatar``

open NUnit.Framework
open FsUnit

open Adatar

[<Test>]
let ``When I convert "Adatar" into a MD5Hash it returns "1F667B8E47E64225FF3CABF4BBA714BC".`` () =
    Gravatar.MD5Hash("Adatar") |> should equal "1F667B8E47E64225FF3CABF4BBA714BC"

open System.Net.Mail

[<TestFixture>]
type ``When an emailaddress is hashed`` () =
    let expectedHash = "23D4D2451F74764E095F15A739B68A4E"

    [<Test>] member x.
     ``that is lowercase it should be expected hash.`` () =
        Gravatar.HashEmailAddress(new MailAddress("ghuntley@ghuntley.com")) |> should equal expectedHash

    [<Test>] member x.
     ``that is mixedcase it should be the same hash as the lowercase emailaddress.`` () =
        Gravatar.HashEmailAddress(new MailAddress("GhUnTlEy@gHuNtLeY.cOm")) |> should equal expectedHash