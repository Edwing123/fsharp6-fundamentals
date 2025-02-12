module TransactionProcessor.Rules

open TransactionProcessor.Domain

module Accounts =
    /// Deposits [amount] to the [account] balance.
    let deposit amount account =
        { account with
            Balance = account.Balance + amount }

    /// Withdraws [amount] from the [account] balance.
    let withdraw amount account =
        { account with
            Balance = account.Balance - amount }
