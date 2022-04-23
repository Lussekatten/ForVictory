using System;
using System.IO;

namespace FileHandlingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteStringToFile();
            //Console.Read();

            //ReadFromFile();
            //Console.Read();

            AddNumbersFromString();
            Console.Read();
        }

        /// <summary>
        /// Function that writes a line of text to a file
        /// If you run the program again, the new line will replace the old one.
        /// </summary>
        static void WriteStringToFile()
        {
            Console.WriteLine("Skriv en kort mening");
            string fromUser = Console.ReadLine();

            // Set a variable to the My Documents path.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\filename.txt"))
            {
                outputFile.WriteLine(fromUser);
                outputFile.Close();
            }
            Console.WriteLine("Klar med att skriva din text till fil");
            Console.WriteLine("Du hittar din fil i \"Documents\" mappen med namnet filename.txt");
        }

        /// <summary>
        /// Here, we read from the same file
        /// If you add manually more rows to the file, the results will change.
        /// </summary>
        static void ReadFromFile()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int counter = 0;

            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(mydocpath + @"\filename.txt"))
            {
                System.Console.WriteLine(line);
                counter++;
            }

            System.Console.WriteLine("\n{0} rader kunde läsas från filen filename.txt", counter);
        }

        static void AddNumbersFromString()
        {
            Console.WriteLine("Skriv dina heltal, komma separerade");
            string fromUser = Console.ReadLine();
            string[] arr = fromUser.Split(',');
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }
            Console.WriteLine("Summan blir lika med {0}",sum);
        }
    }
}
