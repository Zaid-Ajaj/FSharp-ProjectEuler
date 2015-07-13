let isEvenlyDivisibleBy n k = 
    [1..k] |> Seq.exists (fun k' -> n % k' <> 0) |> not

let rec search n k = 
    if isEvenlyDivisibleBy n k then n
    else search (n+1) k


//> search 2520 11;;
//val it : int = 27720
//> search 27720 12;;
//val it : int = 27720
//> search 27720 13;;
//val it : int = 360360
//> search 360360 14;;
//val it : int = 360360
//> search 360360 15;;
//val it : int = 360360
//> search 360360 16;;
//val it : int = 720720
//> search 720720 17;;
//val it : int = 12252240
//> search 12252240 18;;
//val it : int = 12252240
//> search 12252240 19;;
//val it : int = 232792560
//> search 232792560 20;;
//val it : int = 232792560