// Learning about F# strings.

// String are an immutable sequence of unicode characters.
// A String is an alias for .NET's System.String.

let name = "Edwin Garcia"

// Can get an indivual character by its index.
let firstLetter = name[0]

let message = sprintf "The first letter of the name '%s' is '%c'." name firstLetter

System.Console.WriteLine(message)

// Cannot modify a string, they are immutable.
// name[0] <- 'e'

// We can compare characters.

let secondLetter = name[1]

let vowels = ['a'; 'e'; 'i'; 'o'; 'u']

let isVowel x = List.contains x vowels

let isSecondLetterAVowel = isVowel secondLetter

let message2 = sprintf "The second letter of the name '%s' is a vowel: %b." name isSecondLetterAVowel

System.Console.WriteLine(message2)

// String slicing: a way to get substrings.

let firstName = name[0..4]

printfn "My first name is %s." firstName

let lastName = name[6..(name.Length - 1)]

printfn "My last name is %s." lastName

// Multiline strings, as easy as adding a new line to the string literal.

let poem = "Hello Ruth,
					this is me, Edwin.
					I've think about you from time to time.
					I hope you are doing well.

					Take care,
					Edwin."

System.Console.WriteLine(poem)

// Supress newlines with the backslash character.

let insecurePassword = "this is my \
insecure password"

System.Console.WriteLine(insecurePassword)

// Escape sequences: \\, \", \n, \t, \r.

// Verbatim strings: they follow the syntax @"string contents" and everything between
// the double quotes is interpreted literally as is, basically no interpretation of escape sequences.

let lastPoem = @"This is not true, ""it"" did it, I had no choice, I hope you are fine, please forget me."

// We still have to escape double quotes by adding an extra double quote

System.Console.WriteLine(lastPoem)

// Triple quote strings are strings enclosed by triple quotes characters.
// In this presentation there is no need to escape double quotes.
let transactionResponse = @"{
	""transactionId"": ""123456"",
	""status"": ""success"",
	""message"": ""Transaction was successful.""
}"

System.Console.WriteLine(transactionResponse)

open System

let verbatim = @"Hi, this is a ""verbatim"" string., \t"

Console.WriteLine(verbatim)

let tripleQuoted = """Hi, this is "it"."""

Console.WriteLine(tripleQuoted)

// String builders
// Functionality from .NET

open System

let csvResponse = new Text.StringBuilder()

type CardHolderBasicInfo = { name: String; cardNumber: string; plan: string; activationDate: string }

let cardHolders = [
    { name = "Edwin Garcia"; cardNumber = "1234567890"; plan = "Gold"; activationDate = "2021-01-01" }
    { name = "Ruth Garcia"; cardNumber = "0987654321"; plan = "Silver"; activationDate = "2021-01-01" }
]

let to_csv cardHolder =
    (sprintf "%s, %s, %s, %s"  cardHolder.name cardHolder.cardNumber  cardHolder.plan  cardHolder.activationDate)

csvResponse.Append("name, card_number, plan, activation_date")
csvResponse.AppendLine()

let firstRecord = to_csv cardHolders[0]
csvResponse.Append(firstRecord)
csvResponse.AppendLine()

let secondRecord = to_csv cardHolders[1]
csvResponse.Append(secondRecord)

Console.WriteLine(csvResponse.ToString())

// Interpolated strings, a .NET feature.

let age = 23
let isSingle = true

let sadMessage = $"I am {age} years old. Am I single? {isSingle}."

System.Console.WriteLine(sadMessage)
