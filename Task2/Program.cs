Console.WriteLine("Введите число 1 ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int y = int.Parse(Console.ReadLine());

if(x % y == 0)
{
    Console.WriteLine("Число 2 кратно числу 1");
}
else
{
    Console.WriteLine(x % y);
}
