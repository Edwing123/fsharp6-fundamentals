module App.Logging

open System

type Level =
    | Info
    | Debug
    | Error

type JsonEntry =
    { Level: Level
      Msg: string
      DateTime: DateTime }

let jsonEntryToString
    { Level = level
      Msg = msg
      DateTime = dateTime }
    =
    sprintf """{ "level": "%A", "date": "%s", "msg": "%s" }""" level (dateTime.ToString()) msg

let log (level: Level) msg =
    let date = DateTime.UtcNow

    Console.WriteLine(
        jsonEntryToString
            { Level = level
              Msg = msg
              DateTime = date }
    )

let info = log Level.Info

let debug = log Level.Debug
