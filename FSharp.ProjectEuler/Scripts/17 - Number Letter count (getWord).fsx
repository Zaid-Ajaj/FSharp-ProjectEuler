let digits = 
    Seq.zip [0..19] ["zero";"one";"two";"three";"four";"five";"six";"seven";"eight";"nine";"ten"
                     "eleven";"twelve";"thirteen";"fourteen";"fifteen";"sixteen";"seventeen";"eighteen";"nineteen"]

let tens = 
    Seq.zip [for i in 2..9 -> i*10] ["twenty";"thirty";"forty";"fifty";"sixty";"seventy";"eighty";"ninety"]

let getTens (n:int) =   
    let tens = 10 * int (n.ToString().[0].ToString())
    (tens, n-tens)

let getHundreds (n:int) = 
    let hundreds = 100 * int (n.ToString().[0].ToString())
    let tens = 10 * int (n.ToString().[1].ToString())
    (hundreds, tens, n-(hundreds+tens))

let rec getWord n =
    if n = 0 || n > 999 then ""
    elif n <= 19 then 
        Seq.filter (fun (x,_) -> x = n) digits 
        |> Seq.head |> snd
    elif n >= 20 && n < 100 then 
        let tens', digit = getTens n
        let strTens = Seq.filter (fun (x,_) -> x = tens') tens |> Seq.head |> snd
        if digit = 0 then strTens
        else strTens + " " + getWord digit
    else
        let hundreds',tens',digit = getHundreds n
        let strHundres = Seq.filter (fun (x,_) -> x = (hundreds'/100)) digits |> Seq.head |> snd
        if n <> hundreds' then 
            strHundres + " hundred and " + getWord (tens'+digit)
        else 
            strHundres + " hundred " + getWord (tens'+digit)

[1..999] 
|> Seq.map (fun n -> String.filter (fun c -> c <> ' ') (getWord n))
|> Seq.map (fun str -> str.Length)
|> Seq.sum // 21113

"onethousand".Length // 11

// total = 21124