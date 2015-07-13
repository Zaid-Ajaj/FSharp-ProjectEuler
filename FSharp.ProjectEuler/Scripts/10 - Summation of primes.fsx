open System.IO
open System.Windows.Forms
open System.Collections.Generic

let ofd = new OpenFileDialog()
ofd.ShowDialog()

let primes = File.ReadLines(ofd.FileName)
             |> Seq.map (int >> bigint)

primes 
|> Seq.filter (fun n -> n < 2000000I)
|> Seq.sum