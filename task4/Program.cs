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
if(count < N)
{
    while(count <= N)
    {
        Console.WriteLine(count);
        count++;
    }
}
else
{
    while(count >= N)
    {
        Console.WriteLine(N);
        N++;
    }
}