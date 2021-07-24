using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotNetFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            var storesDirectory = Path.Combine(currentDirectory, "stores");

            var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
            Directory.CreateDirectory(salesTotalDir);

            var salesFiles = FindFiles(storesDirectory);

            var salesTotal = CalculateSalesTotal(salesFiles);

            File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");
        }

        static IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                var extension = Path.GetExtension(file);

                if (extension == ".json")
                {
                    salesFiles.Add(file);
                }
            }

            return salesFiles;
        }

        class SalesData
        {
            public double Total { get; set; }
        }

        static double CalculateSalesTotal(IEnumerable<string> salesFiles)
        {
            double salesTotal = 0;

            foreach (var file in salesFiles)
            {
                string salesJson = File.ReadAllText(file);

                SalesData data = JsonConvert.DeserializeObject<SalesData>(salesJson);

                salesTotal += data.Total;
            }

            return salesTotal;
        }

        class SalesTotal
        {
            public double Total { get; set; }
        }

        static void ExampleCode()
        {
            // This is all code that was taught in the lesson but not used in the actual program itself.

            // Get the directory the application is running in
            Console.WriteLine(Directory.GetCurrentDirectory());

            // get special folders like my documents
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // directory separator character (e.g. \ on windows, / on mac)
            Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

            // join paths
            Console.WriteLine(Path.Combine("stores", "201"));

            // get file type
            Console.WriteLine(Path.GetExtension("sales.json"));

            // Path class being useful
            string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

            FileInfo info = new FileInfo(fileName);

            Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}");

            // create a directory
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));

            // check if directory exists
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "stores", "201");
            bool directoryExists = Directory.Exists(filePath);

            // creating a file
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");

            // read from a file
            File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");

            // parse data from a file
            var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
            var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

            Console.WriteLine(salesData.Total);

            // write data to a file
            var data = JsonConvert.DeserializeObject<SalesTotal>($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");

            File.WriteAllText($"SalesTotals{Path.DirectorySeparatorChar}totals.txt", data.Total.ToString());

            // append data to a file
            var data2 = JsonConvert.DeserializeObject<SalesTotal>($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");

            File.AppendAllText($"SalesTotals{Path.DirectorySeparatorChar}totals.txt", $"{data2.Total}{Environment.NewLine}");
        }
    }
}
