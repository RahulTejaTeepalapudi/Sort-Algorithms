using System;

// Time Complexity: O(n square)
namespace SelectionSort
{
  class Program
  {
    private static int[] A;
    private static void SelectionSort_Iterative()
    {
      int n = A.Length;
      int temp;
      int min_index;
      for (int i = 0; i < n; i++)
      {
        min_index = i;
        for (int j = i + 1; j < n; j++)
        {
          // Checking for Minimun Element
          if (A[j] < A[min_index])
          {
            min_index = j;
          }
        }

        // Insert the minimun element to the required Index
        temp = A[i];
        A[i] = A[min_index];
        A[min_index] = temp;
      }
    }

    private static void SelectionSort_Recursive(int index)
    {
      int n = A.Length;
      int temp;
      int min_index = index;

      for (int j = index + 1; j < n; j++)
      {
        // Checking for Minimun Element
        if (A[j] < A[min_index])
        {
          min_index = j;
        }
      }

      // Swaping the Elements.
      temp = A[index];
      A[index] = A[min_index];
      A[min_index] = temp;
      index++;

      if (index < n)
      {
        SelectionSort_Recursive(index); // Calling the Same Method Recursively, checking index.
      }

    }
    static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      //SelectionSort_Iterative();
      SelectionSort_Recursive(0);
      Console.WriteLine($"Elements in Sorted Order: ");
      Console.WriteLine(String.Join(" ", A));
      Console.ReadLine();
    }
  }
}
