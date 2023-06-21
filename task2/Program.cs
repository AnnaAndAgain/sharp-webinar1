// День недели по номеру

Console.WriteLine("Введите номер дня недели");

int daynum = Convert.ToInt32(Console.ReadLine());

/*if (daynum=1) 
{
    Console.WriteLine("понедельник");
}
else if  (daynum=2) 
{
    Console.WriteLine("вторник");
}
else if  (daynum=3) 
{
    Console.WriteLine("среда");
}
else if  (daynum=4) 
{
    Console.WriteLine("четверг");
}
else if  (daynum=5) 
{
    Console.WriteLine("пятница");
}
else if  (daynum=6) 
{
    Console.WriteLine("суббота");
}
else if  (daynum=7) 
{
    Console.WriteLine("воскресенье");
}
else Console.WriteLine("В неделе ровно 7 дней");
*/

switch (daynum) 
{
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("воскресенье");
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;
};