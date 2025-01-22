// Learning about Exceptions in F#.

// Defining exceptions:

// The syntax is: exception <NameOfTheException> of <constructor in tuple form>

// The constructor is optional, but it's a way
// to associate data with the exception.

exception ErrorOne of string * int
exception ErrorTwo of string * int * int

let compareNumbers x y =
    try
        if x = y then
            raise (ErrorOne("x and y are equal", x))
        else
            raise (ErrorTwo("x and y are not equal", x, y))
    with
    | ErrorOne(msg, v) -> printfn "msg: %s, v: %d" msg v
    | ErrorTwo(msg, v1, v2) -> printfn "msg: %s, v1: %d, v2: %d" msg v1 v2
    | _ -> ()

compareNumbers 1 10
compareNumbers 10 10
compareNumbers 0 1

// try..finally - also we only handle ErrorOne.
let compareNumbers2 x y =
    try
        try
            if x = y then
                raise (ErrorOne("x and y are equal", x))
            else
                raise (ErrorTwo("x and y are not equal", x, y))
        with ErrorOne(msg, v) ->
            printfn "msg: %s, v: %d" msg v
    finally
        printfn "All done."

compareNumbers2 1 1
compareNumbers2 1 0
