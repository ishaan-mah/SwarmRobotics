using Regions;
using System;

namespace Regions
{
	public class shift
	{
		public static double shift_x(double x, double y)
		{
			double x_translate = 10.0;
			double rot_angle = Math.PI / 6.0;
			return ((x + x_translate) * Math.Cos(rot_angle) - y * Math.Sin(rot_angle));
		}

		public static double shift_y(double x, double y)
		{
			double y_translate = 15.0;
			double rot_angle = Math.PI / 6.0;
			return (x * Math.Sin(rot_angle) + (y + y_translate) * Math.Cos(rot_angle));
		}
	}
	public class Triangle
	{
		static double area(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
		}

		/* A function to check whether point P(x, y) lies
		inside the triangle formed by A(x1, y1),
		B(x2, y2) and C(x3, y3) */
		static bool isInside(double x1, double y1, double x2, double y2, double x3, double y3, double x, double y)
		{
			/* Calculate area of triangle ABC */
			double A = area(x1, y1, x2, y2, x3, y3);

			/* Calculate area of triangle PBC */
			double A1 = area(x, y, x2, y2, x3, y3);

			/* Calculate area of triangle PAC */
			double A2 = area(x1, y1, x, y, x3, y3);

			/* Calculate area of triangle PAB */
			double A3 = area(x1, y1, x2, y2, x, y);

			/* Check if sum of A1, A2 and A3 is same as A */
			return (A == A1 + A2 + A3);
		}

		/* Driver program to test above function */
		public static int IsTriangle()
		{
			/* Let us check whether the point P(10, 15) lies inside the triangle formed byA(0, 0), B(20, 0) and C(10, 30) */
			double x1 = shift.shift_x(0.0, 0.0);
			double y1 = shift.shift_y(0.0, 0.0);
			double x2 = shift.shift_x(20.0, 0.0);
			double y2 = shift.shift_y(20.0, 0.0);
			double x3 = shift.shift_x(10.0, 30.0);
			double y3 = shift.shift_y(10.0, 30.0);
			if (isInside(x1, y1, x2, y2, x3, y3, 3.0, 15.0))
				Console.WriteLine("Inside");
			else
				Console.WriteLine("Not Inside");
			return 0;
		}
	}

	class square
	{

		static bool FindPoint(double x4, double x2, double y1, double y3, double x, double y)
		{
			if (x >= x4 && x <= x2 && y >= y1 && y <= y3)
				return true;
			return false;
		}

		public static int IsSquare()
		{

			double x1 = shift.shift_x(0.0, 0.0);
			double y1 = shift.shift_y(0.0, 0.0);
			double x2 = shift.shift_x(30.0, 0.0);
			double y2 = shift.shift_y(30.0, 0.0);
			double x3 = shift.shift_x(30.0, 30.0);
			double y3 = shift.shift_y(30.0, 30.0);
			double x4 = shift.shift_x(0.0, 30.0);
			double y4 = shift.shift_y(0.0, 30.0);

			double x = 15.0, y = 23.0;

			if (FindPoint(x4, x2, y1, y3, x, y))
				Console.Write("Yes");
			else
				Console.Write("No");
			return 0;
		}
	}
	class rectangle
	{
		static bool FindPoint(double x4, double x2, double y1, double y3, double x, double y)
		{
			if (x >= x4 && x <= x2 && y >= y1 && y <= y3)
				return true;
			return false;
		}
					
		public static int IsRectangle()
		{
				
			double x1 = shift.shift_x(0.0, 0.0);
			double y1 = shift.shift_y(0.0, 0.0);
			double x2 = shift.shift_x(15.0, 0.0);
			double y2 = shift.shift_y(15.0, 0.0);
			double x3 = shift.shift_x(15.0, 16.0);
			double y3 = shift.shift_y(15.0, 16.0);
			double x4 = shift.shift_x(0.0, 16.0);
			double y4 = shift.shift_y(0.0, 16.0);

			double x = 15.0, y = 23.0;

			if (FindPoint(x4, x2, y1, y3, x, y))
				Console.Write("Yes");
			else					
				Console.Write("No");
			return 0;
		}
	}
	class circle
	{

		static bool isInside(double circle_x, double circle_y, double rad, double x, double y)
		{
			if (((x - circle_x) * (x - circle_x) + (y - circle_y) * (y - circle_y)) <= (rad * rad))
				return true;
			else
				return false;
		}

		public static int IsCircle()
		{
			double x = 5.0, y = 10.0;
			double circle_x = shift.shift_x(3.0, 3.0);
			double circle_y = shift.shift_y(3.0, 3.0);
			double rad = 10.0;

			if (isInside(circle_x, circle_y, rad, x, y))
				Console.Write("Inside");
			else
				Console.Write("Outside");
			return 0;
		}
	}

	class annular_circle
	{

		static bool isInside(double circle_x, double circle_y, double rad1, double rad2, double x, double y)
		{
			if ((((x - circle_x) * (x - circle_x) + (y - circle_y) * (y - circle_y)) >= (rad1 * rad1)) && (((x - circle_x) * (x - circle_x) + (y - circle_y) * (y - circle_y)) <= (rad2 * rad2)))
				return true;
			else
				return false;
		}

		public static int IsAnnularCircle()
		{
			double x = 5.0, y = 10.0;
			double circle_x = shift.shift_x(3.0, 3.0);
			double circle_y = shift.shift_y(3.0, 3.0);
			double rad1 = 10.0, rad2 = 20.0;

			if (isInside(circle_x, circle_y, rad1, rad2, x, y))
				Console.Write("Inside");
			else
				Console.Write("Outside");
			return 0;
		}
	}
	class circle_compliment
	{

		static bool isInside(double circle_x, double circle_y, double rad, double x, double y)
		{
			if (((x - circle_x) * (x - circle_x) + (y - circle_y) * (y - circle_y)) <= (rad * rad))
				return true;
			else
				return false;
		}

		public static int CircleCompliment()
		{
			double x = 5.0, y = 10.0;
			double circle_x = shift.shift_x(3.0, 3.0);
			double circle_y = shift.shift_y(3.0, 3.0);
			double rad = 10.0;

			if (isInside(circle_x, circle_y, rad, x, y))
				Console.Write("Inside");
			else
				Console.Write("Outside");
			return 0;
		}
	}
}

