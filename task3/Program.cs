// Принимаем N, выводим от -N  до N


Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (N > 0)
{
    i = (-N);
}
else 
{ 
    i = N;
    N = (-N);
};

while(i <= N)
{
    Console.WriteLine(i);
    i++;
}
