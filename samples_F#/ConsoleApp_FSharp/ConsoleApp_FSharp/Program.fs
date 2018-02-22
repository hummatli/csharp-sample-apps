// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "Press enter to continue"
    let x = Console.ReadLine()
    0 // return an integer exit code
