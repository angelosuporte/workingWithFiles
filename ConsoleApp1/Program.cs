using System;
using System.IO;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\teste\file1.txt";
            string targetPath = @"c:\teste\file2.text";
            
            
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        foreach (string line in lines)
                        {
                        sw.WriteLine(line.ToUpper());
                        }
                    }
                Console.WriteLine("Enter");
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
