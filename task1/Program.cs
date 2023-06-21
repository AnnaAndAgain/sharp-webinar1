// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

number = number * number;

Console.WriteLine(number);
*/

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2) 
{
    Console.WriteLine($"Первое число {number1} — квадрат второго {number2}");
}
else
{
    Console.WriteLine($"Первое число {number1} — НЕ квадрат второго {number2}");
};
