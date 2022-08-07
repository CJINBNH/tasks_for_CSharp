Console.Clear();
Console.WriteLine("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    if (count % 2 != 0)
    {
        count = count + 1;
        Console.Write(count);
    }
    else
    {
        count = count + 1;
    }
}