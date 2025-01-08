// Everything in F# evaluates to a value.

type Account = {
 Id: int;
 CreditLimit: float;
 Kind: uint8;
}

let prettyAcccountType kind =
 if kind = 0 then
  "personal"
 else
  "business"

let account = { Id = 1; CreditLimit = 1000.0; Kind = uint8 0 }

let accountType = prettyAcccountType (int account.Kind)

printfn "The account type is %s." accountType

// The compiler won't let us ignore the return value of a function, unless
// we explictly aknowledge that we are doing so.

let square x = x * x

// This is fine.
let result = square 100

// The compiler is not happy.
square 25

// We have to ignore it.
ignore (square 25)

