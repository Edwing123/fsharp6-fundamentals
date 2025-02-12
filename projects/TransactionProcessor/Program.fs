open TransactionProcessor.Logging

[<EntryPoint>]
let main argv =
    Logger.debug "transaction processor starting."
    Logger.debug $"received args: {argv}."

    TransactionProcessor.Driver.ConsoleUI.start ()

    Logger.debug "transaction processor shutting down."
    0
