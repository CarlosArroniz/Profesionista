module Profesionista.Core.SignUp
open Profesionista.PageObjects.SignUp

open canopy
open runner
open System
open types

let SignUpTest() =
    Console.WriteLine("SignUp as a Profesionist")
    sleep 5
    click btnType
    Console.WriteLine("Fill Candidate Form")
    ProfName << "Carlos"
    PatLN << "Arroniz"
    MatLN << "Santana"
    mail << "fredyarroniz@hotmail.com"
    contr << "0123456"
    day << "28"
    month << "08"
    year << "1993"
    click gender
    click regBtn
()

