let line = System.Console.ReadLine()
let result =
    line.Split(' ')
    |> Array.map int
    |> Array.filter (fun x -> x % 2 = 0)
    |> Array.map (fun x -> x * x)
    |> Array.sum
printfn "%d" result
