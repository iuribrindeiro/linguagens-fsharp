//Em F#, subprogramas podem ser definidos fora e dentro de outros subprogramas:

let sum (x: int) (y: int) : int = x + y


let sumTimes2 (x: int) (y: int) : int =
    let newSum a b = a + b
    (newSum x y) * 2

let sumTimes (x: int) (y: int) : int -> int = fun n -> (sum x y) * n

let sumTimes2And x y something =
    let newSum a b = a + b
    something ((newSum x y) * 2)


System.Console.WriteLine(sum 1 1)
System.Console.WriteLine(sumTimes2 1 1)
System.Console.WriteLine((sumTimes 1 1) 2)
System.Console.WriteLine((sumTimes 1 1) 3)
System.Console.WriteLine(sumTimes2And 1 1 (fun x -> x * 2))

//O motivo disso se dá pelo fato de que funcoes em F# são first-class citizens, ou seja,
//funcoes são tratadas como qualquer outro valor, podendo ser passadas como argumentos para outras funcoes,
//retornadas por outras funcoes e atribuidas a variaveis.
