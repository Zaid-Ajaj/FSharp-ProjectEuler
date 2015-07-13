open System.Collections.Generic

// memoized collatz sequence generator
let rec collatz = 
    let cache = Dictionary<_, _>()
    fun n ->
        if cache.ContainsKey(n) then cache.[n]
        else
            let res = 
                match n with
                | n when n = 1I -> 1I
                | n when n % 2I = 0I -> 1I + collatz (n/2I)  
                | _ -> 1I + collatz (3I * n + 1I) 
            cache.[n] <- res 
            res

[1..1000000]
|> Seq.map (fun n -> n,collatz (bigint n))
|> Seq.maxBy snd

// 837799 -> 525 chains