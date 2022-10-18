using System;
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница



System.Console.WriteLine("Введите число от 1 до 7");
string volue = Console.ReadLine();
int dayofweek = Convert.ToInt32(volue);

if(dayofweek == 1) 
{
     System.Console.WriteLine("Понедельник");
}

if(dayofweek == 2) 
{
     System.Console.WriteLine("Вторник");
}

if(dayofweek == 3) 
{
     System.Console.WriteLine("Среда");
}

if(dayofweek == 4) 
{
     System.Console.WriteLine("Четверг");
}

if(dayofweek == 5) 
{
     System.Console.WriteLine("Пятница");
}

if(dayofweek == 6) 
{
     System.Console.WriteLine("Суббота");
}

if(dayofweek == 7) 
{
     System.Console.WriteLine("Воскресенье");
}

