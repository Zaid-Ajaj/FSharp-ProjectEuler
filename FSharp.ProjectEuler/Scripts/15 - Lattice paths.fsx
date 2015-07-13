let factorial n = Seq.fold (*) 1I [1I..n]

let binomial n k = factorial n / (factorial k * factorial (n-k))

// 20 by 20 grid means -> Binomial (20+20,20)
let latticePath = binomial 40I 20I