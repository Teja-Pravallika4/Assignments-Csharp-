
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swaping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                swap();

                static void swap()
                {
                    int a = 8, b = 15;
                    Console.WriteLine("Before swap a=" + a + "b" + b);
                    a = a * b;
                    b = a / b;
                    a = a / b;
                    Console.WriteLine("After swap a=" + a + "b=" + b);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();

        }
    }
}
