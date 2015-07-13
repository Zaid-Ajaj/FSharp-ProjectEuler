let triangleNumber n = (n*n + n)/2

let divisors n = 
    let mutable count = 0
    for i = 1 to n do
        if n % i = 0 then count <- count + 1
    count

// (nth triangle number, number of ddivisors) []
[| 1..20000 |]
|> Array.Parallel.map (fun n -> n, (triangleNumber >>  divisors) n)
|> Seq.sortByDescending snd
|> Seq.take 10

// we get this;
[(14399, 648); (16575, 576); (17199, 576); (12375, 576); (18095, 512)]
|> Seq.map fst
|> Seq.min |> triangleNumber


// the 18095th triangle number has 512 div