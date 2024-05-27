//Em F#, apenas 1 valor pode ser retornado de uma funcao:

let sum (x: int) (y: int) : int = x + y


//Para retornar mais de um valor, tuplas podem ser usadas, mas sempre 1 tupla é retornada com x valores.
let sumTwice (x: int) (y: int) : int * int = (x + y, x + y)


//O mesmo pode ser feito com records, que são tipos de dados que podem ser usados para armazenar valores de diferentes tipos
let sumRecord (x: int) (y: int) : {| sum: int; sumTwice: int * int |} =
    {| sum = x + y
       sumTwice = (x + y, x + y) |}


let resultTuple = sumTwice 1 1
let recordResult = sumRecord 1 1

System.Console.WriteLine(resultTuple)
System.Console.WriteLine(recordResult)
