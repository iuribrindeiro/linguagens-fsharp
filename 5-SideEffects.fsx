//Em F# é permitido o uso de efeitos colaterais:

let mutable x = 10

//Funcao altera valor de algo fora do seu escopo
let changeValue (x: byref<int>) = x <- 20

changeValue &x

System.Console.WriteLine(x)
