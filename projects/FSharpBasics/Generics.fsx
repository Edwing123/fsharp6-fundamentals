// Generics

let add a b = a + b

let result = add 10 10

let concatenate a b = a + b

let message = concatenate "Hello" "World"

let swap a b = (b, a)

let coors = swap 10 10

let names = swap "Garcia" "Edwin"

// The compiler infered that the parameters were of a generic type based
// its usage.
//
// Generic parameters have the syntax: 'a where a is the name
// of the generic type, it can be anything, you can even follow
// the C# convention and use T as the prefix of the parameter name.
//
// Now let's define explicitly the generic types.

let print (any: 'a) =
 System.Console.WriteLine(any)

print "Hello"
print 123

// We can have generic compound types, for example.

// type StringTuple = {
//  First: string;
//  Second: string;
// }


// type IntTuple = {
//  First: uint64;
//  Second: uint64;
// }

// let swapTuple (input: StringTuple): StringTuple = {
//  First = input.Second;
//  Second = input.First;
// }

type GenericTuple<'a, 'b> = {
 First: 'a;
 Second: 'b;
}

let playerPosition = { First = 10; Second = 10 }
let playerNames = { First = "Edwin"; Second = "Garcia" }
let playerAttrs = { First = "wizzard"; Second = 1_000 }
type StringTuple = GenericTuple<string, string>

let roles: StringTuple = { First = "monitoring"; Second = "closings-driver" }
