open System.IO
open System.Windows.Forms
open System.Collections.Generic


let ofd = new OpenFileDialog()
ofd.ShowDialog()

//" data\first million primes.txt"
let primes = File.ReadAllLines(ofd.FileName)
             |> Seq.map int
             |> HashSet<int>

let prime n = primes.Contains(n)

let quadratic a b = fun n -> n*n + a*n + b

let infinity = Seq.initInfinite (fun n -> n)

[for a in -1000..1000 do
    for b in -1000..1000 do
        let f = quadratic a b
        let primes = Seq.takeWhile (fun n -> f n |> prime) infinity |> Seq.length 
        if primes > 1 then yield (a,b,primes)]
|> Seq.maxBy (fun (_,_,primes) -> primes)
 
let product = -61 * 971 // = -59231

// val it : int * int * int = (-61, 971, 70)
// so n*n -61n + 971 produces 71 primes
// a,b, number of primes
//(-61, 971, 71)
//(-59, 911, 70)
//(-57, 853, 69)
//(-55, 797, 68)
//(-53, 743, 67)
//(-51, 691, 66)
//(-49, 641, 65)
//(-47, 593, 64)
//(-45, 547, 63)
//(-43, 503, 62)