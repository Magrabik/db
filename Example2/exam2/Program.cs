using System;
int Max(int arg1, int arg2, int arg3)
{
     int result = arg1;
     if (arg2 > result) result = arg2;
     if (arg3 > result) result = arg3;
     return result;
}
//               0   1   2   3   4   5   6   7   8
int[] Array = { 12, 23, 344, 45, 56, 67, 78, 89, 91, };


int result = Max(
     Max(Array[0], Array[1], Array[2]),
     Max(Array[3], Array[4], Array[5]),
     Max(Array[6], Array[7], Array[8])
);
System.Console.WriteLine(result);