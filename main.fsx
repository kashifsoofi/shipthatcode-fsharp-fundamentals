let minOf3 a b c =
    let d = min a b
    min c d

let a = int(System.Console.ReadLine())
let b = int(System.Console.ReadLine())
let c = int(System.Console.ReadLine())

printfn "%d" (minOf3 a b c)
