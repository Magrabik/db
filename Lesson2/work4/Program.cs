// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


int Prompt(string message)
{
     System.Console.WriteLine(message);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}

bool divBy(int number)
{
     return (number % 7 == 0) && (number % 23 == 0);
}

int A = Prompt("Введите число ");
if (divBy(A))
{
     System.Console.WriteLine("Да");
}
else
{
     System.Console.WriteLine("Нет");
}