using System;
using System.Collections.Generic;

namespace AimForAmazon
{
	public static class StaticHelperFunctions
	{
		public static void FindMissingNumberFromSortedArray(int[] arr)
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

			for (var i = 0; i < arr.Length - 1; i++)
			{
				var x = arr[i + 1] - arr[i];
				var y = arr[i];
				while (x != 1)
				{
					// y++ adds the wrong number to the list
					// we want to add the next number to the list (y+1) 
					list.Add(++y);
					missingNumbersCount++;
					x--;
				}
			}

			if (missingNumbersCount > 0)
			{
				Console.WriteLine(missingNumbersCount + " Missing Number(s):");
				foreach (var item in list)
					Console.Write(item + " ");
			}
			else
				Console.WriteLine("No missing numbers found");
		}

		public static void ArrayAscendingSorter(int[] arr)
		{
			int y;
			for (var j = 0; j < arr.Length - 1; j++)
			{
				// Get the largest value to the end
				for (var i = 0; i < arr.Length - 1 - j; i++)
				{
					if (arr[i + 1] < arr[i])
					{
						y = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = y;
					}

				}
			}
		}
		public static void ArrayPrinter(int[] arr)
		{
			Console.Write("{ ");
			for (var i = 0; i < arr.Length; i++)
				Console.Write(arr[i] + " ");
			Console.WriteLine("}");
		}
	}
}
