// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter a three-digit number:");
int n = Convert.ToInt32(Console.ReadLine());

if (((n > 99) && (n < 1000) || ((n < -99) && (n > -1000)))) // Учитываем также негативное число
{
    n = n % 10;
    if (n < 0)
    {
        n *= -1; // В случае негативного числа умножаем на -1
    }
    Console.WriteLine($"The third digit is {n}");
}
else
{
    Console.WriteLine($"There are no third digit in {n}.");
}