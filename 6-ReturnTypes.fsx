//Em F#, uma funcao deve sempre retornar um valor:

let sum (x: int) (y: int) : int = x + y

//O compilador irá reclamar que a função não retorna um valor
//void não existe para funcoes
// let doSomething (a: int) (b: int) : void =
// let res = sum a b

//Para funcoes que nao precisam retornar um valor, o tipo unit pode ser usado
let doSomething2 (a: int) (b: int) : unit =
    let res = sum a b
    ()

let result = doSomething2 1 1
