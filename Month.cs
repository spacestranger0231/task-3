using System;
using System.Collections.Generic;
using System.Text;

namespace hometask3
{
    static class Month
    {
        static Month() { }
        public static void month(this DateTime date)
        {
            if (date.Month == 1)
                Console.WriteLine("January");
            else if (date.Month == 2)
                Console.WriteLine("February");
            else if (date.Month == 3)
                Console.WriteLine("March");
            else if (date.Month == 4)
                Console.WriteLine("April");
            else if (date.Month == 5)
                Console.WriteLine("May");
            else if (date.Month == 6)
                Console.WriteLine("June");
            else if (date.Month == 7)
                Console.WriteLine("July");
            else if (date.Month == 8)
                Console.WriteLine("August");
            else if (date.Month == 9)
                Console.WriteLine("September");
            else if (date.Month == 10)
                Console.WriteLine("October");
            else if (date.Month == 11)
                Console.WriteLine("November");
            else if (date.Month == 12)
                Console.WriteLine("December");

        }
    }
}
