// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int Prompt(string message)
{
     System.Console.WriteLine(message);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}

int divBy(int A, int B)
{
     return (B % A);
}

int A = Prompt("Введите первое число");
int B = Prompt("Введите второе число");

if (divBy(A, B) == 0)
{
     System.Console.WriteLine("Кратно");
}
else
{
     System.Console.WriteLine(B % A);
}