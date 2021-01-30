using System;

namespace AmazonQuestions
{
    public class Question1
    {
        public Question1()
        {
            System.Console.WriteLine("Hello");
            // int[] nums = {2,7,11,15}; var target = 9;
            // int[] nums = {3,2,4}; var target = 6;
            // int[] nums = {3,2,4}; var target = 6;
            int[] nums = {0,-1,-1,3}; var target = -2;
            // int[] nums = {-1,-1}; var target = -2;
            // int[] nums = {3,3}; var target = 6;

            int[] x = TwoSum(nums, target);
            System.Console.WriteLine("{"+x[0]+","+x[1]+"}");
            System.Console.WriteLine("If output is {0,0}, that means there's no solution");
        }
        public int[] TwoSum(int[] nums, int target) {
            for(int i =0; i<nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[]{i,j};
                    }
                }
            }
            return new int[2];
        }
    }
}
/*
Given an array of integers nums and an integer target, return indices 
of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you 
may not use the same element twice.
You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:
2 <= nums.length <= 103
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.

What are the constraints, whats the largest size of the array?
Whats the smallest number?
Whats the largest number?
Can there be more than one solution?
Can there be duplicates?
What are some examples?
Sum of only two numbers?

{-1,0,1,2} & 3 -> {2,3}
{-1,1} & 0 -> {1,2}
{-1,-1,3} & -2 -> {0,1}

Approach

Nested Loop-Loop with the first array object, and compare the sum with the other objects
Then go to the next objext
But if the sum matches, Return the indices of the two numbers

Optomized approach

Sort using a Quick Sort, and then do the comparison.
We wouldnt need a nested loop
Ignore any numbers when sum of the smallest number and that number is greater than target
*/