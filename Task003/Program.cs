/* Принимает на ввод два числа и проверяет является ли первое
*квадратом второго. Выдает yes/no.
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
    answer = "Yes";
    // Console.WriteLine("Yes");
}
else
{
    answer = "No";
    // Console.WriteLine("No");
}
Console.WriteLine (answer);
