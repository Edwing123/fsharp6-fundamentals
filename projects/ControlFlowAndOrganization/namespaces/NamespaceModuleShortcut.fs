(*

F# let us define a namespace and a module in a unifying way:

*)

module Finance.Models.Trasanction

type T =
    { Id: uint64
      Amount: float
      AccountId: uint64
      IncomingDateTime: System.DateTime };

// This is the same as:

namespace Finance.Models

module Transaction =
    type T = {
        Id: uint64
        Amount: float
        AccountId: uint64
        IncomingDateTime: System.DateTime
    };
