using System;


namespace MergeSort
{
  class Program
  {
    //private static int[] A;

    /// <summary>
    /// Merges the sub-array's by comparing the Elements in them
    /// </summary>
    /// <param name="leftIndex"></param>
    /// <param name="midIndex"></param>
    /// <param name="rightIndex"></param>
    private static void Merge(int[] A, int leftIndex, int midIndex, int rightIndex)
    {
      // Find sizes of two subarrays to be merged 
      int n1 = (midIndex - leftIndex) + 1;
      int n2 = rightIndex - midIndex;

      // Create temp arrays  
      int[] L = new int[n1];
      int[] R = new int[n2];

      // Copy data to temp arrays 
      int i, j;

      for (i = 0; i < n1; ++i)
      {
        L[i] = A[leftIndex + i];
      }

      for (j = 0; j < n2; ++j)
      {
        R[j] = A[(midIndex + 1) + j];
      }

      // Initial indexes of first and second subarrays 
      i = 0; j = 0;

      // Initial index of merged subarry array 
      int k = leftIndex;

      while (i < n1 && j < n2)
      {
        if (L[i] <= R[j])
        {
          A[k] = L[i];
          i++;
        }
        else
        {
          A[k] = R[j];
          j++;
        }
        k++;
      }

      // Copy remaining elements of L[] if any  
      while (i < n1)
      {
        A[k] = L[i];
        i++;
        k++;
      }

      // Copy remaining elements of R[] if any  
      while (j < n2)
      {
        A[k] = R[j];
        j++;
        k++;
      }
    }

    /// <summary>
    /// Divides the Main Array into sub-array's and finally calls for Merge.
    /// Works on Divide and Conquer Approach
    /// </summary>
    /// <param name="leftIndex"></param>
    /// <param name="rightIndex"></param>
    private static void Sort_Recursive(int[] A, int leftIndex, int rightIndex)
    {
      if (rightIndex > leftIndex)
      {
        int midIndex = (leftIndex + rightIndex) / 2; // Finding the mid-index

        // Divide and sort first sub-array
        Sort_Recursive(A, leftIndex, midIndex);

        // Divide and sort second sub-array
        Sort_Recursive(A, midIndex + 1, rightIndex); 

        Merge(A, leftIndex, midIndex, rightIndex); // Calling Merge Method to Join final two sub Arrays.
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      Sort_Recursive(A, 0, A.Length - 1);
      Console.WriteLine($"Elements in Sorted Order: ");
      Console.WriteLine(String.Join(" ", A));
      Console.ReadLine();
    }
  }
}
