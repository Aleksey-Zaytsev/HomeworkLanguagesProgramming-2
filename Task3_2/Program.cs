Console.WriteLine ("Введите цифру обозначающую день недели");
Console.WriteLine ("1-ПН, 2-ВТ, 3-СР, 4-ЧТ, 5-ПТ, 6-СБ, 7-ВС");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Это Выходной день");
}
if ((number > 0)&&(number < 6))
{
    Console.WriteLine("Это рабочий день");
}
if ((number < 1)||(number > 7))
{
    Console.WriteLine ("Введите цифру от 1 до 7");
}