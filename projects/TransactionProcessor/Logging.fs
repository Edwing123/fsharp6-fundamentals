module TransactionProcessor.Logging

open Microsoft.Extensions.Logging

let private logger =
    LoggerFactory
        .Create(fun builder ->
            do
                builder.AddConsole() |> ignore
                builder.SetMinimumLevel LogLevel.Debug |> ignore)
        .CreateLogger("TransactionProcessor")

module Logger =
    let info message = logger.LogInformation message

    let debug message = logger.LogDebug message
