//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите цифру обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    Console.WriteLine ("Введите число от 1 до 7");
}

if (number < 1 )
{
    Console.WriteLine ("Введите число от 1 до 7");
}
if (number == 6) 
{
    Console.WriteLine ("Это Суббота - Выходной день!");
}
if (number == 7) 
{
    Console.WriteLine ("Это Воскресенье - Выходной день!");
}
if (number == 1) 
{
    Console.WriteLine ("Это Понедельник - Рабочий день!");
}
if (number == 2) 
{
    Console.WriteLine ("Это Вторник - Рабочий день!");
}
if (number == 3) 
{
    Console.WriteLine ("Это Среда - Рабочий день!");
}
if (number == 4) 
{
    Console.WriteLine ("Это Четверг - Рабочий день!");
}
if (number == 5) 
{
    Console.WriteLine ("Это Пятница - Рабочий день!");
}