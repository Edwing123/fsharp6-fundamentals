(*

Recursion functions that carry their accumulation state.

*)

let rec askAndAdd acc =
    let input = System.Console.ReadLine()
    let (isOk, n) = System.Int32.TryParse input

    match isOk with
    | true -> askAndAdd (acc + n)
    | _ ->
        if input <> "x" then
            askAndAdd acc

askAndAdd 0
