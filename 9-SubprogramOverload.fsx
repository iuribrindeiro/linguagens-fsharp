//Em F# subprogramas podem ser sobrecarregados apenas quando são membros de um tipo e usam tuplas como parametros,
//como no exemplo abaixo:

type MathOps() =
    member this.Sum(x: int, y: int) : int = x + y
    member this.Sum(x: float, y: float) : float = x + y


let mathOps = MathOps()

System.Console.WriteLine(mathOps.Sum(1, 1))
System.Console.WriteLine(mathOps.Sum(1.0, 1.0))

let sum (x: int) (y: int) : int = x + y

//Quebra em tempo de compilacao, pois a função sum já foi definida
//let sum (x: float) (y: float) : float = x + y

//Comumente, funções com o mesmo nome e tipos de parametros diferentes são definidas em módulos diferentes

module Float =
    let sum (x: float) (y: float) : float = x + y


let res = Float.sum 1.0 1.0
