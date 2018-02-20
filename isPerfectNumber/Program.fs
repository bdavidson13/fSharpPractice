// Learn more about F# at http://fsharp.org
// Should take a number and tell whether it is
// perfect (sum of its divisors = the number )
// abundant soid > num
// defecient soid < num

open System

let isFactor x y = x % y = 0

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
