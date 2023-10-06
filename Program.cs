Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());


switch (n)
{
    case 1:
        {

            double y = 0;
            double a = 6;
            double b = 32;
            double z = Math.Exp(1.5 * a * x);
            if (x < Math.Log(a)) y = 3.5 * a - 7.3 * b * x + (Math.Sin((z * x) * (z * x) * (z * x)));
            else if (Math.Log(a) <= x && x >= b * b) y = Math.Pow(a, b) - Math.Cos(a + z * x);
            else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - (x * x);
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 2:
        {

            double y = 0;
            double a = 3;
            double b = 6;
            double z = Math.Exp(1.5 * a * x);
            if (x < Math.Log(a)) y = 3.5 * a - 7.3 * b * x + (Math.Sin((z * x) * (z * x) * (z * x)));
            else if (Math.Log(a) <= x && x >= b * b) y = Math.Pow(a, b) - Math.Cos(a + z * x);
            else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - (x * x);
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 3:
        {

            double y = 0;
            double a = 2.7;
            double b = 1.8;
            double z = Math.Exp(1.5 * a * x);
            if (x < Math.Log(a)) y = 3.5 * a - 7.3 * b * x + (Math.Sin((z * x) * (z * x) * (z * x)));
            else if (Math.Log(a) <= x && x >= b * b) y = Math.Pow(a, b) - Math.Cos(a + z * x);
            else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - (x * x);
            Console.WriteLine($"y={y:F2}");
        }
        break;

}