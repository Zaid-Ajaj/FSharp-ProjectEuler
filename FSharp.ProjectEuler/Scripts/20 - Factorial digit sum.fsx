let factorial n = Seq.fold (*) 1I [1I..n]

(factorial 100I).ToString().ToCharArray() |> Seq.map (string >> int) |> Seq.sum