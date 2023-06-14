int Random()
{
    int num = new Random().Next(100, 1000);
    // Console.WriteLine($"Random Number: {num}");
    return num;
}

int SecondFigureDelete(int number)
{
    int firstFigure = number / 100;
    int secondFigure = number % 10;
    return firstFigure * 10 + secondFigure;
}

int rnd = Random();

Console.WriteLine($"Random number is: {rnd}; one with deleted second figure is: {SecondFigureDelete(rnd)}");
