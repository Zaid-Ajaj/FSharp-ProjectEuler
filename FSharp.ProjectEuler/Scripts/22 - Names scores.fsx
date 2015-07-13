open System.IO
open System.Windows.Forms

let ofd = new OpenFileDialog()
ofd.ShowDialog()

let charValues = Seq.zip [1..26] ['A'..'Z']

let names = File.ReadAllText(ofd.FileName).Split(',')
            |> Array.map (fun str -> str.Replace('"',' ').Trim())
            |> Array.sort

let getValues (name:string) = 
    name.ToCharArray()
    |> Seq.map (fun c -> Seq.find (fun (value,char') -> c = char') charValues |> fst)
    |> Seq.sum

names
|> Seq.mapi (fun i name -> i * getValues name)
|> Seq.sum