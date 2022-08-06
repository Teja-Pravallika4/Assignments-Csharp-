
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace Average
{
    class HighestNumber
    {
        public static void Main()
        {

            Console.Write("\n\n");
            Console.Write("Find the highest marks among them:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Enter the average marks of 1st student:");
            decimal a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the average marks of 2nd student :");
            decimal b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the average marks of 3rd student :");
            decimal c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the average marks of 4th student :");
            decimal d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the average marks of 5th student :");
            decimal e = Convert.ToInt32(Console.ReadLine());


            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("The highest marks is: {0}", a);
                return;
            }
            if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
            {
                Console.WriteLine("The highest marks is: {0}", b);
                return;
            }
            if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("The highest marks  is: {0}", c);
                return;
            }
            if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("The highest maarks is: {0}", d);
                return;
            }
            if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("The highest marks  is: {0}", e);
                return;
            }
        }
    }
}
