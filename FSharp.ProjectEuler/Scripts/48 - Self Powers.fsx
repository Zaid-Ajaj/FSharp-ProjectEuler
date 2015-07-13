open System.Numerics

[1..1000]
|> Seq.map (fun n -> BigInteger.Pow(bigint n, n))
|> Seq.sum
|> fun sum -> 
    let digits = sum.ToString().ToCharArray()
    Seq.skip (Seq.length digits - 10) digits
    |> Seq.map string 
    |> String.concat ""