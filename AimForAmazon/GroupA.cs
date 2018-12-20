﻿using System;
using System.Collections.Generic;

namespace AimForAmazon
{
	public class GroupA
	{
		public GroupA()
		{
			var arr1 = new int[] { 6, 3, 14, 5, 1, 1, 2, 4 };
			var arr2 = new int[] { 4, 14, 3, 14, 14, 14, 5, 5, 1, 2 };
			var arr3 = new int[] { 14, 1, 3, 14, 4, 5, 2, 14 };
			//Question1(arr1);
			//Question1UsingStatics(arr1);
			//Question2(arr1);
			//Question3(arr1);
			//Question4(arr1);
			//Question5(arr1);
			Question6(arr1);
			Question6(arr2);
			Question6(arr3);
		}
		#region Quesiton1
		// 1. How do you find the missing number in a given integer array of 1 to 100? (solution)
		void Question1(int[] arr)
		{
			Console.WriteLine("Hello World!");
			var h = new HelperFunctions();
			h.ArrayPrinter(arr);
			h.ArrayAscendingSorter(arr);
			// Since arrays are passed by value, 
			// the array doesn't need to be passed around
			h.ArrayPrinter(arr);
			h.FindMissingNumberFromSortedArray(arr);
		}

		void Question1UsingStatics(int[] arr)
		{
			Console.WriteLine("Hello World!");
			StaticHelperFunctions.ArrayPrinter(arr);
			StaticHelperFunctions.ArrayAscendingSorter(arr);
			StaticHelperFunctions.ArrayPrinter(arr);
			StaticHelperFunctions.FindMissingNumberFromSortedArray(arr);
		}
		#endregion Quesiton1

		#region Quesiton2
		// 2. How do you find the duplicate number on a given integer array? (solution)
		void Question2(int[] arr)
		{
			var h = new HelperFunctions();
			h.ArrayPrinter(arr); 
			h.ArrayAscendingSorter(arr);
			h.ArrayPrinter(arr);
			h.DuplicateFinder(arr);
		}
		#endregion Quesiton2

		#region Quesiton3
		// 3. How do you find the largest and smallest number in an unsorted integer array? (solution)
		void Question3(int[] arr)
		{
			var h = new HelperFunctions();
			h.ArrayPrinter(arr);
			h.LargestNumberPrinter(arr);
			h.SmallestNumberPrinter(arr);
		}
		#endregion Quesiton3

		#region Quesiton4
		// 4. How do you find all pairs of an integer array whose sum is equal to a given number? (solution)
		void Question4(int[] arr)
		{
			var givenNumber = 5;
			var h = new HelperFunctions();
			h.ArrayPrinter(arr);
			h.SumEqualsGivenNumberPairFinder(givenNumber, arr);
		}
		#endregion Quesiton4

		#region Quesiton5
		// 5. How do you find duplicate numbers in an array if it contains multiple duplicates? (solution)
		void Question5(int[] arr)
		{
			var h = new HelperFunctions();
			h.ArrayPrinter(arr);
			h.ArrayAscendingSorter(arr);
			h.DuplicateDetailsFinder(arr);
		}
		#endregion Quesiton5

		#region Quesiton6
		// 6. How are duplicates removed from a given array? (solution)
		void Question6(int[] arr)
		{
			var h = new HelperFunctions();
			h.ArrayPrinter(arr);
			h.DuplicateRemover(arr);
		}
		#endregion Quesiton6
	}
}
