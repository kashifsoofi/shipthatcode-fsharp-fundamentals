type Shape =
    | Circle of float
    | Square of float

let area s =
    match s with
    | Circle r -> System.Math.PI * r * r
    | Square s -> s * s

let kind = System.Console.ReadLine()
let dim = float (System.Console.ReadLine())
let s = if kind = "circle" then Circle dim else Square dim
printfn "%.2f" (area s)
