let n = int (System.Console.ReadLine())
let nums = [for _ in 1..n -> int (System.Console.ReadLine())]
// TODO: use a |> pipeline with List.filter, List.map, and List.sum
// to compute the sum of squares of the EVEN numbers in `nums`.
let result : int =
    nums
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * x)
    |> List.sum
printfn "%d" result
