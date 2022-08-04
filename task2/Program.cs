Console.WriteLine ("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberTwo > numberOne)
{
    Console.WriteLine(numberTwo / numberOne);
}
else
{
    Console.WriteLine(numberOne / numberTwo);
}