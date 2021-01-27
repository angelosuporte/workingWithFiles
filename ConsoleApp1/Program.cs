using System;
using System.IO;
using System.Globalization;
using WorkingFiles.Entities;

namespace WorkingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise
            string sales = @"c:\test\sales.csv";

            try
            {
                string[] salelines = File.ReadAllLines(sales);

                string sourceFolderPath = Path.GetDirectoryName(sales);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summarySales.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in salelines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Sale sale = new Sale(name, price, quantity);

                        sw.WriteLine(sale.Name + "," + sale.Total().ToString("F2", CultureInfo.InvariantCulture));

                    }
                }
                Console.WriteLine("Enter");
                Console.ReadKey();

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
