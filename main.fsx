let minMax (list: int list) : int * int =
    (List.min(list), List.max(list))

let n = int (System.Console.ReadLine())
let nums = [for _ in 1..n -> int (System.Console.ReadLine())]
let (mn, mx) = minMax nums
printfn "min: %d" mn
printfn "max: %d" mx
