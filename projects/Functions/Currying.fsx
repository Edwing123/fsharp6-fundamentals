(*

Curring.

In mathematics, functions take a single parameter, in F# this is also true.

So what's going on with functions such as `add` below?

Well, F# is doing something called "currying the function", that is,
it takes that multiple parameters function and convert it into a single
parameter function that takes an int (parameter x) and returns another function that
takes an int (parameter y) and that returns an int.

It does this by default. Currying has its advantanges other than allowing us
to receive multiple parameters in functions.

*)

let add x y = x + y

// let add5 = add 5

let result = add 10 10

// printfn $"The result is {result}."

// F# is doing this behind the scenes
// (well, I don't know actually know how it is implemented, time to see the generated CIL?)

// let addV2 x = fun y -> x + y

// So it takes a single parameter x and returns a function that takes
// a single parameter y, and the body of that lambda expression returns the
// addition of x + y.

(*

Let's see the generated .NET Common Intermediate Language.

```
.method public static int32  'add'(int32 x,
                                   int32 y) cil managed
{
  // Other code redacted for brevity...
  // Code size       4 (0x4)
  .maxstack  8
  IL_0000:  ldarg.0
  IL_0001:  ldarg.1
  IL_0002:  add
  IL_0003:  ret
} // end of method Currying::'add'
```

Well, it got optimized to an actual two parameters funtion.

What if we only pass a single argument to add and bind the returned
function to a name, and finally called that function with the remaining
argument.

Wow, it got more complicated, well, there is more code:

The base class is `Curring`, inside of it we find:

A static class `add5` with one member:

- A method called `Invoke` that takes an int and returns the sum of the constant 5 +
the parameter.

```
.method public strict virtual instance int32
        Invoke(int32 y) cil managed
{
  // Code size       4 (0x4)
  .maxstack  8
  IL_0000:  ldc.i4.5 # <- the constant 5.
  IL_0001:  ldarg.1  # <- the parameter y.
  IL_0002:  add      # <- a called to add.
  IL_0003:  ret
} // end of method add5@21::Invoke
```

- The original `add` function.

- A method `get_add5` that is set to the value of the static class `add5`.

- A property `add5` whose getter retrieves the value of `get_add5`.

I don't know a lot about CIL, but it seems it's treating the static class `add5`
as some kind of delegate, that is, a class that can be invoked (hence its `Invoke` method.)

*)
