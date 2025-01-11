// Immutability in F#.

// Once a binding between a name and a value is created, by default it cannot be
// changed.

let githubStars = 666

// We cannot change the value bound to it.
// githubStars <- 777

// F#, however, offers a way to mark bindings are mutable.

let mutable counter = 0

counter <- counter + 1
counter <- counter + 1
counter <- counter + 1

printfn "The value of the counter is %d." counter
