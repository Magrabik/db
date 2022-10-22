using System;
using System.Collections.ObjectModel;
void FillArray(int[] collection)
{
     int length = collection.Length;
     int index = 0;
     while (index < length)
     {
          collection[index] = new Random().Next(1, 10);

          index++;
     }
}


void PrintArray(int[] col)
{
     int count = col.Length;
     int position = 0;
     while (position < count)
     {
          System.Console.WriteLine(col[position]);
          position++;
     }

}

int IndexOf(int[] collection, int find)
{
     int count = collection.Length;
     int index = 0;
     int position = -1;

     while (index < count)
     {
          if (collection[index] == find)
          {
               position = index;
               break;

          }

          index++;
     }
     return position;



}


int[] Array = new int[10];

FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();

int pos = IndexOf(Array, 4);
System.Console.WriteLine(pos);