type Transaction =
    { Id: int
      RRN: string
      PAN: string
      DateTime: System.DateTime
      MTI: string
      ProcessingCode: string
      Amount: int
      POSEntryMode: string
      Country: string
      ExpireDate: string
      CardHolderName: string
      MechantId: string
      MerchantName: string
      TerminalId: string
      AcquirerId: string }

type Account =
    { Number: string
      ExpireDate: string
      Transactions: System.Collections.Generic.List<Transaction> }

let createTransaction pan mti processingCode amount country expireDate cardHolderName merchantId merchantName =
    { Id = System.Random().Next()
      RRN = "436501234567"
      PAN = pan
      DateTime = System.DateTime.Now
      MTI = mti
      ProcessingCode = processingCode
      Amount = amount
      POSEntryMode = "0100"
      Country = country
      ExpireDate = expireDate
      CardHolderName = cardHolderName
      MechantId = merchantId
      MerchantName = merchantName
      TerminalId = "1234"
      AcquirerId = "4321" }

let showTransction transaction =
    printfn "Transaction Id: %d" transaction.Id
    printfn "RRN: %s" transaction.RRN
    printfn "PAN: %s" transaction.PAN
    printfn "DateTime: %A" transaction.DateTime
    printfn "MTI: %s" transaction.MTI
    printfn "ProcessingCode: %s" transaction.ProcessingCode
    printfn "Amount: %d" transaction.Amount
    printfn "POSEntryMode: %s" transaction.POSEntryMode
    printfn "Country: %s" transaction.Country
    printfn "ExpireDate: %s" transaction.ExpireDate
    printfn "CardHolderName: %s" transaction.CardHolderName
    printfn "MechantId: %s" transaction.MechantId
    printfn "MerchantName: %s" transaction.MerchantName
    printfn "TerminalId: %s" transaction.TerminalId
    printfn "AcquirerId: %s" transaction.AcquirerId
    printfn "---------------------------------"

[<EntryPoint>]
let main args =
    let account =
        { Number = "4012000000000016"
          ExpireDate = "4406"
          Transactions = new System.Collections.Generic.List<Transaction>() }

    let youtubeMusicTransaction =
        createTransaction
            account.Number
            "0100"
            "000000"
            3
            "US"
            account.ExpireDate
            "Edwin Garcia"
            "1234"
            "Youtube Music INC"

    account.Transactions.Add(youtubeMusicTransaction)

    let netflixTransaction =
        createTransaction
            account.Number
            "0100"
            "000000"
            5
            "US"
            account.ExpireDate
            "Edwin Garcia"
            "1234"
            "Netflix USA INC"

    account.Transactions.Add(netflixTransaction)

    account.Transactions.ForEach(showTransction)

    0
