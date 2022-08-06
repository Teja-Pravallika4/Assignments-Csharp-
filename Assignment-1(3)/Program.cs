using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_3_
{
    public class ParamArray
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] number = { 20, 30, 40, 50, 100 };
                int n = number.Length;
                Param(number);

                static int Param(params int[] number)
                {
                    int sum = 0;
                    for (int i = 0; i < number.Length; i++)
                    {
                        sum = sum + number[i];
                    }
                    Console.WriteLine(" sum of all integers:{0}", sum);
                    return sum;
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


