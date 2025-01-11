// Scopes in F# are created using indentation.
// Indentation is achieved using spaces.

open System

let mutable counter = 0

// This is the program top level, we cannot repurpose bindings
// in this level.

let incrementCounter () =
  Console.WriteLine "incrementing the counter"

  // We can access the counter binding because it is defined
  // in the outer global scope.
  counter <- counter + 1

incrementCounter()

Console.WriteLine $"The counter is {counter}"

incrementCounter()

Console.WriteLine $"The counter is {counter}"

let printType v = Console.WriteLine $"the type is {v.GetType().ToString()}"

let effectfulFunc (n: uint8) =
  // In this scope n is unsigned 8-bits integer.
  Console.WriteLine $"n = {n}"
  printType n

  // In F# we can repurpose (whaaat) bindings, that is,
  // redefine it with a totally different value and type!!
  let n = "This is crazy"

  Console.WriteLine $"n = {n}"
  printType n

  let n = 100.0
  Console.WriteLine $"n = {n}"
  printType n

effectfulFunc (uint8 123)

// Cannot do this.
// let counter = 0
