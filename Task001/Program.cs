int MaxDigit (int number)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second) return first;
    else return second;
}

int Random ()
{
int num = new Random().Next(10,100);
Console.WriteLine($"Random Number: {num}");
return num;
}



Console.WriteLine ($"Maximal digit is {MaxDigit(Random())}");