namespace Core

module Core =

    open System

    open Microsoft;

    open Microsoft.AspNetCore;
    open Microsoft.AspNetCore.Builder

    open Microsoft.Extensions;
    open Microsoft.Extensions.Hosting

    let mutable WebApplicationBuilderElement : WebApplicationBuilder = null

    let mutable WebApplicationElement : WebApplication = null

    [<EntryPoint>]
    let main args =

        WebApplicationBuilderElement <- WebApplication.CreateBuilder(args)

        WebApplicationElement <- WebApplicationBuilderElement.Build()

        WebApplicationElement.MapGet("/", Func<string>(fun () -> "Hello F#!")) |> ignore

        WebApplicationElement.Run()

        0
