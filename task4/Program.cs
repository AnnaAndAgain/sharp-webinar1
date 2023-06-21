// Принимаем трехзначное число, выводим последнюю строку

Console.WriteLine("Введите трехзначное число:");
int  number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number>99 & number<1000) 
{
    number = number%10;
    Console.WriteLine(number);
}
else Console.WriteLine("Вы ошиблись, это не трехзнаное число!");

