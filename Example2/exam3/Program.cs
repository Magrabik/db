using System;
int[] Array = { 1, 23, 74, 48, 5, 6, 74, 8, 9 };

int n = Array.Length;
int find =74;
int index = 0;

while( index < n)
{
     if(Array[index] == find)
     {
          System.Console.WriteLine(index);
          break;
     }


     index++;
}
