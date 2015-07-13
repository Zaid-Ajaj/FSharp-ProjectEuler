[for i in 1..1000 do
 for j in 1..i do
 for k in 1..j do 
 if k*k + j*j = i*i && i+k+j = 1000 then yield (i,j,k)]
|> List.head
|> fun (a,b,c) -> a*b*c