// Primitive data types

// sbyte and byte, 8-big signed and unsigned integers.

// int16, int32 and int64, 16-bit, 32-bit and 64-bit signed integers.

// uint16, uint32 and uint64, 16-bit, 32-bit and 64-bit unsigned integers.

// bigint for arbitrary precision integers of at least 4 bytes.

// float, float32 ande decimal, 4, 8 and 16 bytes floating point numbers.

// bigrational At least 4 bytes numbers.

// bool for true/false, it occupies 1 byte.

// char 2 byte unicode character.

// string for text, unicode text.

// Explicitly especifying types in variables.

let age: int = 23

let isSingle: bool = true

// Explicit parameter type.
let square (x: int) = x * x

// Explicit parameters types.
let add (a: int) (b: int) = a * b

// Explicit parameter type and return type.
let greet (name: string): string = sprintf "Hello %s" name

// .NET types in F#
//
// Even though F# provides its own types, we can also
// use .NET types in F#: Dictories, Lists, Arrays, etc.
// And even objects. In fact, some of F# types are
// aliases for .NET types.
//
// Having said that, using F# types is encounraged.

open System.Collections.Generic

let currencies = new Dictionary<string, string>()

currencies["NIO"] <- "Córdoba"
currencies["USD"] <- "Dollar"
currencies["EUR"] <- "Euro"
currencies["JPY"] <- "Yen"

let nio = currencies["NIO"]

printfn "The currency for NIO is %s" nio

// F# functional and composite types.

// tuple: represents an unamed set of values.

// record: represents a named set of values, kind of like a map.

// descriminated union: represents a type that can be one of several types.

// Option: represents a type that could be a value or nothing.

// units of measure: represents a type with a unit of measure. It's
// like especiazing an integer to be more specific about what it
// represents, it's like int + context, for example, a type that
// represents distance in meters, or weight in kilograms.
//
// This reminds me to Go's type definitions where you can:
//
// Type Meter int
//
// func Add(a Meter, b Meter) Meter {
//   return a + b
// }
//
// Passing in a Meter type to Add function would make it more
// clear what the function expects.
