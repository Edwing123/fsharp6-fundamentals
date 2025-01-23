open System
open TransactionProcesor.Logging

[<EntryPoint>]
let main argv =
    Logger.debug "transaction processor starting."
    Logger.debug $"received args: {argv}."

    TransactionProcesor.Driver.ConsoleUI.start ()

    Logger.debug "transaction processor shutting down."
    0
