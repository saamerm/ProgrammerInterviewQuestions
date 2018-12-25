using System;
using System.Collections;
using System.Collections.Generic;

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
		public int[] twoSum(int[] nums, int target)
		{
			var map = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				int complement = target - nums[i];
				//if (map.ContainsKey(complement))
				//{
				//	return new int[] { map.get(complement), i };
				//}
				//map.put(nums[i], i);
			}
			throw new Exception("No two sum solution");
		}
	}
}
