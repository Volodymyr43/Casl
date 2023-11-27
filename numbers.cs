using System;
 
public class Test
{
    public static int getNumber(int x)
	  {
		int a;
	  int b;
	  int count = 0;
	       if (x < 0 )
	       {
	       Console.Write("-");
	       }
	    
	  	while (x != 0)
		  {
		    a = Math.Abs(x%10);
	      b = Math.Abs(x/10);
	      count++;
		    x = x/10;
		   
		    if ( x!=0 & a!=0)
	        {
	        Console.Write($"{a}");
	        }
	        if ( x!=0 & x<10 & x>0)
	        {
	        Console.Write($"{x}");
	        }
	        if ( x!=0 & x>-10 & x<0)
	        {
	        Console.Write($"{Math.Abs(x)}");
	        }
		  }
		    return count;
	    }
  
  public static void Main()
  {
  int x = Convert.ToInt32(Console.ReadLine());
  getNumber(x);
  }
}
