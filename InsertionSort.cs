using System;
namespace InsertionSort
{
  class Program
  {
    private static int[] A;
    private static void InsertionSort_Recursive(int i)
    {
      int n = A.Length;
      int currentElement = A[i];
      int j = i - 1; // j points to previous index of i

      // Moving elements of A[0...N-1], that are greater than current element,
      // to one step backward of their current position
      while (j >= 0 && A[j] > currentElement)
      {
        A[j + 1] = A[j];
        j--;
      }

      A[j + 1] = currentElement; // Inserting the current element to Begining of Array

      i++;
      if (i < n)
      {
        InsertionSort_Recursive(i);
      }
      
    }

    private static void InsertionSort_Iterative()
    {
      int n = A.Length;
      for (int i = 1; i < n; i++)
      {
        int currentElement = A[i];
        int j = i - 1; // j points to previous index of i

        // Moving elements of A[0...N-1], that are greater than current element,
        // to one step backward of their current position
        while (j >= 0 && A[j] > currentElement)
        {
          A[j + 1] = A[j];
          j--;
        }

        A[j + 1] = currentElement; // Inserting the current element to Begining of Array
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      //InsertionSort_Iterative();
      InsertionSort_Recursive(1);
      Console.WriteLine($"Elements in Sorted Order: ");
      Console.WriteLine(String.Join(" ", A));
      Console.ReadLine();
    }
  }
}
