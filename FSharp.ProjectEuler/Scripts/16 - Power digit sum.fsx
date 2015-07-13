open System.Numerics
open System

BigInteger.Pow(2I, 1000).ToString().ToCharArray()
|> Seq.map (string >> int)
|> Seq.sum