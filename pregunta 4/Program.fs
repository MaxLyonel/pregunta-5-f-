// Pregunta N° 5 de Examen de INF - 319

open System

(*let sum a b = a + b*)
let mutable c = 0
let mul a b : int = 
    for i in 1..b do
        c <- c + a
    c
    
// Multiplicación con sumas sucesivas de dos números
[<EntryPoint>]
let main argv =
    
    (*let c = sum 5 7
    printfn "Suma 5+7 = %i" c*)
    let m = mul 3 4
    printfn "Mult 3*4 = %i" m
    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
