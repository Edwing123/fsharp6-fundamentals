// Includes the domain models

module TransactionProcesor.Domain

type Account =
    { Id: uint64
      Balance: float }

    static member New id balance = { Id = id; Balance = balance }
    static member Default = Account.New (uint64 1) 10_000
