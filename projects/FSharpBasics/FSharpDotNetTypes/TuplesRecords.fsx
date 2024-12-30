// Tuples and records in F#

// a tuple type represents a list of values of different types,
// kind of similar to an array or a list, but here the values
// can be of different types, which is not the case with two others,
// where the values must be of the same type.
//
// The syntax is (value1, value2, value3, ..., valueN)

let playerCoors = (1, 20)

let serverConfig = ("localhost", 8080)

// The type of a type is: type1 * type2 * ... * typeN
// Each type is separated by an asterisk (*).
// According to the course, this is an algebraic product type.

// We can perform destructuring on tuple values, which is
// a handy way of getting out the values of a tuple and at the same
// type binding them with a name.

let (x, y) = playerCoors

printfn "Player coordinates: (%d, %d)" x y

// Records.

type OkResponse = {
    StatusCode: int;
    Data: string;
}

type ErrorResponse = {
    StatusCode: int;
    ErrorMessage: string;
}

let okResponse = { StatusCode = 200; Data = "Hello World" }

let errorResponse = { StatusCode = 404; ErrorMessage = "Not Found" }
