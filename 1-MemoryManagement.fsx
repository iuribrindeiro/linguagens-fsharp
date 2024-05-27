//Em F#, valores podem ser alocadas em memoria dinamicamente ou estaticamente:

//Essa variável é alocada dinamicamente, ou seja, ela é alocada em memória no momento em que é criada
let x = 10

//Essa variável é alocada estaticamente, ou seja, ela é alocada em memória no momento em que o programa é compilado
[<Literal>]
let y = 20

System.Console.WriteLine(x)
System.Console.WriteLine(y)
//ref: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/literals
