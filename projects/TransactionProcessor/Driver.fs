module TransactionProcesor.Driver

open System
open TransactionProcesor.Logging

module ConsoleUI =
    let private promptUser () =
        Console.Write("actions: (d)eposit, (w)ithdraw or (e)xit: ")
        let action = Console.ReadLine()
        action

    let private promptAmount () =
        Console.Write("enter the amount: ")
        let amount = Console.ReadLine()
        float amount

    let start () =
        Logger.info "creating test account with 10,000 dollars."

        let mutable currentBalance = 10_000.0

        let mutable running = true

        Logger.info "starting option selection loop."

        while running do

            Console.WriteLine $"Balance: {currentBalance}."

            let action = promptUser ()
            Logger.info $"selected action: {action}."

            currentBalance <-
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
