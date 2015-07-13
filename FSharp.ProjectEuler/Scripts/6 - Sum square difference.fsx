let sumOfSquares = 
    [1..100] |> Seq.map (fun n -> n * n) |> Seq.sum

let squareOfSums = 
    [1..100] |> Seq.sum |> fun n -> n * n

let diff = squareOfSums - sumOfSquares