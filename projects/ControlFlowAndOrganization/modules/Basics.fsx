(*

Modules for code organization in F#.

Modules let us organize relate let bindings and types together
under a name.

Modules are F# primary code organization mechanism, for example,
for list functionality we got the List module.

Behind the scenes, a module compiles to a static CLR class with
only static members and methods.

*)


// Local modules.

module Mathematics =
    let add x y = x + y
    let multiply x y = x * y

(*

This is know as a local module, the members of the module are indented
after the equal sign "=".

*)

// Using the contents of a module.

// By using the dot notation: <module name>.<member name>

let mutable result = Mathematics.add 10 10

printfn $"10 + 10 = {result}"

// Or we can open the module to expose their members directly.

open Mathematics

result <- multiply 10 10

printfn $"10 x 10 = {result}"
