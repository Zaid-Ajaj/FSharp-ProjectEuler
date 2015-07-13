let rec insertions x = function
    | []             -> [[x]]
    | (y :: ys) as l -> (x::l)::(List.map (fun x -> y::x) (insertions x ys))

let rec permutations = function
    | []      -> seq [ [] ]
    | x :: xs -> Seq.concat (Seq.map (insertions x) (permutations xs))

let permsSorted = Seq.sort (permutations [0..9])

permsSorted
|> Seq.mapi (fun i xs -> (i+1,xs))
|> Seq.find (fun (i,ls) -> i = 1000000)

// val it : int * int list = (1000000, [2; 7; 8; 3; 9; 1; 5; 4; 6; 0])