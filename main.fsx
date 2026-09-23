let n = int (System.Console.ReadLine())
let nums = [for _ in 1..n -> int (System.Console.ReadLine())]
let result : int = List.sum nums
printfn "%d" result
