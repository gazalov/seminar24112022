
int what = new Random().Next(10, 100);
int deci = what / 10;
int x = what % 10;
int result;
if(deci>x) 
{
    result = deci;
}
else
{
    result = x;
}
Console.WriteLine($"Рандомное число: {what}");
Console.WriteLine(result);
