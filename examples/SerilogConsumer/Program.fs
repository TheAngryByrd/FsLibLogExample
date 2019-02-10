open System
open Serilog
open FsLibLogExample

[<EntryPoint>]
let main argv =
    let log =
        LoggerConfiguration()
            .WriteTo.ColoredConsole(outputTemplate= "{Timestamp:HH:mm} [{Level}] ({Name:l}) {Message}{NewLine}{Exception}")
            .CreateLogger();
    Log.Logger <- log

    Say.hello "Captain"
    |> ignore

    Console.ReadLine() |> ignore
    0
