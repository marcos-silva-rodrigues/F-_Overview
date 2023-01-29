[<EntryPoint>]
let main argv =
  printfn "Welcome to the calculator program"

  printfn "Type the first number"
  let firstNo = System.Console.ReadLine()
  printfn "Type the second number"
  let secondNo = System.Console.ReadLine()
  printfn "First %s, Second %s" firstNo secondNo

  let sum = (int firstNo) + (int secondNo)
  printfn "the sum is %i" sum
  0
  