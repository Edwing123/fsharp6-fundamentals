// In scoping.

open System

// in bindings are weird to be honest,
// but basically, there will be times when
// the result of some process is formed
// from intermediary calculation whose results are bind to separate
// names, having this separation helps in making the code easy to read.

let age = 23
let money = 14_000
let isWealthy = age >= 18 && money >= 10_000

Console.WriteLine(isWealthy)

// We no longer need the age and money bindings, however they are already
// present in this scope.

let isPoor =
 let age = 23 in
  let money = 0 in
   age < 18 && money <= 1_000

Console.WriteLine(isPoor)

