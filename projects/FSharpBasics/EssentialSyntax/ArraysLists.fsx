// Arrays and Lists in F#

let names = [|"Edwin"; "Ruth"; "Michell"|]

// F# inferred the type of the array as string array.
// Arrays are a fixed sequence of elements of the same type.
// We have access to each element using the index operador,
// and the first element has index 0.
//
// Array elements are mutable, not the elements themselves,
// but their positions in the array, that is, you can put
// a different element at index 0, for example.

names[0] <- "Evenor"

printfn "The first element of the array is %s" names[0]

let grades = [87; 99; 78; 88; 96]

// Lists on the other hand are immutable, you can't replace
// its elements, but you can still access them through their
// index.

grades[0] <- 100 // This will not compile

// Integral Type Ranges.
// It's F# take on ranges, a convinient way
// to create a list or array
// that contains a sequencial list of values that "skipped" over
// an optional step.

// For example, let's create an array with elements
// from 1 to 100.
let fromOneToAHundred = [|1..100|]

printfn "the values: %A" fromOneToAHundred

// We can also specify a "step" option, this will create
// a list of integers but stepping over for each value in the
// sequence a certain number, for example:

let evenNumbers = [|2..2..100|]

printfn "The even numbers from 2 to 100 are: %A" evenNumbers

// Steps can be negative.

let from9To1 = [9..-1..1]

printfn "the list is: %A" from9To1

// Operations on lists.

// With the cons operador "::" we can
// create a new list that have a new element
// at the head of the list.

let points = [1; 2; 3]

// Create a new list that contains 0 at the head of the list.
let newPoints = 0 :: points

printfn "The new points are: %A, the old points are: %A" newPoints points

// Empty lists.
let anEmptyList = []

// List elements on new lines, no need for semicolon separator.
let poems = [
    "You are cool"
    "So am I"
    "This is bad"
]

// Add another poem text.
let morePoem = "F# is weird" :: poems

printfn "Poems: %A" morePoem

// We can use the cons operator to extract the head and the tail
// of a list, here head refers to the first element of the list,
// and tail refers to the rest of the elements in the list, here
// the tail being new list, in other words, the original list
// is left intact.

let parensStack = ["("; ")"; "("]

// head is "(" and tail is [")"; "("]

let head :: tail = parensStack

printfn "head: %s, tail: %A" head tail

// What if the list has only one element?

let lonelyInt = [1]

let lonelyHead :: lonelyTail = lonelyInt

printfn "lonelyHead: %d, lonelyTail: %A" lonelyHead lonelyTail

// What if the list is empty?

let emptyList = []

// This will throw an exception.
let emptyHead :: emptyTail = emptyList

printfn "emptyHead: %A, emptyTail: %A" emptyHead emptyTail

// Concatenating lists using the @ operator.

let family = ["Edwin"; "Evenor"]

let friends = ["Ruth"]

let bigFamily = family @ friends

printfn "Big family is: %A" bigFamily
