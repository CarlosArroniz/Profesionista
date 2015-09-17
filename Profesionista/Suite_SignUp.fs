module Profesionista.Suite.SignUp

open canopy
open types
open System
open runner
open Profesionista.Common.Helper.Config

module SignUp =
    open Profesionista.Core.SignUp

    let Test() =
        "SignUp as a Candidate" &&&& (fun _->
        start browser
        pin FullScreen
        url urlProfe
        SignUpTest()
        )


