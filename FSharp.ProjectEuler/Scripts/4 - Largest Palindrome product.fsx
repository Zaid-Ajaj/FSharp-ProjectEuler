let isPalindrome (n:int) = 
    let list = (string n).ToCharArray()
    list = Array.rev list

[for i in 100..1000 do
    for j in 100..1000 do
        if isPalindrome(i * j) then yield (i * j)]
|> Seq.max