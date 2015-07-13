open System.Collections.Generic

let rec fibonacci = 
    let cache = new Dictionary<_,_>()
    fun n ->
        if cache.ContainsKey n then cache.[n]
        elif n <= 2I then 1I
        else
            let res = fibonacci (n-1I) + fibonacci (n-2I)
            cache.[n] <- res
            res

let mutable iterator = 1I
let mutable length = 0

while length < 1000 do
    let res = (fibonacci iterator).ToString().ToCharArray().Length
    printfn "%A" (iterator,res)
    length <- res
    iterator <- iterator + 1I