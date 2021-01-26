using System;
using System.IO;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\file1.txt";
            
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
               
                Console.ReadKey();

            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
