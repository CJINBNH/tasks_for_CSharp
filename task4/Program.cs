Console.Clear();
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = -numberN;
if(numberN > 0)
{
    while (count <= numberN)
    {
        Console.Write(count);
        count = count + 1;
    }
}
else
{
    while (count >= numberN)
    {
        Console.Write(count);
        count = count - 1;
    }
}