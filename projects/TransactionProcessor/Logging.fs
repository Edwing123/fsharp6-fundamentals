module TransactionProcesor.Logging

open System

type private Level =
    | Info
    | Debug
    | Error

type private Entry =
    { Level: Level
      Msg: string
      DateTime: DateTime }

let private entryToJson
    { Level = level
      Msg = msg
      DateTime = dateTime }
    =
    sprintf """{ "level": "%A", "date": "%s", "msg": "%s" }""" level (dateTime.ToString()) msg

let private log (level: Level) msg =
    let date = DateTime.UtcNow

    Console.WriteLine(
        entryToJson
            { Level = level
              Msg = msg
              DateTime = date }
    )

module Logger =
    let info = log Level.Info
    let debug = log Level.Debug
    let error = log Level.Error
