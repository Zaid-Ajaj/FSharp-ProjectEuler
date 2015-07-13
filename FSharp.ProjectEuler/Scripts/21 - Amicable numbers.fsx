let divisors n = Seq.filter (fun x -> n % x = 0) [1..n-1]

let isAmicable n = 
    let m =  Seq.sum (divisors n)
    Seq.sum (divisors m) = n && n <> m

[1..10000]
|> Seq.filter isAmicable
|> Seq.sum