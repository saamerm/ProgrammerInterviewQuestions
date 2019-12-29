using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class Algorithms
    {
        public Algorithms()
        {
        }

        public void Problem1()
        {
            var arr = Create2DArray();
            var y = diagonalDifference(arr);
            Console.WriteLine(y);
        }

        // Solution requires this function, so kept the definition the same
        public static int diagonalDifference(List<List<int>> arr)
        {
            int primarySum = 0;
            int primarySumCounter = 0;
            int secondarySum = 0;
            int secondarySumCounter = arr.Count-1;

            foreach (var list in arr)
            {
                primarySum += list[primarySumCounter];
                secondarySum += list[secondarySumCounter];
                primarySumCounter++;
                secondarySumCounter--;
            }
            int sum = primarySum - secondarySum;
            if (sum < 0)
                sum *= -1;
            return sum;
        }

        private List<List<int>> Create2DArray()
        {
            var x = new List<List<int>>();
            var arr1 = new int[3] { 1, 3, 4 };
            var arr2 = new int[3] { 1, 5, 5 };
            var arr3 = new int[3] { 3, 3, 8 };
            x.Add(new List<int>(arr1));
            x.Add(new List<int>(arr2));
            x.Add(new List<int>(arr3));
            return x;
        }
    }
}
