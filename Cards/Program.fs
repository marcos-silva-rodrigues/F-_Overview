﻿let cardNo = 12

let cardDescrition = 
  if cardNo = 1 || cardNo = 14 then "Ace"
  elif cardNo = 11 then "Jack"
  elif cardNo = 12 then "Queen"
  elif cardNo = 13 then "King"
  else string cardNo
printfn "%s" cardDescrition