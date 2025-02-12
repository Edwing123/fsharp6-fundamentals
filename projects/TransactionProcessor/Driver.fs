module TransactionProcessor.Driver

open System
open TransactionProcessor.Logging
open TransactionProcessor.Domain

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

        let account = Account.Default

        Logger.info "starting action selection loop."

        let rec loop account =
            let balance = account.Balance

            Console.WriteLine $"Balance: {balance}."

            let action = promptUser ()
            Logger.info $"selected action: {action}."

            match action with
            | "e" -> ()
            | "d" ->
                loop
                    { account with
                        Balance = balance + promptAmount () }

            | "w" ->
                let newBalance = balance - promptAmount ()

                if newBalance < 0 then
                    Console.WriteLine("Operation failed: withdrawal amount exceeds available balance.")
                    loop account
                else
                    loop { account with Balance = newBalance }
            | _ ->
                Console.WriteLine $"'{action}' is not a valid option."
                loop account

        loop account

        Logger.info "exiting option selection loop."

        ()
