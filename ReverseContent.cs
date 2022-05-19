
// C# program to reverse every sub-array
// formed by consecutive k elements
using System;
namespace ReverseContent
{
	class Solution
	{

		// Function to reverse every sub-array
		// formed by consecutive k elements
		public static void reverse(int[] arr,
								int n, int k)
		{
			for (int i = 0; i < n; i += k)
			{
				int left = i;

				// to handle case when k is
				// not multiple of n
				int right = Math.Min(i + k - 1, n - 1);
				int temp;

				// reverse the sub-array [left, right]
				while (left < right)
				{
					temp = arr[left];
					arr[left] = arr[right];
					arr[right] = temp;
					left += 1;
					right -= 1;
				}
			}
		}

		// Driver Code
		public static void Main(string[] args)
		{
			int[] numbers = new int[] {1, 2, 3, 4,
						   5, 6, 7, 8};
			int k = 3;

			int n = numbers.Length;

			reverse(numbers, n, k);

			for (int i = 0; i < n; i++)
			{
				Console.Write(numbers[i] + " ");
			}
		}
		
	}
}





