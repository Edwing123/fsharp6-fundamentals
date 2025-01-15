// Comparisons between imperative vs functional iteration

let mySum xs =
    let mutable total = 0

    for x in xs do
        total <- total + x

    total

let xs = [ 1; 2; 3 ]

let firstResult = mySum xs

let secondResult = xs |> mySum

let areTheTotalsEqual = firstResult = secondResult

printfn "Is %A equal to %A? %s" firstResult secondResult (if areTheTotalsEqual then "yes" else "no")

// By putting the logic inside a function, we can just call "mySum" as easily as calling List.sum.
// But yeah, it exists.

let grades: float list = [ 88; 76; 89; 78; 98 ]

let total = List.sum grades

let average = total / (float grades.Length)

printfn "Your university average grade is %f" average

// reducing a list of elements to a single value.

let coordinates = [ (0, 0); (1, 1); (1, 2) ]

let sumOfCoors = coordinates |> List.map (fun (x, y) -> x + 1) |> List.fold (+) 0

// This translate to.

let mutable totalSum = 0

for coors in coordinates do
    let (x, y) = coors
    totalSum <- x + y + totalSum

// What if all we want is to iterate over all the elements, for example, to print them out to the console.

let mainMenuOptions =
    [ "d to reposit."; "w to withdraw"; "b to see balance"; "e to exit" ]

printfn "Available option:"

mainMenuOptions |> List.iter (fun option -> System.Console.WriteLine(option))

let userOption = System.Console.ReadLine()

printfn "Your option is %s" userOption

let isOkOption =
    match userOption with
    | "d"
    | "w"
    | "b"
    | "e" -> true
    | _ -> false

printfn "Is this a valid option? %b" isOkOption
