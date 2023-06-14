/* Принимает на ввод два числа и если первое кратно второму выдает ответ кратно,
*если нет, то остаток от деления.
*/

// int DoubleInput()
// {
// Console.Write("Enter first number, please: ");
// string first = Console.ReadLine()!;
// Console.Write("Enter second number, please: ");
// string second = Console.ReadLine()!;

// int firstnum = int.Parse(first);
// int secondnum = int.Parse(second);


// return (first, second);
// }

string Divisible (int fn, int sn)
{
string answer = "";
if (fn % sn == 0)
{
    answer = "Divisible";
}
else
{
    answer = $"Non Divisible, reminder is: {fn % sn}";
}
return answer;
}

Console.Write("Enter first number, please: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number, please: ");
int second = Convert.ToInt32(Console.ReadLine());



Console.WriteLine (Divisible (first, second));
