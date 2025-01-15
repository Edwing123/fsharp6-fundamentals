(*

Pattern matching belongs to conditional expressions:

Performing different actions based on data patterns.

Syntax:

match <expr> with
| <pattern1 specification> [when cond1] -> <expr1>
| <pattern2 specification> [when cond2] -> <expr2>
| <pattern3 specification> [when cond3] -> <expr3>

Giving an expression <expr>, it is test against the list of pattern specifications.
If a pattern specification matches, we can make further validations in the optional [when condn section],
finally, it that validation passes, the <exprn> is evaluated, and that becomes the value of the expression.

There are many types of patterns we can use in the pattern specifications.

Type - Description

Constant: matches any numeric, character or string literal.
Wildcard: matches anything (_).
Cons: matches heads and tails of a list (head::tail).
as: a name applied to a match pattern.
OR / AND: Logical operations to match both or either of a pattern (|, &)
List, Array and Tuple: matches a pattern against these.
Identifier: Case of descriminated union.
Type test: Is something of a given type (:?).

*)

// Examples.

// Match against literal constants.

let describeNumber n =
    match n with
    | 0 -> "This is zero, it's a nice fella."
    | 1 -> "This is one, but is it really the first?"
    | _ -> "This is a number I can't say much about..."

let ns = [ 0; 1; 2; 3 ]

List.iter (fun n -> System.Console.WriteLine(describeNumber n)) ns

// There is a shortcut for when the body of the function only contains
// a match expression.

let describeTransactionType =
    function
    | "000000" -> "sale"
    | "100000" -> "withdrawal"
    | "110000" -> "quasi-cash"
    | _ -> "unknown"

let transactionProcCodes = [ "000000"; "0020000"; "100000"; "110000" ]

transactionProcCodes
|> List.map describeTransactionType
|> List.iter System.Console.WriteLine

// OR with pattern.

let transactionType = "sale"

let isFinancialTransaction =
    match transactionType with
    | "sale"
    | "withdrawal"
    | "transfer" -> true
    | _ -> false

System.Console.WriteLine(isFinancialTransaction)

// We can capture in a binding whatever the wildcard pattern matched.

let genre = "alien"

let genreDescription =
    match genre with
    | "female" -> "You are a beautiful lady."
    | "male" -> "What's up strong man."
    | genre -> $"Hi, you are a {genre}."

System.Console.WriteLine(genreDescription)


// This idea of binding names in a pattern works in places where a wildcard can be used.

type Position = int * int

let coors: Position = (0, 1)

let whereIsZero =
    function
    | (0, 0) -> "both are zero"
    | (x, y) & (0, _) -> "0 is first"
    | (x, y) & (_, 0) -> "0 is second"
    | (x, y) -> sprintf "%d and %d are not zero" x y

let xs = [ coors; (1, 1); (0, 0); (1, 0) ]

let results = xs |> List.map whereIsZero

results |> List.iter System.Console.WriteLine
