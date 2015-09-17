module Profesionista.PageObjects.SignUp



open Profesionista.Common.Helper.Config

//Reg Data
let btnType = "//li[@class='chooseCandidate']"
let ProfName = "#Name"
let PatLN = "#LastName"
let MatLN = "#LastName2"
let mail = "#UserName"
let contr = "#Password"



// Gender & BirthDate
let day = "//select[@class='Day']"
let month = "//select[@class='Month']"
let year = "//select[@class='Year']"
let gender = "//li[@class='gender']//input[@value='Male']"
//Reg Button
let regBtn = "#RegisterButton"

