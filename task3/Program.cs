Console.Clear();
Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
//решение с помощью switch
switch(day)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("This is not a week or weekend day");
        break;
}
//решение с помощью if
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if(day == 2)
{
    Console.WriteLine("Вторник");
}
else if(day == 3)
{
    Console.WriteLine("Среда");
}
else if(day == 4)
{
    Console.WriteLine("Четверг");
}
else if(day == 5)
{
    Console.WriteLine("Пятница");
}
else if(day == 6)
{
    Console.WriteLine("Суббота");
}
else if(day == 7)
{
    Console.WriteLine("Воскресенье");
}
else if(day > 7)
{
    Console.WriteLine("Нет такого дня недели");
}