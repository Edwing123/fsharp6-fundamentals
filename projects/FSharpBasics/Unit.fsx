// The unit data type represents the absense of a value.
// Yeah, that is interesting.
//
// In F# all functions must return a value, but some functions
// only perform side effects like printing to the console or writing to a file.
//
// They however, must turn a value, in this situations, F# provides us with the
// unit type, and it only has a single value that is of that type: a little opening and closing
// parennthesis "()".

let nothing: unit = System.Console.WriteLine("Hello, World!")

// Can we print it?

let moreNothing: unit = System.Console.WriteLine(nothing)

// A literal nothing hahaha:
let extraNothing: unit = ()

let getNothing = fun () -> ()

let withExtraNothing = getNothing()
