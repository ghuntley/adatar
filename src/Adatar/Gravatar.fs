namespace Adatar


module Gravatar =

    // All URLs on Gravatar are based on the use of the hashed value of an email address. 
    // Images and profiles are both accessed via the hash of an email, and it is considered
    // the primary way of identifying an identity within the system. To ensure a consistent
    // and accurate hash, the following steps should be taken to create a hash:
    //
    // 1. Trim leading and trailing whitespace from an email address
    let MD5Hash (input : string) =
        use md5 = System.Security.Cryptography.MD5.Create()
        input
        |> System.Text.Encoding.ASCII.GetBytes
        |> md5.ComputeHash
        |> Seq.map (fun c -> c.ToString("X2"))
        |> Seq.reduce (+)

    // 2. Force all characters to lower-case
    // 3. md5 hash the final string
    open System.Net.Mail
    let HashEmailAddress (emailaddress: MailAddress) =
        emailaddress.Address.ToLowerInvariant() |> MD5Hash




    open HttpClient
    open Constants
    let request =  
        createRequest Post "http://somesite.com"  
//        |> withQueryStringItem {name="search"; value="jeebus"}  
//        |> withBasicAuthentication "myUsername" "myPassword"
        |> withHeader (UserAgent Constants.HttpUserAgent)
        |> withResponseCharacterEncoding "utf-8"
        |> withAutoDecompression DecompressionScheme.GZip  
//        |> withAutoFollowRedirectsDisabled  

    let chainedRequest = request |> withBasicAuthentication "newUsername" "newPassword"