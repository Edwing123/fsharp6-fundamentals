open System

type LoggingLevel =
    | Info
    | Debug
    | Error

let log (level: LoggingLevel) (msg: string) = Console.WriteLine($"{level}: {msg}")

let logInfo = log LoggingLevel.Info

[<EntryPoint>]
let main argv =
    logInfo "transaction processor starting."
    logInfo $"received args: {argv}"

    Console.Write("actions: (d)eposit, (w)ithdra or (e)xit: ")

    let action = Console.ReadLine()

    logInfo $"selected action: {action}"

    logInfo "transaction processor shutting down."
    0
