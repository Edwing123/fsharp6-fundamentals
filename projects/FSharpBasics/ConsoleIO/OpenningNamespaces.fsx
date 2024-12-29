// We can use the open keyword to get access
// of a particular namespace types without
// typing the namespace identifier every time.

open System

printfn "What are you thinking?"

let input = Console.ReadLine()

printfn "You are thinking: %s" input
