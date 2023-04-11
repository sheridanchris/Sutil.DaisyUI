#r "nuget: Fun.Build, 0.3.6"

open Fun.Build
open System.IO
open System

let nugetPushCommand (apiKey: string) : System.FormattableString =
  $"dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json --skip-duplicate -k {apiKey}"


pipeline "Build" {
  description "Build Sutil.DaisyUI"

  stage "Restore" {
    run "dotnet tool restore"
    run "dotnet restore"
  }

  stage "Build" { run "dotnet build" }
  stage "Check formatting" { run "dotnet fantomas --recurse --check ./" }
  stage "Test" { run "dotnet test" }
  runIfOnlySpecified false
}

pipeline "Publish" {
  description "Publish Sutil.DaisyUI to NuGet"

  whenAll {
    branch "main"

    whenAny {
      envVar "NUGET_API_KEY"
      cmdArg "NUGET_API_KEY"
    }
  }

  stage "Pack" { run "dotnet pack -c Release ./src/Sutil.DaisyUI -o ." }

  stage "Publish" {
    run (fun ctx ->
      let key = ctx.GetCmdArgOrEnvVar "NUGET_API_KEY"
      runSensitive (nugetPushCommand key))
  }

  post [
    stage "Post publish" {
      whenNot { envVar "GITHUB_ACTION" }

      run (fun _ ->
        let nugetPackageFiles =
          Directory.EnumerateFiles(Environment.CurrentDirectory, "*.nupkg")

        nugetPackageFiles |> Seq.iter File.Delete)
    }
  ]

  runIfOnlySpecified true
}