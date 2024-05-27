//Todos os parametros e retornos de funcoes em F# sao genericos por padrao:

let toTuple a b = (a, b)

let toString x y = $"({x}, {y})"


let tuple = toTuple 1 2
let str = toString 1 2

System.Console.WriteLine(tuple)
System.Console.WriteLine(str)
System.Console.WriteLine(toString tuple tuple)
