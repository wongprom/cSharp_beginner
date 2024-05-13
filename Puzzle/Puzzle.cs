namespace Puzzle;

public class Easy
{
    public static void FizzBuzz(int x, int y, int z)
    {
      for (int i = 1; i < z + 1; i++)
      {
        if(i % x == 0 && i % y == 0)
        {
          Console.WriteLine("FizzBuzz");
        }
        else if (i % x == 0) 
        {
          Console.WriteLine("Fizz");
        }
        else if (i % y == 0) 
        {
          Console.WriteLine("Buzz");
        }  
        else 
        {
          Console.WriteLine(i);
        }
      }
    }
}



