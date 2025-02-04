(*

Function application in F# determines the rules and machanisms
for how arguments are passed to functions.

Before going any further, first let's talk about the concept
known as "operator associativity":

The associativity of an operator is a property that determines how operators
of the same precedence are grouped in the absence of parenthesis.

Types of associativity:

- Associative: The operations can be grouped arbitrarily.

Examples: `1 + 2 + 3` is the same as `(1 + 2) + 3` or `1 + (2 + 3)`

- Left associative: The operations are grouped from the left.

Examples: `30 / 2 / 3` is treated as `(30 / 2) / 3`

- Right associative: The operations are grouped from the right.

Examples: `2 / 30 / 3` is treated as `2 / (30 / 3)`

In F#, parameter application to functions happens in a left-associative manner:

`square: int -> int`

`square 3 + 1` is treated as `(square 3) + 1` where 3 is the argument bound
to the parameter expected from `square`, then the resolved value 9 is passed to
the infix `+` function: `9 + 1`, which itself is treated as `(+) 9 1`. Finally
the result is 10.

*)


let square x = x * x
let result = square 3 + 1

let println any = printfn $"the result is {any}"

println result

// An example using a two parameters function.

let distance x y = if x > y then x - y else y - x
let anotherResult = distance 1 2 * 5

println anotherResult

// It keeps being left-associative, 1 and 2 are bound to the x and y parameters
// of the `distance` function, finally the resolved value is applied to the `(*)`
// function: `(*): int -> int -> int`.
