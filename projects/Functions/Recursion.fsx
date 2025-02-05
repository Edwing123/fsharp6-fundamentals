(*

Recursion: functions that call themselves.

Recursion is a technique that helps in solving a series of problems
that have the characteristic that in order to solve them, you apply
a similar series of steps repeatly.

Some such problems are:

- Number factorial calculation.
- Iteration over some sort of iterable value.

A recursive function has the following elements:

- A base case: determines when to stop execution.
- Body: changes state and moves closer to the base case.
- Self call: a call to itself.

*)

// An imperative function to sum the elementss of a list.

let imperative =
    let input = [ 1..3 ] in

    let fn list =
        let mutable sum = 0

        for item in list do
            sum <- sum + item

        sum

    let result = fn input in
    (input, result)

printfn "%A" imperative


// Version using recursion

let recursive =
    let input = [ 4..6 ] in

    let rec fn list =
        match list with
        | [] -> 0
        | head :: tail -> head + (fn tail)

    let result = fn input in
    (input, result)


printfn "%A" recursive

// Another version, but this time include an accumulator.

let betterRecursive =
    let input = [ 7..9 ]

    let rec fn acc list =
        match list with
        | [] -> acc
        | head :: tail -> fn (head + acc) tail

    let result = fn 0 input in
    (input, result)

printfn "%A" betterRecursive

// fold: a generic recursive function to reduce a list of input
// elements to a single output value.

let rec fold fn acc list =
    match list with
    | [] -> acc
    | head :: tail -> fold fn (fn acc head) tail

let input = [ 1..10 ]

let result = input |> fold (fun acc n -> acc + n) 0

printfn "%A" (input, result)

// It already exists.

printfn "%A" <| (input |> List.fold (fun acc n -> acc + n) 0)
