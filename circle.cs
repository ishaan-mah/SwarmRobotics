using System;

class circle
{

	static double shift_x(double x, double y)
	{
		double x_translate = 10.0;
		double rot_angle = Math.PI / 6.0;
		return ((x + x_translate) * Math.Cos(rot_angle) - y * Math.Sin(rot_angle));
	}

	static double shift_y(double x, double y)
	{
		double y_translate = 15.0;
		double rot_angle = Math.PI / 6.0;
		return (x * Math.Sin(rot_angle) + (y + y_translate) * Math.Cos(rot_angle));
	}

	static bool isInside(double circle_x, double circle_y, double rad, double x, double y)
	{
		if (((x - circle_x) * (x - circle_x) + (y - circle_y) * (y - circle_y)) <= (rad * rad))
			return true;
		else
			return false;
	}

	public static void Main()
	{
		double x = 5.0, y = 10.0;
		double circle_x = shift_x(3.0, 3.0);
		double circle_y = shift_y(3.0, 3.0);
		double rad = 10.0;

		if (isInside(circle_x, circle_y, rad, x, y))
			Console.Write("Inside");
		else
			Console.Write("Outside");
	}
}
