using System;

public class Program
{
    public static void Main()
    {
        var divider = 0;

        try
        {
            try
            {
                var result = 100 / divider;
            }
            catch
            {
                Console.WriteLine("Inner catch");
            }
        }
        catch
        {
            Console.WriteLine("Outer catch");
        }
    }
}