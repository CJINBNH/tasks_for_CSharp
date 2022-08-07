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
//для любого целого, через if
if(count < numberN)
{
    while(count <= numberN)
    {
        Console.WriteLine(count);
        count++;
    }
}
else
{
    while(count >= numberN)
    {
        Console.WriteLine(numberN);
        numberN++;
    }
}