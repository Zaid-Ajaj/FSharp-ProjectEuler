open System.Numerics

Seq.map (fun a -> Seq.map (fun b -> BigInteger.Pow(a,b)) [2..100]) [2I..100I]
|> Seq.concat
|> Seq.distinct
|> Seq.length

// 9183