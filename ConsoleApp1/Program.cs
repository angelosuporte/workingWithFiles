using System;
using System.IO;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\teste\file1.txt";
            string targetPath = @"c:\teste\copyOffile1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
