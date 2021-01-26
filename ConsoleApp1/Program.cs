using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste";      
            
            
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
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
