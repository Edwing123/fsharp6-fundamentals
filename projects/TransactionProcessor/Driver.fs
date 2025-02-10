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

        let initialBalance = 10_000.0

        Logger.info "starting action selection loop."

        let rec loop balance =
            Console.WriteLine $"Balance: {balance}."

            let action = promptUser ()
            Logger.info $"selected action: {action}."

            match action with
            | "e" -> ()
            | "d" -> loop (balance + promptAmount ())
            | "w" ->
                let newBalance = balance - promptAmount ()

                if newBalance < 0 then
                    Console.WriteLine("You are overwithdraing.")
                    loop balance
                else
                    loop newBalance
            | _ ->
                Console.WriteLine $"'{action}' is not a valid option."
                loop balance

        loop initialBalance

        Logger.info "exiting option selection loop."

        ()
