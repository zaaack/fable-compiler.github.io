module WebGenerator.Types

open System
open Fable.Core

type PageInfo =
  { Title: string
    TargetPath: string
    NavbarActivePage: string }

type SampleInfo =
  abstract entry: string
  abstract title: string
  abstract desc: string
  abstract img: string

type JsObj<'T> =
  [<Emit("$0[$1]")>]
  abstract Item: string->'T
