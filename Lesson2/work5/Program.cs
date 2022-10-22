// 2.1. Напишите программу, которая выводит случайное число из отрезка
//  [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8
// 1213-> 3
// 845 -> 8


int number = new Random().Next(10, 10000);
System.Console.WriteLine(number);
int maxdigit = number % 10;
while (number > 0)
{
     int temp = number % 10;
     if (number % 10 > maxdigit) { maxdigit = temp;}
     number = number / 10;

}
System.Console.WriteLine(maxdigit);