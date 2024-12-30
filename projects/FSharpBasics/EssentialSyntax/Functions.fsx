// Functions in F#

// Functions are first class citizens in F#,
// we can assign functions (or in this case bind to a name) to
// variables, pass them as arguments to other functions and return
// them as results from other functions.

// Definition

let square x = x * x

let result = square 20

printfn "The square of 20 is %d" result

// Functions with multiple parameters

let add x y =
    let z = x + y
    z

let sumResult = add 10 20
printfn "The sum of 10 and 20 is %d" sumResult

