// For more information see https://aka.ms/fsharp-console-apps

type Box<'a> = {
 Value: 'a;
}

[<EntryPoint>]
let main _ =
 let box = { Value = 42 }

 let stringBox = { Value = "Hello" }

 printfn "%A" box
 printfn "%A" stringBox
 0

