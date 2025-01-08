// We can convert a value of a particular type
// to another type.
//
// We do this by using F# conversion functions.

let printType value ty =
 printfn "Value: %A, Type: %s" value ty

let age = 23

let ageAsMoney: float = age

let typeOfAge = age.GetType()

printType age (typeOfAge.ToString())
printType ageAsMoney (ageAsMoney.GetType().ToString())

let ageFromUser = System.Console.ReadLine()

let ageFromUserAsInt = int ageFromUser

printfn "In 3 years you will be %d years old." (ageFromUserAsInt + 3)

// Upcasting operator :>

let nickName = "Edwin"

let nickNameAsObject = nickName :> obj

let nameAsStringAgain = string nickNameAsObject
