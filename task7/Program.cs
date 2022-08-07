Console.Clear();
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
//нужно сравнить два числа и вывести большее
if (firstNumber > secondNumber)
{
    Console.Write("max = ");
}
else if (secondNumber > thirdNumber)
{
    max = secondNumber;
    Console.Write("max = ");
}
else if (thirdNumber > firstNumber)
{
    max = thirdNumber;
    Console.Write("max = ");
}
Console.WriteLine(max);