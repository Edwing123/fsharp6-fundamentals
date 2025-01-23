(*

Namespaces in F#

Analogous to .NET namespaces, in fact, they are the
same thing.

They allow us to organize types into named groups.

Namespaces can only contain types and modules, but no values
like simple values and function values.

Namespaces are typically the first declaration in a file, though
you can also define a top-level module.

In contrast to modules, namespaces can span several files, as in,
a set of files (which can contain module definitions, types, etc)
belong to a namespace, for example. FSharp.Core.Collection namespace.

Namespaces can form hierchies, but ultimely the goal is to:

- Organize our code to help in manintability of our systems, especially
  when they become large.

*)

// We can open namespaces too.

open Finance

// Explicitly create a transaction value.

let transactionCreatedManually = { Id = 1; Amount = 15.99 }

// Create a transaction by using the APIs provided by the namespace

let transaction = Operations.createTransaction 2 600.0

let transactions = [ transactionCreatedManually; transaction ]

transactions |> List.iter (printfn "%A")
