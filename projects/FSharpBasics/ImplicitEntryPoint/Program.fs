// We don't define an entry point, so the compiler will generate one for us.
// This is thanks to .NET top-level statements.

printfn "Hello World from F#!"

let createGreeting greeting name =
    sprintf "%s, %s!" greeting name

let sayGoodMorning = createGreeting ("Good morning")

let ruthGreeting = sayGoodMorning "Ruth"

printfn "%s" ruthGreeting

// Get the command line arguments passed to the program.
let args = System.Environment.GetCommandLineArgs()

printfn "Command line arguments: %A" args
