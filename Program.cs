// показать числа от -N до N
Console.WriteLine("введите число");
int x=int.Parse(Console.ReadLine());
int min=-x;
while(min<=x)
{
Console.Write(" " + min);
min ++;
}
