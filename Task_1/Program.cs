// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number:");
int n = Convert.ToInt32(Console.ReadLine());

if (((n > 99) && (n < 1000) || ((n < -99) && (n > -1000)))) // Учитываем также негативное число
{
    n = n / 10 * -1; // В случае негативного числа умножаем на -1
    n = n % 10;
    Console.WriteLine($"The second digit is {n}");
}
else
{
    Console.WriteLine($"{n} is not a three-digit number.");
}