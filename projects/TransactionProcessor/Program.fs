open System

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
    App.Logging.debug "transaction processor starting."
    App.Logging.debug $"received args: {argv}."

    App.Logging.info "creating test account with 10,000 dollars."

    let dummyAccount = createAccount 10_000

    let mutable running = true

    App.Logging.info "starting option selection loop."

    while running do

        let currentBalance = dummyAccount.Balance
        Console.WriteLine $"Balance: {currentBalance}."

        let action = promptUser ()
        App.Logging.info $"selected action: {action}."

        dummyAccount.Balance <-
            match action with
            | "d" ->
                App.Logging.info "getting deposit amount."
                currentBalance + promptAmount ()
            | "w" ->
                App.Logging.info "getting withdrawal amount."
                currentBalance - promptAmount ()
            | _ ->
                App.Logging.info "action <> d or w"
                running <- action <> "e"
                currentBalance

    App.Logging.info "exiting option selection loop."

    App.Logging.debug "transaction processor shutting down."
    0
