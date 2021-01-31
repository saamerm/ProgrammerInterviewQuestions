using System;
namespace AmazonQuestions
{
    public class Question2
    {
        public Question2()
        {
            System.Console.WriteLine("Question 2!");

            // Test Cases:
            // string s = "abcabcbb";
            // string s = "pwwkew";
            // string s = "pw";
            // string s = "abcde";
            // string s = "aafgh";
            // string s = "asqff";
            // string s = "asdffgh";
            // string s = "abcdea";
            // string s = "asdfaqwertyui";
            // string s = "";
            
            // string s = "bbbbbb";
            string s = " ";
            System.Console.WriteLine(LengthOfLongestSubstring(s));
        }

        public int LengthOfLongestSubstring(string s) 
        {
            if (s.Length == 0) return 0;
            int maxCounter = 1;
            int counter = 1;
            var shouldAddCounterValue = false;
            for (int i = 0; i < s.Length - 1; i++)
            {
                shouldAddCounterValue = true;
                for (int j = i; j < s.Length; j++)                
                {
                    counter = 1;
                    // Check if all conditions are satisfied with the preceding letters
                    for (int k = i; k < j; k++)
                    {
                        var x = s[k];
                        var y = s[j];
                        if (s[k] != s[j])
                        {
                            counter++;
                        }
                        else
                        {
                            shouldAddCounterValue = false;
                            break;
                        }
                    }
                    if (shouldAddCounterValue)                    
                        maxCounter = maxCounter > counter ? maxCounter : counter;
                    else
                        break;
                }                
            }
            return maxCounter;
        }

        #region Unsuccessful Trials
        public int LengthOfLongestSubstring5(string s) 
        {
            int maxCounter = 1;
            int counter = 1;
            var shouldAddCounterValue = false;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)                
                {
                    // Check if all conditions are satisfied with the preceding letters
                    for (int k = i; k < j; k++)
                    {
                        var x = s[k];
                        var y = s[j];
                        if (s[k] != s[j])
                        {
                            counter++;
                        }
                        else
                        {
                            shouldAddCounterValue = false;
                            break;
                        }
                    }
                    maxCounter = shouldAddCounterValue && maxCounter > counter ? maxCounter : counter;
                    counter = 1;
                    shouldAddCounterValue = true;
                }
            }
            return maxCounter;
        }

        public int LengthOfLongestSubstring1(string s) {
            int maxCounter = 1;
            int counter = 1;
            for (int i = 1; i < s.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (s[i] != s[j])
                    {
                        ++counter;
                    }
                    else
                    {
                        break;
                    }
                }
                maxCounter = maxCounter > counter ? maxCounter : counter;
                counter = 1;
            }
            return maxCounter;
        }

        public int LengthOfLongestSubstring4(string s) 
        {
            int maxCounter = 1;
            int counter = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)                
                {
                        var x = s[j];
                        var y = s[j-1];
                        if (s[j] != s[j-1])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    maxCounter = maxCounter > counter ? maxCounter : counter;
                    counter = 1;
                }
            }
            return maxCounter;
        }
        #endregion
    }
}

/*
  
  Longest Substring Without Repeating Characters

Given a string s, find the length of the longest substring without repeating characters.

Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

Example 4:
Input: s = ""
Output: 0 

Assumptions

* Only alphabets?
* Empty string?
* Repeating non consecutively is allowed?
* Maximum possible is 26?
* Do alphabets count as separate characters?
* So we can only worry about small letters for now?

Test Cases

"abcde" - No repeats
"aafgh" - Repeats at start
"asqff" - Repeats at end
"asdffgh" - Repeats in the middle
"abcdea" - Only one repeat
"asdfaqwertyui" - Only one repeat

Methodology

Create a nested loop
Take the first string character/index and compare with the next
If its not the same, add to a counter, and hop to the next
else just store that counter value and go to the next index

Create a nested loop
Loop through all the character and compare the character with all the preceding characters
*/
