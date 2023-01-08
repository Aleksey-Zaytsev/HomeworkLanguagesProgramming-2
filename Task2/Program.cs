//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number < 100)
{
    Console.WriteLine ("У заданного числа нет третий цифры");
}

if ((number > 99)&&(number < 1000))
{
    int result3 = number % 100;
    int result4 = result3 % 10;
    Console.Write ("Третьей цифрой указанного числа является: ");
    Console.WriteLine (result4);
}

if (number > 999)
{
    while (number > 1000)
    {
        number = number / 10; 
    }
    Console.Write ("Третьей цифрой указанного числа является: ");
    Console.WriteLine (number%10);
    
}




