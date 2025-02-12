(*

A discriminated union is a type that is composed of different kinds of types, but
only one sub-type can be assigned to variables of the discriminated union at a given
time.

Each sub-type is tagged with a label, so as to identify what sub-type
is currently active at a given moment.

Holy cow, it sounds confusing!!

*)

// A type that represents a day if the week.

type DaysOfWeek = Monday | Thuesday | Wednesday | Thursday | Friday | Saturday | Sunday

// Each union case or constructor has a label that is used to refer to the sub-type.

// A list of the days of the week that are days off (to me).
let daysOff = [Saturday; Sunday]

let firstDayOfWeek = Monday

// Each variant of the union can have data associated with it by defining a
// constructor where each constructor parameter is separated with an asterik, like
// a tuple.

type Response =
 | Ok of data: string
 | Error of message: string

// The parameter name is optional.
let responseOk = Ok(data="All good")

printfn "%A" responseOk

// Pattern match on the active union case.
// The "fields" can be any name, they don't have to
// match with the names of construtor's fields.
let data =
 match responseOk with
  | Ok data -> data
  | Error message -> message

printfn "%A" data

// Bank inquery.

type PaymentInfo = {
 AccountId: int
 ConceptId: int
 Amount: int
}

type Inquery =
 | Payment of PaymentInfo
 | EmailChange of accountId: int * email: string


let payment = Payment ({ AccountId = 1; ConceptId = 20; Amount = 100 })

let emailChange = EmailChange(accountId=1, email="me@edwingarcia.dev")

let inqueries = [
 payment
 emailChange
]

let processInquery =
 function
 | Payment info -> printfn $"{info}"
 | EmailChange (accountId, email) -> printfn $"account-id: {accountId}, email: {email}"

inqueries |> List.map processInquery


