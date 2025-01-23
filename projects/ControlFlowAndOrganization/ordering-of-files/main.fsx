(*

The order of compilation of F# code and files is important,
a function can only reference another function only if that
function was already defined before.

This also applies to code divided into different files, we can only reference code in
other files if those files were already processed by the compiler.

This is due to F# using a single pass compilation system.

*)
