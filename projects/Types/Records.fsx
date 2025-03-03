(*

Record: an inmutable named collection of items of different types.

They require a type definition(1), that's because we define the name of
the fields as well as their corresponding types.

1: Anonymous records exist!

*)

// Definition of the record type.

type Person = {
 FirstName: string
 LastName: string
 Age: uint8
}

// Bind a value of that type (inferred).

let me: Person = {
 FirstName = "Edwin"
 LastName = "Garcia"
 Age = uint8 23
}

// Access its fields by name using the dot notation.

let firstName = me.FirstName

printfn $"Hi, my name is {firstName}."

// It's fields are read-only.

// me.FirstName <- "Evenor"

// What if we want a new record value based off an existing one?

// We can do so by using the following:

// We specify the existing record value + any fields with their new values
// after the `with` keyword.
let newMe = { me with Age = me.Age + uint8 1 }

printfn $"My new me is {newMe.Age} years old."

// Records can have members.
// Static and instance ones.

type Transaction = {
 Id: int
 DateTime: string
 Amount: decimal
 Merchant: string
 MerchantCountry: string
}
with
 // `this` is an identifier, we can give it any name, even self or x, it refers to the instance
 // of the record value.
 member this.Concept = $"{this.Merchant} {this.MerchantCountry}"
 // Static members work at type level, as such they don't have a reference to an instance.
 static member New id dateTime amount merchant country =
  { Id = id; DateTime = dateTime; Amount = amount; Merchant = merchant; MerchantCountry = country }

let googleMusicTrx = Transaction.New 1 "2025-02-23" 5.55m "music.google.com" "US"

let concept = googleMusicTrx.Concept

printfn $"Transaction concept: {concept}."

// Two record values are equivalent if they have the same number of fields, types and values.
