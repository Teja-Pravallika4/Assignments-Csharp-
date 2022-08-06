using System;
using System.Collections.Generic;

namespace GenericClassList
{
    public class Employee<T>
    {
        // define an Array of Generic type with length 4
        T[] obj = new T[4];
        int count = 0;

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 5)
            {
                obj[count] = item;

            }
            count++;
        }
        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate generic with String
            Employee<String> l1 = new Employee<String>();

            //adding integer values into collection
            l1.Add("A1");
            l1.Add("A2");
            l1.Add("A3");
            l1.Add("A4");


            //displaying values
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine(l1[i]);
            }
            Console.ReadKey();
        }
    }
}