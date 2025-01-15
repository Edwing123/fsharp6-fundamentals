// Similar to Python list comprehensions.

// Let's createa a 10x10 grid where each position point
// is represented as a tuple of two ints.

let grid =
    [ for x in 0..10 do
          for y in 0..10 do
              yield (x, y) ]

printfn "%A" grid

// This is so common that there exists a short for yield

let xs = [ for i in 1..10 -> i * i ]

printfn "%A" xs

// It doesn't seem to work with for..to..do loops.
