Console.Clear();
Console.WriteLine("Введите новое число: ");
int evenOdd = Convert.ToInt32(Console.ReadLine());
if (evenOdd % 2 != 0)
{
    Console.WriteLine("Это число нечетное");
}
else
{
    Console.WriteLine("Это число четное");
}