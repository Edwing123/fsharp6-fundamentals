open System

module Logger =

    type Level =
        | Info
        | Debug
        | Error

    let createJsonLogginEntry (level: Level) msg (dateTime: DateTime) =
        sprintf """{ "level": "%A", "date": "%s", "msg": "%s" }""" level (dateTime.ToString()) msg

    let log (level: Level) (msg: string) =
        let date = System.DateTime.UtcNow
        Console.WriteLine(createJsonLogginEntry level msg date)

    let info = log Level.Info

    let debug = log Level.Debug

type Account = { mutable Balance: float }

let createAccount initialBalance = { Balance = initialBalance }

let promptUser () =
    Console.Write("actions: (d)eposit, (w)ithdraw or (e)xit: ")
    let action = Console.ReadLine()
    action

let promptAmount () =
    Console.Write("enter the amount: ")
    let amount = Console.ReadLine()
    float amount

[<EntryPoint>]
let main argv =
    Logger.debug "transaction processor starting."
    Logger.debug $"received args: {argv}."

    Logger.info "creating test account with 10,000 dollars."

    let dummyAccount = createAccount 10_000

    let mutable running = true

    Logger.info "starting option selection loop."

    while running do

        let currentBalance = dummyAccount.Balance
        Console.WriteLine $"Balance: {currentBalance}."

        let action = promptUser ()
        Logger.info $"selected action: {action}."

        dummyAccount.Balance <-
            match action with
            | "d" ->
                Logger.info "getting deposit amount."
                currentBalance + promptAmount ()
            | "w" ->
                Logger.info "getting withdrawal amount."
                currentBalance - promptAmount ()
            | _ ->
                Logger.info "action <> d or w"
                running <- action <> "e"
                currentBalance

    Logger.info "exiting option selection loop."

    Logger.debug "transaction processor shutting down."
    0
