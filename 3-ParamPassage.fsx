//Em F#, é possivel passar parametros para subprogramas de duas formas: por valor e por referência.

let mutable x = 10

let changeValue (x: byref<int>) = x <- 20

changeValue &x

System.Console.WriteLine(x)

//Quebra em tempo de compilacao, pois x é uma variável imutável por padrão
// let changeValue (x: int) = x <- 20

type MyType = { x: int }

let changeValue2 (a: MyType) : MyType = { a with x = 20 }

let value = { x = 10 }

//Passa o valor de value para a função changeValue2 que foi alocado na heap.
//Apenas a referência de value é passada para a função, não o valor em si.
let newValue = changeValue2 value

System.Console.WriteLine(value)
System.Console.WriteLine(newValue)


let value3 = 1

let changeValue3 (a: int) : int = a + 1

//Passa o valor de value para a função changeValue3 que foi alocado na stack.
//O valor de value é copiado para a função, não a referência.
let newValue3 = changeValue3 value3

System.Console.WriteLine(value3)
System.Console.WriteLine(newValue3)
