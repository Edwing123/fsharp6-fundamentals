let ages = [23; 35; 17]

[<EntryPoint>]
let main args =
    // When it comes to console IO we can classify it into two types:
    //
    // 1. Reading input from the console.
    // 2. Writing output to the console.
    //
    // F# provides a set of functions to show output to the console.
    // But it does not provide functions to read from the console.
    // We can also use the .NET Console class to perform console IO.

    printfn "ages: %A" ages

    // This function lets us provide a format string, it's like a
    // template which contains placeholders which will be replaced
    // by the values provided in the arguments list, as well as perform
    // formatting operations on the values.
    //
    // Here %A means it'll format the argument "ages" - which is an array of ints -
    // in a particular generic way, in this case it'll convert each of the elements
    // to integers and put them between square brackets to finally print them.

    // Now let's use the .NET Console class and its IO functions.
    System.Console.WriteLine(ages)
    0
