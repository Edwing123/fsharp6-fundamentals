(*

What are functions?

In functional programming languages, the concept of a function
originates from mathematics, at least the modern mathematical definition,
this is important to clarify because mathematical functions have existed for
a while.

In the modern definition, a function is a mapping between elements of an input
set to elements of an output set, where each element in the input set is mapped
to exactly one element in the output set. The input set is known as the domain,
while the output set is known as the codomain or range.

The mechanism to "transform" the input element to the output element are contained
inside the body of the function, for example, a function that maps elements from the
set of real numbers to its corresponding squared elements in the set of real numbers,
in other words, a function to square numbers, given input 4, it transforms it to output 16.

Such function could be defined as:

f(x) = x * x

Where x belongs to the domain of real numbers and the output belongs
to the range/codomain of real numbers.

Rules for creating functions:

1. Functions always return a value.
2. Functions always derive the output only from the given input.
3. Functions never modify (mutate) the outside world.

*)

// Function in F#

let result =
    let square x = x * x in
    let domain = [ 1; 2; 3; 4 ] in
    let range = domain |> List.map square in
    sprintf "domain: %A, range: %A" domain range

System.Console.WriteLine(result)

// Creating functions

let square x = x * x
