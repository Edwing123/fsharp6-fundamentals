// Learning about variables in F#.
//
// We use the let keyword to establish a binding between
// a descriptive name and a value (of a particular type).

// This is a string literal.
let name = "Edwin Garcia"

// This is an integer.
let age = 23

// This is a boolean.
let isSingle = true

// This is a floating-point number.
// We can omit the decimals after the period, it is valid syntax
// floats.
let salary = 20000.

// We do not have to specify the data type, the compiler
// will infer the type based on the assigned value.
//
// We can also specify the type explicitly.

let isEmployeed: bool = true
let isVirgen: bool = false
let bossName: string = "John Doe"

// We called these "variables", however, in F# by default let bindings
// are immutable, meaning that once a value is assigned to a name
// it cannot be changed.

// For example, this is not a reassigment, but rather
// a comparison expression.
// isVirgen = false

printfn "Name: %s" name
printfn "Age: %d" age
printfn "Is single: %b" isSingle
printfn "Salary: %f" salary
printfn "Is employeed: %b" isEmployeed
printfn "Is virgen: %b" isVirgen
printfn "Boss name: %s" bossName

