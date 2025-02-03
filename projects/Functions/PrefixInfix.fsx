// Prefix function application
// func arg1 arg2 argN...

let calculateFee amount percentage : decimal = amount * percentage

type Transaction = { Id: uint64; Amount: decimal }

let transactions =
    [ { Id = uint64 1; Amount = 67.87m }
      { Id = uint64 2; Amount = 616.78m }
      { Id = uint64 3; Amount = 5.99m } ]

let transactionsWithAppliedFee =
    transactions |> List.map (fun (t) -> (t, calculateFee t.Amount 0.05m))

printfn "%A" transactionsWithAppliedFee

// Infix function application
// arg1 func arg2

printfn "%d" (1 + 1)

// Using an infix function in the prefix form: wrap its name with parenthesis.

printf "%f" ((+) 1. 2.)

// Creating infix functions.
// Their names must be symbols and be wrapped with parenthesis.

let (<.|.>) greeting name = $"{greeting}, {name}"

printf "%s" ("Hi" <.|.> "Edwin")

// Weird example, but meh.
