namespace App.Finance

module Transaction =
    type T =
        { Id: uint64
          Amount: float
          AccountId: uint64
          DateTime: System.DateTime }

    let create id amount accountId date =
        { Id = id
          Amount = amount
          AccountId = accountId
          DateTime = date }

    module Textures =
        let fixedTransactionDateTime = System.DateTime.Parse("2025-01-01 12:00:00.000Z")

        let transacctions =
            [ create (uint64 1) 9.99 (uint64 1) fixedTransactionDateTime
              create (uint64 2) 99.99 (uint64 1) fixedTransactionDateTime ]

// printfn "%A" Transaction.Textures.transacctions
