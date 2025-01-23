namespace Finance

type Transaction = { Id: uint64; Amount: float }

module Operations =
    let createTransaction id amount = { Id = id; Amount = amount }
