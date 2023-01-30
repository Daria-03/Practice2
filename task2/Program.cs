// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a%10;
if (a>99)
{
     Console.WriteLine(result);
}
else
{
     Console.WriteLine("Третьей цифры нет ");
}