using System;
namespace AmazonQuestions
{
    public class Question3
    {
        public Question3()
        {
            System.Console.WriteLine("Question 3");
            // PreQuestionTestCode();
            
            // Test Cases
            // var s = "123";
            // var s = " 123";
            // var s = "-123";
            // var s = "+ 12a3";
            // var s = "a123";
            // var s = "21474836460";
            var s = "words and 987";
            // var s = "";
            System.Console.WriteLine(MyAtoi(s));
        }

        public int MyAtoi(string s) {
            int multiplier = 1;
            double number = 0;
            bool startedRecording = false;
            for (int i = 0; i < s.Length; i ++)
            {
                var num = char.GetNumericValue(s[i]); // -1 for any non number
                if ((s[i] == ' ' || num == '0') && !startedRecording){}
                else if (s[i] == '+' && !startedRecording){startedRecording=true;}
                else if (s[i] == '-' && !startedRecording){multiplier = -1; startedRecording=true;}
                else if (num > -1){number = 10*number + num; startedRecording = true;}
                else break;            
            }
            var solution = (int)number * multiplier;
            if (solution < 0 && multiplier == 1){solution = (int)(Math.Pow(2,31) - 1);}
            else if (solution > 0 && multiplier == -1){solution = (int)(-Math.Pow(2,31));}
            return solution;
        }        

        private void PreQuestionTestCode()
        {
            string s = "+234";
            var x = s[0];
            var comparison = 5;
            var num = char.GetNumericValue(x); // ' ', 'a' = -1, 
            System.Console.WriteLine(num);
            if (num < comparison)
                System.Console.WriteLine(x + " is smaller than " + comparison);
            else
                System.Console.WriteLine(x + " is bigger or equal to " + comparison);
        }
    }
}
/*
Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

The algorithm for myAtoi(string s) is as follows:

Read in and ignore any leading whitespace.
Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
Read in next the characters until the next non-digit charcter or the end of the input is reached. The rest of the string is ignored.
Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
Return the integer as the final result.
Note:

Only the space character ' ' is considered a whitespace character.
Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.

Test Cases
var s = "0123";
var s = "01 23";
var s = "01+23";
var s = " 0123";
var s = "-123";
var s = "+ 12a3";
var s = "a123";
var s = "";

Methodology
Loop through the entire thing
If there's a number, start recording, for every other number, multiply by 10 and then add the new one
if that is proceeded by non number, stop recording
Remove all proceeding zeroes and spaces
If there's a plus/minus, record it as a multiplier
If there's any other character, stop

Questions:
Whats happens if there's more than 1 "+"?
Whats happens if there's more than 1 "-"?
*/

