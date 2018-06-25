using System;

class PriceChangeAlert
{
    static void Main()
    {
        int prices = int.Parse(Console.ReadLine());
        double border = double.Parse(Console.ReadLine());
        double first = double.Parse(Console.ReadLine());

        for (int i = 0; i < prices - 1; i++)
        {
            double currPrice = double.Parse(Console.ReadLine());
            double div = Proc(first, currPrice);
            bool isSignificantDifference = CheckDiff(div, border);
            string message = Get(currPrice, first, div, isSignificantDifference);
            Console.WriteLine(message);
            first = currPrice;
        }
    }

    private static string Get(double c, double last, double diff, bool isTrue)
    {
        string to = "";
        if (diff == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!isTrue)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, diff*100);
        }
        else if (isTrue && (diff > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, diff*100);
        }
        else if (isTrue && (diff < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, diff*100);
        return to;
    }
    private static bool CheckDiff(double border, double isDiff)
    {
        if (Math.Abs(border) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
