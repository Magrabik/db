// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.


int Promt(string massage)
{
     System.Console.Write(massage + " > ");
     return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int number)
{
     if (number <= 0)
     {
          System.Console.WriteLine("Число должно быть положительным");
          return false;
     }
     return true;
}

int SumNumbers(int number)
{
     int sum = 0;
     for (int i = 1; i <= number; i++)
     {
          sum += i;
     }
     return sum;
}

int SumGauss(int number)
{
     return (int)((number / 2) * (1 + number));
}

int number = Promt("Введите число");
if (ValidateNumber(number))
{
     int sum = SumNumbers(number);
     int sumGauss = SumGauss(number);
     System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}, а Гаусс говорит {sumGauss}");
}