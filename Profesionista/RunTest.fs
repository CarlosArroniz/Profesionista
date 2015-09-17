module Profesionista.RunTest

open Profesionista.Suite.SignUp

open canopy
open runner
open System

context "SignUp as a Candidate"
open SignUp
SignUp.Test()
run()
let x = Console.ReadLine()