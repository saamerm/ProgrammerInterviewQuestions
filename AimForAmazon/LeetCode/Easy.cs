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
			Question2(arr2);
		}

		#region Question1
		// https://leetcode.com/problems/two-sum/
		// Called TwoSum
		private void Question1(int[] arr)
		{
			var h = new HelperFunctions();
			var target = 6;
			var arr2 = TwoSum_TimeComplex(arr, target);
			h.ArrayPrinter(arr2);
		}
		// Only faster than 16% of submissions
		// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
		// You may assume that each input would have exactly one solution, and you may not use the same element twice.
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
		//Try to do better
		private int[] TwoSum_TimeBetter(int[] nums, int target)
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
		#endregion Question1
		#region Question2
		// Called AddTwoNumbers
		// https://leetcode.com/problems/add-two-numbers/
		private void Question2(int[] arr)
		{
			var h = new HelperFunctions();
			var target = 6;
			var arr2 = TwoSum_TimeComplex(arr, target);
			h.ArrayPrinter(arr2);
		}
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}
		//You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.
		//You may assume the two numbers do not contain any leading zero, except the number 0 itself.
		//Example:
		//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
		//Output: 7 -> 0 -> 8
		//Explanation: 342 + 465 = 807.
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			return l1;
		}
		#endregion Question2
	}
}
