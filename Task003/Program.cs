/* Принимает на ввод два числа и если первое кратно второму выдает ответ кратно,
*если нет, то остаток от деления.
*/
Console.Write("Enter first number, please: ");
string first = Console.ReadLine()!;
Console.Write("Enter second number, please: ");
string second = Console.ReadLine()!;

int firstnum = int.Parse(first);
int secondnum = int.Parse(second);
string answer = "";

if (firstnum % secondnum == 0)
{
    answer = "Divisible";
    // Console.WriteLine("Yes");
}
else
{
    answer = $"Non Divisible, reminder is: {firstnum % secondnum}";
    // Console.WriteLine("No");
}
Console.WriteLine (answer);
