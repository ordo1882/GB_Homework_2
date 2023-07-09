// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a week day number:");
int day = Convert.ToInt32(Console.ReadLine());

if ((day == 6) || (day == 7))
{
    Console.WriteLine($"It's a day off.");
}
else if ((day > 0) && (day < 6))
{
    Console.WriteLine($"This is normal working day.");
}
else
{
    Console.WriteLine($"There are no day exists by this number {day}");
}