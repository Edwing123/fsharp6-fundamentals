// Looping in F# using imperative contructs.

(*

Three types of iteration contructs, each for different scenarios.

for..in..do

Iterate over an IEnumerable collection.

for..to..do

Iterate over a range of values in a loop variable.

while..do

Iterate indefinitely while a condition is met.

*)

// Iterating over collections that implement IEnumerable.

let friends = [ "Yader"; "Joseph"; "Ruth"; "Michel" ]

printfn "These are my friends:"

for friend in friends do
    printfn "- %s" friend

// This is similar to C# foreach loop.

// Now let's iterate over an integer range.

for i in [ 1..10 ] do
    printfn "The value is %d" i

// The second example has an advantage over the first when it comes
// to effiency, in the first example, all the items in the IEnumerable
// are first loaded in memory before iteration begins.

// The for..to..do

for i = 0 to 100 do
    printfn "i = %d" i

// A typical while loop.

// We need a mutable variable that will be used in the loop and
// as will be incremented.

let mutable i = 0

while i <= 100 do
    printfn "i is %d" i
    i <- i + 1
