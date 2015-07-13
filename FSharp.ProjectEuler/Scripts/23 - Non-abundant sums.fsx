let divs n = Seq.filter (fun x -> n % x = 0) [1..n-1]

let isAbundant n = Seq.sum (divs n) > n

let abundants = [1..28123] |> List.filter (fun n -> isAbundant n)
   
let sumOfAbundants n = 
    let reduced = Seq.filter (fun x -> x <= n) abundants
    Seq.exists (fun a -> Seq.exists (fun b -> b + a = n) reduced) reduced
    
[1..28123]
|> Seq.filter (fun n -> printfn "%d" n; (sumOfAbundants >> not) n)                     
|> Seq.sum