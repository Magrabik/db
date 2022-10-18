// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да


System.Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();
int a = Convert.ToInt32(num1);

System.Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();
int b = Convert.ToInt32(num2);

if(a*a==b)
{
     System.Console.WriteLine("Да, является");
}
else 
{
     System.Console.WriteLine("Нет, не является");
}