using System;
using System.Collections.Generic;

namespace AimForAmazon
{
	public class GroupA
	{
		public GroupA()
		{
			Question1();
			Question1UsingStatics();
		}
		#region Quesiton1
		// 1. How do you find the missing number in a given integer array of 1 to 100? (solution)
		void Question1()
		{
			var x = new int[] { 6, 3, 14, 5, 1 };
			Console.WriteLine("Hello World!");
			var h = new HelperFunctions();
			h.ArrayPrinter(x);
			h.ArrayAscendingSorter(x);
			// Since arrays are passed by value, 
			// the array doesn't need to be passed around
			h.ArrayPrinter(x);
			h.FindMissingNumberFromSortedArray(x);
		}

		void Question1UsingStatics()
		{
			var x = new int[] { 6, 3, 14, 5, 1 };
			Console.WriteLine("Hello World!");
			StaticHelperFunctions.ArrayPrinter(x);
			StaticHelperFunctions.ArrayAscendingSorter(x);
			StaticHelperFunctions.ArrayPrinter(x);
			StaticHelperFunctions.FindMissingNumberFromSortedArray(x);
		}
		#endregion Quesiton1

		#region Quesiton2
		// 2. How do you find the duplicate number on a given integer array? (solution)
		void Question2()
		{
			var x = new int[] { 6, 3, 14, 5, 1 };
		}
		#endregion Quesiton2
	}
}
