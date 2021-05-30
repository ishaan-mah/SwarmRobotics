using System;

class rectangle
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
	static bool FindPoint(double x4, double x2, double y1, double y3, double x, double y)
	{
		if (x >= x4 && x <= x2 &&y >= y1 && y <= y3)
			return true;
		return false;
	}

	// Driver code
	public static void Main()
	{

		double x1 = shift_x(0.0, 0.0);
		double y1 = shift_y(0.0, 0.0);
		double x2 = shift_x(15.0, 0.0);
		double y2 = shift_y(15.0, 0.0);
		double x3 = shift_x(15.0, 16.0);
		double y3 = shift_y(15.0, 16.0);
		double x4 = shift_x(0.0, 16.0);
		double y4 = shift_y(0.0, 16.0);

		double x = 15.0, y = 23.0;

		if (FindPoint(x4, x2, y1, y3, x, y))
			Console.Write("Yes");
		else
			Console.Write("No");
	}
}

