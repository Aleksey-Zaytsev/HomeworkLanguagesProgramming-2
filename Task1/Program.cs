// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000))
{
  int result = number / 10;
  int result2 = result % 10;
  Console.WriteLine (result2);
}
else
{
    Console.WriteLine ("Это число не трехзначное");
}

