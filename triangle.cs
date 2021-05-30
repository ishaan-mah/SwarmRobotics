// C# Code to Check whether a given point
// lies inside a triangle or not
using System;

class triangle
{

	/* A utility function to calculate area of triangle
	formed by (x1, y1) (x2, y2) and (x3, y3) */
	static double area(double x1, double y1, double x2, double y2, double x3, double y3)
	{
		return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
	}

	static double shift_x(double x, double y)
	{
		double x_translate = 10.0;
		double rot_angle = Math.PI / 3.0;
		return ((x + x_translate) * Math.Cos(rot_angle) + y * Math.Sin(rot_angle));
	}

	static double shift_y(double x, double y)
	{
		double y_translate = 15.0;
		double rot_angle = Math.PI / 3.0;
		return (-(x * Math.Sin(rot_angle)) + (y + y_translate) * Math.Cos(rot_angle));
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
	public static void Main()
	{
		/* Let us check whether the point P(10, 15)
		lies inside the triangle formed by
		A(0, 0), B(20, 0) and C(10, 30) */
		//double x1 = 0.0, y1 = 0.0, x2 = 20.0, y2 = 0.0, x3 = 10.0, y3 = 30.0, x = 10.0, y = 15.0;
		double x1 = shift_x(0.0, 0.0);
		double y1 = shift_y(0.0, 0.0);
		double x2 = shift_x(20.0, 0.0);
		double y2 = shift_y(20.0, 0.0);
		double x3 = shift_x(10.0, 30.0);
		double y3 = shift_y(10.0, 30.0);
		if (isInside(x1, y1, x2, y2, x3, y3, 10.0, 15.0))
			Console.WriteLine("Inside");
		else
			Console.WriteLine("Not Inside");
	}
}