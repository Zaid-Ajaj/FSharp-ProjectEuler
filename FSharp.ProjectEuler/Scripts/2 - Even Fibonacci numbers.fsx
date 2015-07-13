let rec fibonaccci n = 
    match n with
    | 0 
    | 1 -> 1
    | n -> fibonaccci (n-1) + fibonaccci (n-2)

[1..100]
|> Seq.takeWhile (fun n -> fibonaccci n < 4000000)
|> Seq.map fibonaccci
|> Seq.filter (fun n -> n % 2 = 0)
|> Seq.sum