// Representing the absence of values.

open System

type Roles =
 | Admin
 | Normal

type User = {
 Id: int
 Name: string
 Role: Roles
}

let database = [
 { Id = 1; Name = "Alice"; Role = Admin }
 { Id = 2; Name = "Bob"; Role = Normal }
 { Id = 3; Name = "Charlie"; Role = Normal }
 { Id = 4; Name = "Edwing123"; Role = Admin }
]

let findUserByName name =
 try
  database |> List.tryFind (fun user -> user.Name = name)
 with
 | _ -> None


let askName =
 printfn "What's your name? "
 Console.ReadLine()

let userName = askName

userName
 |> findUserByName
 |> Option.map (fun user -> sprintf "Welcome %s" user.Name)
 |> Option.defaultValue "User not found"
 |> printfn "%s"

// Adding optional integers.
// let addIntsAsOptions x y =
//  match (x, y) with
//  | (Some x, Some y) -> Some (x + y)
//  | _ -> None

// addIntsAsOptions (Some 1) (Some 2)
// |> printfn "%A"
