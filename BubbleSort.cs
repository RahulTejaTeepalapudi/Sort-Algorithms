using System;


namespace BubbleSort
{
  class Program
  {
    private static int[] A;
    private static void BubbleSort_Iterative()
    {
      int temp;
      int n = A.Length;
      bool swapped;

      for (int i = 0; i < n - 1; i++)
      {
        swapped = false;
        for (int j = 0; j < n - i - 1; j++) // This loop itself sorts the Array. Outer loop is just for final check.
        {
          if (A[j] > A[j + 1])
          {
            temp = A[j];
            A[j] = A[j + 1];
            A[j + 1] = temp;
            swapped = true;
          }
        }

        // If no two elements are swapped by inner loop, then break. It is already sorted.
        if (swapped == false)
        {
          break;
        }
      }
    }
    private static void BubbleSort_Recursive()
    {
      int temp;
      for (int i = 0; i < A.Length - 1; i++)
      {
        if (A[i] > A[i + 1])
        {
          temp = A[i];
          A[i] = A[i + 1];
          A[i + 1] = temp;
          BubbleSort_Recursive();
        }
      }
    }
    public static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      //BubbleSort_Recursive();
      BubbleSort_Iterative();
      Console.WriteLine($"Elements in Sorted Order: ");
      Console.WriteLine(String.Join(" ", A));
      Console.ReadLine();
    }
  }
}
