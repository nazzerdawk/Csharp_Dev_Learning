long i = 0; 
long p = 0;
while (p<=10001){
    i++;
    if (IsPrime(i)){
        p += 1;   
    }
    string primestr = p.ToString();
    int strlength = primestr.Length-1;
    string lastchar = Convert.ToString(primestr[strlength]);
    string numsuffix = "";
    switch (lastchar){
        case "0": numsuffix = "th"; break;
        case "1": numsuffix = "st"; break;
        case "2": numsuffix = "nd"; break;
        case "3": numsuffix = "rd"; break;
        case "4": numsuffix = "th"; break;
        case "5": numsuffix = "th"; break;
        case "6": numsuffix = "th"; break;
        case "7": numsuffix = "th"; break;
        case "8": numsuffix = "th"; break;
        case "9": numsuffix = "th"; break;
    }
    Console.WriteLine("Last calculated prime is {0}, the {1}{2} prime.",i,p,numsuffix);
}
Console.ReadKey();
bool IsPrime(long n){
    for (int i=2;i<n;i++){
        if (n % i == 0)
            return false;
    }
    return true;
}
