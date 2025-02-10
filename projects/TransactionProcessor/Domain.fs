// Includes the domain models

module TransanctionProcessor.Domain

type Account =
    { Id: uint64
      Balance: decimal }

    static member New id balance = { Id = id; Balance = balance }
    static member Default = Account.New (uint64 1) 10_000m
