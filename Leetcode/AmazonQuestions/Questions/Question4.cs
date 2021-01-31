using System;
namespace AmazonQuestions
{
    public class Question4
    {
        public Question4()
        {
            System.Console.WriteLine("Question 4");
            //Test Cases
            //
            // var heights = new int[]{1,1};
            // var heights = new int[]{1,8,6,2,5,4,8,3,7};
            var heights = new int[]{1,8,6,2,9,4,8,3,7};
            System.Console.WriteLine("Max area is " + MaxArea(heights));
        }
        public int MaxArea(int[] height) {
            var maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    var area = Math.Min(height[i], height[j]) * (j - i);
                    maxArea = Math.Max(maxArea, area);
                }
            }
            return maxArea;
        }        
        public int MaxAreaUnsuccessfulAttempt2(int[] height) {
            var maxArea = 0;
            var heightOfBlockingVertical = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    if (heightOfBlockingVertical < height[j])
                    {
                        var area = Math.Min(height[i], height[j]) * (j - i);
                        maxArea = Math.Max(maxArea, area);
                    }
                    heightOfBlockingVertical = Math.Max(heightOfBlockingVertical, height[j]);
                }
                heightOfBlockingVertical = 0;
            }
            return maxArea;
        }  
    }
}
/*
  Container With Most Water

Solution
Given n non-negative integers a1, a2, ..., an , where each represents a point at 
coordinate (i, ai). n vertical lines are drawn such that the two endpoints of the 
line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis 
forms a container, such that the container contains the most water.

Notice that you may not slant the container.

Questions
Tallest height? 
Max Number of bars?
(To get max area to decide what data structure to use)
1 unit distance between each?

Test Cases
0, 1, 0, 0
1, 0
0, 4, 0, 6
5, 0, 5, 0, 0, 8

Methodology
Using brute force
Nested loop
Loop through each vertical and get the 
- height of the blocking vertical
- max area for each combination as long as its not being blocked by a vertical
Print out the max vertical
*/