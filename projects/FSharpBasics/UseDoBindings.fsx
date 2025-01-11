// the 'use' and 'do' bindings.

// The 'use' binding works with values that implement the IDisposable interface.
// it's like a let binding, but it internally calls the bound object .Dispose method
// when the binding goes out of scope.

// Version with no 'use' binding.

open System.IO

let writeNoUse name data =
 let file = File.CreateText(name)
 file.WriteLine("{0}", data.ToString())
 file.Dispose()

writeNoUse "hello.txt" "Hello world."

// Version with 'use' binding.

let writeWithUse name data =
 use file = File.CreateText(name)
 file.WriteLine("{0}", data.ToString())

writeWithUse "password.txt" "JK"

// do bindings are weird at first, but it's a way to opt-in
// writing imperative code that does not evaluate to a value,
// or something like that, I need to find about its use cases.

do System.Console.WriteLine("WTF!")

// The expression on the right of the 'do' binding must evaluate to unit.
let result: unit = do printfn "WTF!"

do System.Console.WriteLine(result)
