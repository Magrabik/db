System.Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int mod = num;
if (num < 0)
{
     mod = -num;
}
System.Console.WriteLine($"{mod} is abs of {num}");