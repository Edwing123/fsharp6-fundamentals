(*

The other type of module we got is top level module.

Here we don't use the = asign and the members are not indented.

*)

// This declaration must be the first one in the file.
module Mathematics

let add x y = x + y

let multiply x y = x * y

let PI = 3.14

// We can define sub-modules in local or top-level modules

module Floating =
    let add x y : float = x + y
    let multiply x y : float = x * y
