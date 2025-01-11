// Let bindings in F#.

// We have different kinds of bindings in F#.abs

// A let binding let us associate a value to an identifier.
// By default bindings are immutable.

// Examples.

let titoRealName = "Yader"

let hasEnoughMoney money = money >= 10_000

// Cannot reassign.

// titoRealName <- "Francisco"

// The type of the binding is inferred by the compiler based
// on the values we bind.
let edwinMoneInPocket: float = 70.0

// No need to specify the new keyword when instantiating types.
open System.Collections
let time = Generic.List<string>()

// No need for semicolons, but if you want to use them, they are allowed.

let badWords = [|"bitch"; "hoe"; "gun"|];
let goodWords = [|"God"; "Women"; "Petite"|];
