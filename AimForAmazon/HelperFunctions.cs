using System;
using System.Collections.Generic;

namespace AimForAmazon
{

	public class HelperFunctions
	{
		public HelperFunctions()
		{
		}

		public void FindMissingNumberFromSortedArray(int[] arr)
		{
			var missingNumbersCount = 0;
			var list = new List<int>();

			// Tells us only if the next number is missing
			//for (var i = 0; i < arr.Length -1; i ++)
			//{
			//	if (arr[i + 1] - arr[i] != 1)
			//	{
			//		list.Add(arr[i] + 1);
			//		missingNumbersCount++;
			//	}
			//}

	    		// Investigation
			for (var i = 0; i < arr.Length - 1; i++)
			{
				var x = arr[i + 1] - arr[i];
				var y = arr[i];
				// If the difference is greater than one,
				// then loop on the numbers
				while (x > 1)
				{
					// y++ adds the wrong number to the list
					// we want to add the next number to the list (y+1) 
					list.Add(++y);
					missingNumbersCount++;
					x--;
				}
			}
	    		
	    		// Conclusion
			if (missingNumbersCount > 0)
			{
				Console.WriteLine(missingNumbersCount + " Missing Number(s):");
				foreach (var item in list)
					Console.Write(item + " ");
			}
			else
				Console.WriteLine("No missing numbers found");
		}

		public void ArrayAscendingSorter(int[] arr)
		{
			for (var j = 0; j < arr.Length - 1; j++)
			{
				// Get the largest value to the end
				for (var i = 0; i < arr.Length - 1 - j; i++)
				{
					if (arr[i + 1] < arr[i])
					{
						// Swap values
						int y = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = y;
					}

				}
			}
		}

		public void ArrayPrinter(int[] arr)
		{
			Console.Write("{ ");
			for (var i = 0; i < arr.Length; i++)
				Console.Write(arr[i] + " ");
			Console.WriteLine("}");
		}

		public void DuplicateFinder(int[] arr)
		{
			var duplicatesCount = 0;
			var list = new List<int>();

			// Investigation
			for (var i = 0; i < arr.Length - 1; i++)
			{
				if (arr[i] == arr[i + 1])
				{
					duplicatesCount++;
					// Remove this line, if you dont want to show unique duplicates
					if (!list.Contains(arr[i]))
						list.Add(arr[i]);
				}
			}

			// Conclusion
			if (duplicatesCount > 0)
			{
				Console.Write("There were " + duplicatesCount + " duplicates:");
				foreach (var item in list)
					Console.Write(" " + item);
			}
		}

		public void LargestNumberPrinter(int[] arr)
		{
			// Pushes the highest number to the end
			for (int i = 0; i < arr.Length - 1; i++)
			{
				if (arr[i] > arr[i + 1])
				{
					int y = arr[i + 1];
					arr[i + 1] = arr[i];
					arr[i] = y;
				}
			}
			Console.WriteLine("The largest number is " + arr[arr.Length - 1]);
		}

		public void SmallestNumberPrinter(int[] arr)
		{
			var smallest = arr[0];
			// Compare all the values with the first one
			for (int i = 1; i < arr.Length; i++)
			{
				if (smallest > arr[i])
					smallest = arr[i];
			}
			Console.WriteLine("The smallest number is " + smallest);

		}
	}
}
