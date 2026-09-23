let rec sumList = function
    | [] -> 0
    | head :: tail -> head + sumList tail

let line = System.Console.ReadLine()
let nums = line.Split(' ') |> Array.map int |> Array.toList
printfn "%d" (sumList nums)
