// if-then-elif

// In F# if conditions are expressions, they must evaluate to a value.

type Account =
    { Id: uint8
      OwnerName: string
      Balance: float }

let accounts =
    [ { Id = uint8 1
        OwnerName = "Edwin Garcia"
        Balance = 1_200 }
      { Id = uint8 1
        OwnerName = "Joseph"
        Balance = 50_000 }
      { Id = uint8 1
        OwnerName = "Ruth Garcia"
        Balance = 15_000 }
      { Id = uint8 1
        OwnerName = "Michel Garcia"
        Balance = 120_000 } ]

type BalanceLevel =
    | Empty
    | Low
    | Medium
    | High

let determineBalanceLevel (balance: float) =
    if balance = 0 then Empty
    else if balance > 0 && balance <= 10_000 then Low
    elif balance > 10_000 && balance <= 50_000 then Medium
    else High

let accountBalanceLevels =
    accounts
    |> List.map (fun account -> (account, determineBalanceLevel account.Balance))

accountBalanceLevels
|> List.iter (fun (account, balanceLevel) -> printfn "%s has a %A balance" account.OwnerName balanceLevel)


(*

boolean operators

not for negating a boolean.
&& for boolean AND logic operation.
|| for boolean OR logic operation.

comparison operators.

> greater than
>= greater than or equal to
< less than
=< less than or equal to
= equals
<> not equals

*)
