//F# se trata de uma linguagem estaticamente tipada, ou seja, o tipo de uma variável é definido em tempo de compilação:

//O tipo de a e b é int e o retorno da funcao é int
let sumWithTypes (a: int) (b: int) : int = a + b

//Mesmo que a e b não tenham sido definidos explicitamente, o compilador consegue inferir o tipo deles
//dado que sao usados como valores interios sendo somados (a + b)
let sum a b = a + b


let res1 = sum 1 1
let res2 = sumWithTypes 1 1

//Quebra em tempo de compilação, pois o compilador espera 2 valores interios para a chamada das duas funcoes
// let break = sum 1 "1"
// let break2 = sumWithTypes 1 "1"
