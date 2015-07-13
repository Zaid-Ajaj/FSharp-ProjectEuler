let isPrime n =
    if n < 2 then false
    else [2..n-1] |> Seq.exists (fun n' -> n % n' = 0) = false
       
[1..int(sqrt(float(600851475143I)))]
|> Seq.filter (fun n -> 600851475143I % bigint(n) = 0I && isPrime n)
|> Seq.max