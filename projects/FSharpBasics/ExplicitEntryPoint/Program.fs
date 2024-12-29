// We can explicitly specify which function is the entry point
// of the program by specifying the EntryPoint attribute.

[<EntryPoint>]
let main args =
    // We recieve the arguments through the args parameter.
    printfn "The args: %A" args

    // Must return an integer.
    0
