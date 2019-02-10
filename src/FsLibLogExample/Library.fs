namespace FsLibLogExample

module Say =
    open MyLib.Logging
    open MyLib.Logging.Types

    let logger = LogProvider.getCurrentLogger ()
    let nothing name =
        name |> ignore

    let hello name =
        logger.Log (LogLevel.Warn) (Some (fun () -> sprintf "%s was said hello to" name)) None Array.empty
        |> ignore
        sprintf "Hello %s" name

