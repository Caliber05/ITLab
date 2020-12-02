using System;

namespace TrafficDelegate
{
    public delegate string TrafficDel(string colour);
    class Program
    {

        static void Main(string[] args)
        {
            TrafficDel tDel;
            tDel = Red;
            string temp = "";
            string curr_colour = tDel(temp);
            Console.WriteLine("Signal is " + curr_colour);
            tDel = Yellow;
            curr_colour = tDel(temp);
            Console.WriteLine("Signal is " + curr_colour);
            tDel = Green;
            curr_colour = tDel(temp);
            Console.WriteLine("Signal is " + curr_colour);
            Console.ReadLine();
        }

        private static string Yellow(string colour)
        {
            colour = "Yellow";
            return colour;
        }

        private static string Red(string colour)
        {
            colour = "Red";
            return colour;
        }

        private static string Green(string colour)
        {
            colour = "Green";
            return colour;
        }


    }
}
