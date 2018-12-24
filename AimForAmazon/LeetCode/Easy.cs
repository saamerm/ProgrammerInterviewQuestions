﻿using System;
namespace AimForAmazon.LeetCode
{
	public class Easy
	{
		public Easy()
		{
			var arr1 = new int[] { 2, 7, 11, 15 };
			var arr2 = new int[] { 3, 2, 4 };
			Question1(arr2);
		}

		// Called TwoSum
		private void Question1(int[] arr)
		{
			var h = new HelperFunctions();
			var target = 6;
			var arr2 = TwoSum_TimeComplex(arr, target);
			h.ArrayPrinter(arr2);
		}
		// Only faster than 16% of submissions
		private int[] TwoSum_TimeComplex(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = 0; j < nums.Length; j++)
				{
					if (i != j)
					{
						if (nums[i] + nums[j] == target)
						{
							return new int[2] { i, j };
						}
					}
				}
			}
			return new int[0];
		}
	}
}
