using System;
using System.Collections.Generic;

namespace AimForAmazon
{
	public class GroupE
	{
		public GroupE()
		{
			//Question8();
			Question9();
		}

		// 8. How do you swap two numbers without using the third variable? (solution)
		private void Question8()
		{
			var x = 5;
			var y = 3;
			Console.WriteLine("x={0}, y={1}", x, y);
			x = x + y;
			y = x - y; //(x+y-y)
			x = x - y; //(x+y-x-y+y)
			Console.WriteLine("x={0}, y={1}", x, y);
		}

		// 9. How do you check if two rectangles overlap with each other? (solution)
		private void Question9()
		{
			var h = new HelperFunctions();
			Console.WriteLine("Shouldnt intersect");
			var rectangleOneCoordinates = h.GetRectangleCoordinates(-2, -2, 2, 2);
			var rectangleTwoCoordinates = h.GetRectangleCoordinates(3, 3, 6, 6);
			h.IntersectionChecker(rectangleOneCoordinates, rectangleTwoCoordinates);
			// Test code
			//Console.WriteLine("Should intersect");
			//rectangleOneCoordinates = h.GetRectangleCoordinates(-1, -1, -2, -2);
			//rectangleTwoCoordinates = h.GetRectangleCoordinates(-3, -3, 6, 6);
			//h.IntersectionChecker(rectangleOneCoordinates, rectangleTwoCoordinates);

			//Console.WriteLine("Shouldnt intersect");
			//rectangleOneCoordinates = h.GetRectangleCoordinates(1, 1, 2, 2);
			//rectangleTwoCoordinates = h.GetRectangleCoordinates(3, 3, 6, 6);
			//h.IntersectionChecker(rectangleOneCoordinates, rectangleTwoCoordinates);

			//Console.WriteLine("Should intersect");
			//rectangleOneCoordinates = h.GetRectangleCoordinates(2, 2, -2, -2);
			//rectangleTwoCoordinates = h.GetRectangleCoordinates(1, 1, 0, 0);
			//h.IntersectionChecker(rectangleOneCoordinates, rectangleTwoCoordinates);
		}
	}
}
