using System;
using System.Collections.Generic;

namespace AimForAmazon
{
	public class GroupC
	{
		public GroupC()
		{
			string string1 = "asd asfwr";
			Question1(string1);
		}

		// 1. How do you print duplicate characters from a string? (solution)
		public void Question1(string input)
		{
			var h = new HelperFunctions();
			var hash = new HashSet<char>();
			var duplicateList = new List<char>();
			for (var i = 0; i < input.Length; i++)
			{
				if (hash.Contains(input[i]))
					duplicateList.Add(input[i]);
				else
					hash.Add(input[i]);
			}
			if (duplicateList.Count != 0)
			{
				Console.WriteLine("The following letters are duplicates: ");
				h.FancyStringPrinter(duplicateList);
			}
			else
				Console.WriteLine("No duplicates found");
		}
	}
}
