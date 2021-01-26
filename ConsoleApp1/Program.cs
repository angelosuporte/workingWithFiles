using System;
using System.IO;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste";      
            
            
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(@"c:\teste\directoryCreated");
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
