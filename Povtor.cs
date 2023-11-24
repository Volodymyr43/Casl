using System;
public class Test
{
 public static int getNumber(int x)
 {
   int i = 1;
   int n = 0;
   int res;
   while (i <= 1000 & n != x)
   {
     res = i%2;
     if (res !=0)
     {
     Console.WriteLine(i);
     n++;
     }
   i++;
   }
  return i;
}
public static void Main()
{
  int x = int.Parse(Console.ReadLine());
  getNumber(x);
  }
}
