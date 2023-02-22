// Задача 1
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int InputInt(string message)
{
    System.Console.Write($"{message}");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}
int num = InputInt("Введите число > ");
int rem, sum = 0;
int temp = num;
while (num > 0)
{
    rem = num % 10;
    sum = (sum * 10) + rem;
    num = num / 10;
}
if (temp == sum)
{
    Console.WriteLine($"Число {temp} палиндром.");
}
else
{
    Console.WriteLine($"Число {temp} не палиндром");
}