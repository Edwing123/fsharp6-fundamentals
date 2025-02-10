(*

A tuple is a comma separated ordered list of elements,
each element can be of any type.

In relational algebra, a tuple is known as a product type:

A tuple is the product of combining elements.

They are used for:

- Having functions that returned "multiple" values.
- Store intermediate values when doing calculations.

*)

// Parenthesis are optional.
let coords = 0, 0
let coords2 = (1, 1)

// Two tuples are equivalence if:
//
// 1. The number of elements is the same,
// 2. The type of elements is the same,
// 3. The value themselves are the same.

let areEquivalent = coords = coords2

printfn $"{coords} = {coords2}? {areEquivalent}"

// Accesing individual elements of a tuple.

let coords3 = (10, 20)

// At the binding expression.
let (x, y) = coords3

printfn $"x = {x}, y = {y}"

// fst and snd functions.
let x1 = fst coords3
let y1 = fst coords3

printfn $"x1 = {x1}, y = {y1}"

// Can we index?

// No!
// let x2 = coords3[0]

// How to access the third, fourth elements, etc?

// We can use destructuring/patter-matching at the binding level.

// As we add more fields to a tuple, getting such fields can be come
// unamangeable.

// Returning multiple values.

let createCoords x y = (x, y)

printfn "%A" (createCoords 0 0)
