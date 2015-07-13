open System.IO
open System.Windows.Forms
open System.Collections.Generic

let ofd = new OpenFileDialog()
ofd.ShowDialog()

// choose file "first million primes.txt" 
let primes = File.ReadLines(ofd.FileName)
             |> Seq.map int
             |> Seq.toArray

primes.[10000]



             