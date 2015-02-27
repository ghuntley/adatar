[![Issue Stats](http://issuestats.com/github/ghuntley/adatar/badge/issue)](http://issuestats.com/github/ghuntley/adatar)
[![Issue Stats](http://issuestats.com/github/ghuntley/adatar/badge/pr)](http://issuestats.com/github/ghuntley/adatar)

# Adatar

This project can be used to scaffold a prototypical .NET solution including file system layout and tooling. This includes a build process that: 

* updates all AssemblyInfo files
* compiles the application and runs all test projects
* generates [SourceLinks](https://github.com/ctaggart/SourceLink)
* generates API docs based on XML document tags
* generates [documentation based on Markdown files](http://fsprojects.github.io/ProjectScaffold/writing-docs.html)
* generates [NuGet](http://www.nuget.org) packages
* and allows a simple [one step release process](http://fsprojects.github.io/ProjectScaffold/release-process.html).

In order to start the scaffolding process run 

    $ build.cmd // on windows    
    $ build.sh  // on mono
    
Read the [Getting started tutorial](http://fsprojects.github.io/ProjectScaffold/index.html#Getting-started) to learn more.

Documentation: http://fsprojects.github.io/ProjectScaffold

## Avatar Providers

### Gravatar

See https://en.gravatar.com/site/implement/images/

### Active Directory

Use https://github.com/ghuntley/active-directory-photo-toolkit

### Azure Active Directory

Use https://github.com/AzureADSamples/WebApp-GraphAPI-DotNet/blob/master/WebAppGraphAPI/Controllers/UsersController.cs#L376

### Exchange EWS

See https://msdn.microsoft.com/en-us/library/office/jj190905(v=exchg.150).aspx
See http://stackoverflow.com/questions/27314335/retrieve-user-photo-with-office365-rest-api


       WebRequest.Create("https://www.contoso.com/ews/exchange.asmx/s/GetUserPhoto?email=sadie@contoso.com&size=HR240x240") 


## Metrics

All metrics are prefixed with a `namespace` which is used to denote which environment the application is running on and the hostname of the machine:

	<environment [local|dev|preprd|prd]>.adatar.<hostname>


Nouns are used to define the `target` and past tense verbs to define the `action` which is a very useful convention when you need to nest metrics:

	<namespace>.<instrumented section>.<target (noun)>.<action (past tense verb)>

### fetchavatar

    (counter)     fetchavatar.gravatar.attempted
    (counter)     fetchavatar.gravatar.succeeded
    (counter)     fetchavatar.gravatar.query.<emailaddress>
    (timer)       fetchavatar.gravatar.query_time
    (counter)     fetchavatar.gravatar.failure.account_not_found
    (counter)     fetchavatar.gravatar.failure.authentication_failed
    (counter)     fetchavatar.gravatar.failure.query_failed

    (counter)     fetchavatar.activedirectory.attempted
    (counter)     fetchavatar.activedirectory.succeeded
    (counter)     fetchavatar.activedirectory.query.<emailaddress>
    (timer)`      fetchavatar.activedirectory.query_time
    (counter)     fetchavatar.activedirectory.failure.account_not_found
    (counter)     fetchavatar.activedirectory.failure.authentication_failed
    (counter)     fetchavatar.activedirectory.failure.query_failed

    (counter)     fetchavatar.azure_activedirectory.attempted
    (counter)     fetchavatar.azure_activedirectory.succeeded
    (counter)     fetchavatar.azure_activedirectory.query.<emailaddress>
    (timer)       fetchavatar.azure_activedirectory.query_time
    (counter)     fetchavatar.azure_activedirectory.failure.account_not_found
    (counter)     fetchavatar.azure_activedirectory.failure.authentication_failed
    (counter)     fetchavatar.azure_activedirectory.failure.query_failed

    (counter)     fetchavatar.exchange_ews.attempted
    (counter)     fetchavatar.exchange_ews.succeeded
    (counter)     fetchavatar.exchange_ews.query.<emailaddress>
    (timer)`      fetchavatar.exchange_ews.query_time
    (counter)     fetchavatar.exchange_ews.failure.account_not_found
    (counter)     fetchavatar.exchange_ews.failure.authentication_failed
    (counter)     fetchavatar.exchange_ews.failure.query_failed



## Maintainer(s)

- [@ghuntley](https://ghuntley.com)

The default maintainer account for projects under "fsprojects" is [@fsgit](https://github.com/fsgit) - F# Community Project Incubation Space (repo management)
