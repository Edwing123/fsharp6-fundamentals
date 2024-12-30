// The Pipe forward operator.

// It looks like this

let add x y = x + y

let result = 1 |> add 2

// It basically takes the left operand and pass it as an argument
// to the right operand.
//
// Since add is curried and we already passed it 2, it will
// return a function that takes one arguments, in this case the argument
// for the y parameter.

// Let's discompose it further.
let add2 = add 2
let anotherResult = 1 |> add2

printfn "The result is %d" anotherResult


// Examples:
let square x: float = x * x

let addPI x = x + System.Math.PI

let pitified = 10.0 |> square |> addPI

printfn "The result is %f" pitified
