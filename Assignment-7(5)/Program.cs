using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Createdirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Method  
            String path = @"D:\MyTestFile1.txt";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }

            // CreateSubdirectory Method  
            String path1 = @"D:\MyTestFile1.txt";
            DirectoryInfo f2 = new DirectoryInfo(path);
            DirectoryInfo dis = fl.CreateSubdirectory("hellotest");
            {
                Console.WriteLine("Directory has been created");
            }

            // GetDirectories method  
            try
            {
                DirectoryInfo di = new DirectoryInfo(@"D:\newFile\");
                DirectoryInfo[] dir1 = di.GetDirectories();
                Console.WriteLine("The number of directories containing is {0}.", dir1.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            // GetFiles method  
            DirectoryInfo di = new DirectoryInfo(@"D:\newfile");
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                Console.WriteLine("The number of files in {0} is {1}", diNext,
                diNext.GetFiles().Length);
            }
        }
    }
}
