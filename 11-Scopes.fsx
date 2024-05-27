//Em F#, valores definidos em um escopo podem ser acessados em qualquer funcao que foi definida dentro desse escopo.


let x = 10

let sum (y: int) : int = x + y


let sumTimes2 (y: int) : int =
    let newSum a = a + x
    (newSum y) * 2


let sumRes = sum 1

let sumTimes2Res = sumTimes2 1

System.Console.WriteLine(sumRes)
System.Console.WriteLine(sumTimes2Res)
