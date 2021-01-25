using System;
using System.IO;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\file1.txt";
            
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                Console.ReadKey();

            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally //It is necessary to close manually
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
